namespace Tilia.Locomotors.Teleporter
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Enum;
    using Zinnia.Data.Type;
    using Zinnia.Tracking;
    using Zinnia.Tracking.Modification;
    using Zinnia.Visual;

    /// <summary>
    /// Sets up the Teleport Prefab based on the provided user settings.
    /// </summary>
    public class TeleporterConfigurator : MonoBehaviour
    {
        #region Facade Settings
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public TeleporterFacade Facade { get; protected set; }
        #endregion

        #region Teleporter Settings
        /// <summary>
        /// The <see cref="SurfaceLocator"/> to use for the teleporting event.
        /// </summary>
        [Serialized]
        [field: Header("Teleporter Settings"), DocumentedByXml, Restricted]
        public SurfaceLocator SurfaceTeleporter { get; protected set; }
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> to use for the teleporting event.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformPropertyApplier ModifyTeleporter { get; protected set; }
        #endregion

        #region Alias Settings
        /// <summary>
        /// The <see cref="SurfaceLocator"/> to set aliases on.
        /// </summary>
        [Serialized]
        [field: Header("Alias Settings"), DocumentedByXml, Restricted]
        public List<SurfaceLocator> SurfaceLocatorAliases { get; protected set; } = new List<SurfaceLocator>();
        /// <summary>
        /// The <see cref="SurfaceLocator"/> to set rules on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public List<SurfaceLocator> SurfaceLocatorRules { get; protected set; } = new List<SurfaceLocator>();
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> collection to set aliases on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public List<TransformPropertyApplier> TransformPropertyApplierAliases { get; protected set; } = new List<TransformPropertyApplier>();
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> collection to ignore offsets on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public List<TransformPropertyApplier> TransformPropertyApplierIgnoreOffsetAliases { get; protected set; } = new List<TransformPropertyApplier>();
        /// <summary>
        /// The scene <see cref="Camera"/>s to set the <see cref="CameraColorOverlay"/>s to affect.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public List<CameraColorOverlay> CameraColorOverlays { get; protected set; } = new List<CameraColorOverlay>();
        /// <summary>
        /// The <see cref="SurfaceChangeAction"/> that holds the threshold of whether a snap to floor should even occur.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public SurfaceChangeAction SnapToFloorThresholdController { get; protected set; }
        /// <summary>
        /// The <see cref="SurfaceChangeAction"/> that holds the threshold of whether a blink should occur when snapping to floor.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public SurfaceChangeAction SnapToFloorBlinkThresholdController { get; protected set; }
        #endregion

        /// <summary>
        /// A <see cref="SurfaceLocator"/> collection to store cached versions that get mutated but need changing back after process.
        /// </summary>
        protected List<SurfaceLocator> cachedLocators = new List<SurfaceLocator>();
        /// <summary>
        /// the <see cref="Facade.SnapToFloorBlinkThreshold"/> value before it is mutated.
        /// </summary>
        protected float cachedSnapToFloorBlinkThreshold;
        /// <summary>
        /// The routine for resetting cached data.
        /// </summary>
        protected Coroutine resetCachedDataRoutine;

        /// <summary>
        /// Attempts to teleport the <see cref="TeleporterFacade.Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(TransformData destination)
        {
            if (SurfaceTeleporter != null)
            {
                SurfaceTeleporter.Locate(destination);
            }

            if (ModifyTeleporter != null)
            {
                ModifyTeleporter.Source = destination;
                ModifyTeleporter.Apply();
            }
        }

        /// <summary>
        /// Notifies that the teleporter is about to initiate.
        /// </summary>
        /// <param name="data">The location data.</param>
        public virtual void NotifyTeleporting(TransformPropertyApplier.EventData data)
        {
            Facade.Teleporting?.Invoke(data);
        }

        /// <summary>
        /// Notifies that the teleporter has completed.
        /// </summary>
        /// <param name="data">The location data.</param>
        public virtual void NotifyTeleported(TransformPropertyApplier.EventData data)
        {
            Facade.Teleported?.Invoke(data);
        }

        /// <summary>
        /// Configures the surface locator aliases with the offset provided in the facade.
        /// </summary>
        public virtual void ConfigureSurfaceLocatorAliases()
        {
            foreach (SurfaceLocator currentLocator in SurfaceLocatorAliases)
            {
                currentLocator.SearchOrigin = Facade.Offset;
            }
        }

        /// <summary>
        /// Configures the surface locator rules with the valid targets provided in the facade.
        /// </summary>
        public virtual void ConfigureSurfaceLocatorRules()
        {
            foreach (SurfaceLocator currentLocator in SurfaceLocatorRules)
            {
                currentLocator.TargetValidity = Facade.TargetValidity;
            }
        }

        /// <summary>
        /// Configures the surface locator rules with the valid targets provided in the facade.
        /// </summary>
        public virtual void ConfigureSurfaceLocatorOffsets()
        {
            Facade.gameObject.SetActive(false);

            foreach (SurfaceLocator currentLocator in SurfaceLocatorRules)
            {
                Vector3 newOffset = Facade.DestinationOffset;
                if (Facade.DestinationOffset.Equals(Vector3.zero))
                {
                    cachedLocators.Add(currentLocator);
                    newOffset = Vector3.one * (currentLocator.PositionChangedEqualityThreshold + float.Epsilon);
                }
                currentLocator.DestinationOffset = newOffset;
            }

            cachedSnapToFloorBlinkThreshold = Facade.SnapToFloorBlinkThreshold;
            Facade.SnapToFloorBlinkThreshold = 0f;

            Facade.gameObject.SetActive(true);

            if (resetCachedDataRoutine == null)
            {
                resetCachedDataRoutine = StartCoroutine(ResetOffsetAtEndOfFrame());
            }
        }

        /// <summary>
        /// Configures the transform properties applies with the settings applied in the facade.
        /// </summary>
        public virtual void ConfigureTransformPropertyAppliers()
        {
            foreach (TransformPropertyApplier currentApplier in TransformPropertyApplierAliases)
            {
                currentApplier.Target = Facade.Target;
                currentApplier.Offset = null;

                if (!TransformPropertyApplierIgnoreOffsetAliases.Contains(currentApplier))
                {
                    currentApplier.Offset = Facade.Offset;
                    continue;
                }

                currentApplier.Offset = Facade.OffsetUsage == TeleporterFacade.OffsetType.OffsetAlwaysWithDestinationRotation || Facade.OffsetUsage == TeleporterFacade.OffsetType.OffsetAlwaysIgnoreDestinationRotation ? Facade.Offset : null;
                currentApplier.ApplyRotationOffsetOnAxis = Facade.OffsetUsage == TeleporterFacade.OffsetType.OffsetAlwaysWithDestinationRotation ? currentApplier.ApplyRotationOffsetOnAxis : Vector3State.False;
            }
        }

        /// <summary>
        /// Configures the camera color overlays with the scene cameras provided in the facade.
        /// </summary>
        public virtual void ConfigureCameraColorOverlays()
        {
            foreach (CameraColorOverlay currentOverlay in CameraColorOverlays)
            {
                currentOverlay.CameraValidity = Facade.CameraValidity;
            }
        }

        /// <summary>
        /// Configures whether the teleporter will apply the destination rotation to the target.
        /// </summary>
        public virtual void ConfigureRotationAbility(bool shouldRotate)
        {
            if (shouldRotate)
            {
                EnableRotations();
            }
            else
            {
                DisableRotations();
            }
        }

        /// <summary>
        /// Configures the surface change actions that determine the snap to floor functionality.
        /// </summary>
        /// <param name="snapToFloorThreshold">The threshold of whether the change distance should do a new snap to the found floor.</param>
        /// <param name="snapToFloorBlinkThreshold">The threshold of whether to blink the view.</param>
        public virtual void ConfigureSurfaceChangeActions(float snapToFloorThreshold, float snapToFloorBlinkThreshold)
        {
            SnapToFloorThresholdController.ChangeDistance = snapToFloorThreshold;
            SnapToFloorBlinkThresholdController.ChangeDistance = snapToFloorBlinkThreshold;
        }

        protected virtual void OnEnable()
        {
            ConfigureSurfaceLocatorAliases();
            ConfigureSurfaceLocatorRules();
            ConfigureTransformPropertyAppliers();
            ConfigureCameraColorOverlays();
            ConfigureRotationAbility(Facade.ApplyDestinationRotation);
            ConfigureSurfaceChangeActions(Facade.SnapToFloorThreshold, Facade.SnapToFloorBlinkThreshold);
        }

        /// <summary>
        /// Disables the ability to rotate the target.
        /// </summary>
        protected virtual void DisableRotations()
        {
            foreach (TransformPropertyApplier alias in TransformPropertyApplierIgnoreOffsetAliases)
            {
                alias.ApplyTransformations &= ~TransformProperties.Rotation;
            }
        }

        /// <summary>
        /// Enables the ability to rotate the target.
        /// </summary>
        protected virtual void EnableRotations()
        {
            foreach (TransformPropertyApplier alias in TransformPropertyApplierIgnoreOffsetAliases)
            {
                alias.ApplyTransformations |= TransformProperties.Rotation;
            }
        }

        /// <summary>
        /// Resets the data mutated by the destination offset update to the original cached values.
        /// </summary>
        /// <returns>An Enumerator to manage the running of the Coroutine.</returns>
        protected virtual IEnumerator ResetOffsetAtEndOfFrame()
        {
            yield return new WaitForEndOfFrame();

            Facade.SnapToFloorBlinkThreshold = cachedSnapToFloorBlinkThreshold;
            foreach (SurfaceLocator currentLocator in cachedLocators)
            {
                currentLocator.DestinationOffset = Vector3.zero;
            }

            cachedLocators.Clear();
            resetCachedDataRoutine = null;
        }
    }
}