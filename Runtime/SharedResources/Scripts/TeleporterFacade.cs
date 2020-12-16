namespace Tilia.Locomotors.Teleporter
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;
    using Zinnia.Tracking.Modification;

    /// <summary>
    /// The public interface into the Teleporter Prefab.
    /// </summary>
    public class TeleporterFacade : MonoBehaviour
    {
        /// <summary>
        /// The type of offset to apply when teleporting.
        /// </summary>
        public enum OffsetType
        {
            /// <summary>
            /// Updates the teleported position with the <see cref="Offset"/> affecting the position but the destination rotation has no effect on the teleported rotation.
            /// </summary>
            OffsetAlwaysIgnoreDestinationRotation,
            /// <summary>
            /// Updates the teleported position with the <see cref="Offset"/> affecting the position and the destination rotation affecting the teleported rotation.
            /// </summary>
            OffsetAlwaysWithDestinationRotation,
            /// <summary>
            /// Updates the teleported position but only uses the <see cref="Offset"/> when affecting the floor snap position but the destination rotation has no effect on the teleported rotation.
            /// </summary>
            OffsetFloorSnapOnlyIgnoreDestinationRotation
        }

        #region Teleporter Settings
        /// <summary>
        /// The target to move to the teleported position.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Teleporter Settings"), DocumentedByXml]
        public GameObject Target { get; set; }
        /// <summary>
        /// The offset to compensate the teleported target position by for both floor snapping and position movement.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject Offset { get; set; }
        /// <summary>
        /// Determines how to use the <see cref="Offset"/> when calculating the teleport location.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OffsetType OffsetUsage { get; set; }
        /// <summary>
        /// Determines if the teleport destination <see cref="Transform.rotation"/> will be applied to the <see cref="Target"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool ApplyDestinationRotation { get; set; } = true;
        /// <summary>
        /// The <see cref="Rule"/> of scene <see cref="Camera"/>s to apply a fade to.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public RuleContainer CameraValidity { get; set; }
        /// <summary>
        /// Allows to optionally determine targets based on the set rules.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public RuleContainer TargetValidity { get; set; }
        #endregion

        #region Floor Snap Settings
        /// <summary>
        /// The distance between the previous floor and current floor to determine if a snap to the new floor is required.
        /// </summary>
        [Serialized]
        [field: Header("Floor Snap Settings"), DocumentedByXml]
        public float SnapToFloorThreshold { get; set; } = float.Epsilon;
        /// <summary>
        /// The distance between the previous floor and current floor to determine if the screen should blink when snapping to the new floor.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float SnapToFloorBlinkThreshold { get; set; } = 0.3f;
        /// <summary>
        /// The position amount to offset the destination teleport position.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public Vector3 DestinationOffset { get; set; }
        #endregion

        #region Teleporter Events
        /// <summary>
        /// Emitted when the teleporting is about to initiate.
        /// </summary>
        [Header("Teleporter Events"), DocumentedByXml]
        public TransformPropertyApplier.UnityEvent Teleporting = new TransformPropertyApplier.UnityEvent();
        /// <summary>
        /// Emitted when the teleporting has completed.
        /// </summary>
        [DocumentedByXml]
        public TransformPropertyApplier.UnityEvent Teleported = new TransformPropertyApplier.UnityEvent();
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public TeleporterConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(Transform destination)
        {
            Teleport(new TransformData(destination));
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(GameObject destination)
        {
            Teleport(new TransformData(destination));
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(TransformData destination)
        {
            Configuration.Teleport(destination);
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/> to the given world position.
        /// </summary>
        /// <param name="destination">The world position to attempt to teleport to.</param>
        public virtual void Teleport(Vector3 destinationPosition)
        {
            GameObject transformLocation = new GameObject();
            TransformData destination = new TransformData(transformLocation.transform);
            destination.PositionOverride = destinationPosition;
            Teleport(destination);
            Destroy(transformLocation);
        }

        /// <summary>
        /// Sets <see cref="OffsetUsage"/>.
        /// </summary>
        /// <param name="offsetTypeIndex">The index of the <see cref="OffsetType"/>.</param>
        public virtual void SetOffsetUsage(int offsetTypeIndex)
        {
            OffsetUsage = EnumExtensions.GetByIndex<OffsetType>(offsetTypeIndex);
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Target))]
        protected virtual void OnAfterTargetChange()
        {
            Configuration.ConfigureTransformPropertyAppliers();
        }

        /// <summary>
        /// Called after <see cref="Offset"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Offset))]
        protected virtual void OnAfterOffsetChange()
        {
            Configuration.ConfigureSurfaceLocatorAliases();
            Configuration.ConfigureTransformPropertyAppliers();
        }

        /// <summary>
        /// Called after <see cref="OffsetUsage"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(OffsetUsage))]
        protected virtual void OnAfterOffsetUsageChange()
        {
            Configuration.ConfigureTransformPropertyAppliers();
        }

        /// <summary>
        /// Called after <see cref="ApplyDestinationRotation"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(ApplyDestinationRotation))]
        protected virtual void OnAfterApplyDestinationRotationChange()
        {
            Configuration.ConfigureRotationAbility(ApplyDestinationRotation);
        }

        /// <summary>
        /// Called after <see cref="CameraValidity"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(CameraValidity))]
        protected virtual void OnAfterCameraValidityChange()
        {
            Configuration.ConfigureCameraColorOverlays();
        }

        /// <summary>
        /// Called after <see cref="TargetValidity"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(TargetValidity))]
        protected virtual void OnAfterTargetValidityChange()
        {
            Configuration.ConfigureSurfaceLocatorRules();
        }

        /// <summary>
        /// Called after <see cref="SnapToFloorThreshold"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(SnapToFloorThreshold))]
        protected virtual void OnAfterSnapToFloorThresholdChange()
        {
            Configuration.ConfigureSurfaceChangeActions(SnapToFloorThreshold, SnapToFloorBlinkThreshold);
        }

        /// <summary>
        /// Called after <see cref="SnapToFloorBlinkThreshold"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(SnapToFloorBlinkThreshold))]
        protected virtual void OnAfterSnapToFloorBlinkThresholdChange()
        {
            Configuration.ConfigureSurfaceChangeActions(SnapToFloorThreshold, SnapToFloorBlinkThreshold);
        }

        /// <summary>
        /// Called after <see cref="DestinationOffset"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(DestinationOffset))]
        protected virtual void OnAfterDestinationOffsetChange()
        {
            Configuration.ConfigureSurfaceLocatorOffsets();
        }
    }
}