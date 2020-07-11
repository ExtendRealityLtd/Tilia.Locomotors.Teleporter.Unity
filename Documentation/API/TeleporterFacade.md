# Class TeleporterFacade

The public interface into the Teleporter Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [Teleported]
  * [Teleporting]
* [Properties]
  * [ApplyDestinationRotation]
  * [CameraValidity]
  * [Configuration]
  * [Offset]
  * [OffsetUsage]
  * [SnapToFloorBlinkThreshold]
  * [SnapToFloorThreshold]
  * [Target]
  * [TargetValidity]
* [Methods]
  * [OnAfterApplyDestinationRotationChange()]
  * [OnAfterCameraValidityChange()]
  * [OnAfterOffsetChange()]
  * [OnAfterOffsetUsageChange()]
  * [OnAfterSnapToFloorBlinkThresholdChange()]
  * [OnAfterSnapToFloorThresholdChange()]
  * [OnAfterTargetChange()]
  * [OnAfterTargetValidityChange()]
  * [SetOffsetUsage(Int32)]
  * [Teleport(GameObject)]
  * [Teleport(Transform)]
  * [Teleport(TransformData)]

## Details

##### Inheritance

* System.Object
* TeleporterFacade

##### Namespace

* [Tilia.Locomotors.Teleporter]

##### Syntax

```
public class TeleporterFacade : MonoBehaviour
```

### Fields

#### Teleported

Emitted when the teleporting has completed.

##### Declaration

```
public TransformPropertyApplier.UnityEvent Teleported
```

#### Teleporting

Emitted when the teleporting is about to initiate.

##### Declaration

```
public TransformPropertyApplier.UnityEvent Teleporting
```

### Properties

#### ApplyDestinationRotation

Determines if the teleport destination Transform.rotation will be applied to the [Target].

##### Declaration

```
public bool ApplyDestinationRotation { get; set; }
```

#### CameraValidity

The Rule of scene Cameras to apply a fade to.

##### Declaration

```
public RuleContainer CameraValidity { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public TeleporterConfigurator Configuration { get; protected set; }
```

#### Offset

The offset to compensate the teleported target position by for both floor snapping and position movement.

##### Declaration

```
public GameObject Offset { get; set; }
```

#### OffsetUsage

Determines how to use the [Offset] when calculating the teleport location.

##### Declaration

```
public TeleporterFacade.OffsetType OffsetUsage { get; set; }
```

#### SnapToFloorBlinkThreshold

The distance between the previous floor and current floor to determine if the screen should blink when snapping to the new floor.

##### Declaration

```
public float SnapToFloorBlinkThreshold { get; set; }
```

#### SnapToFloorThreshold

The distance between the previous floor and current floor to determine if a snap to the new floor is required.

##### Declaration

```
public float SnapToFloorThreshold { get; set; }
```

#### Target

The target to move to the teleported position.

##### Declaration

```
public GameObject Target { get; set; }
```

#### TargetValidity

Allows to optionally determine targets based on the set rules.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

### Methods

#### OnAfterApplyDestinationRotationChange()

Called after [ApplyDestinationRotation] has been changed.

##### Declaration

```
protected virtual void OnAfterApplyDestinationRotationChange()
```

#### OnAfterCameraValidityChange()

Called after [CameraValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterCameraValidityChange()
```

#### OnAfterOffsetChange()

Called after [Offset] has been changed.

##### Declaration

```
protected virtual void OnAfterOffsetChange()
```

#### OnAfterOffsetUsageChange()

Called after [OffsetUsage] has been changed.

##### Declaration

```
protected virtual void OnAfterOffsetUsageChange()
```

#### OnAfterSnapToFloorBlinkThresholdChange()

Called after [SnapToFloorBlinkThreshold] has been changed.

##### Declaration

```
protected virtual void OnAfterSnapToFloorBlinkThresholdChange()
```

#### OnAfterSnapToFloorThresholdChange()

Called after [SnapToFloorThreshold] has been changed.

##### Declaration

```
protected virtual void OnAfterSnapToFloorThresholdChange()
```

#### OnAfterTargetChange()

Called after [Target] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

#### OnAfterTargetValidityChange()

Called after [TargetValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetValidityChange()
```

#### SetOffsetUsage(Int32)

Sets [OffsetUsage].

##### Declaration

```
public virtual void SetOffsetUsage(int offsetTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | offsetTypeIndex | The index of the [TeleporterFacade.OffsetType]. |

#### Teleport(GameObject)

Attempts to teleport the [Target].

##### Declaration

```
public virtual void Teleport(GameObject destination)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | destination | The location to attempt to teleport to. |

#### Teleport(Transform)

Attempts to teleport the [Target].

##### Declaration

```
public virtual void Teleport(Transform destination)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Transform | destination | The location to attempt to teleport to. |

#### Teleport(TransformData)

Attempts to teleport the [Target].

##### Declaration

```
public virtual void Teleport(TransformData destination)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TransformData | destination | The location to attempt to teleport to. |

[Tilia.Locomotors.Teleporter]: README.md
[Target]: TeleporterFacade.md#Target
[TeleporterConfigurator]: TeleporterConfigurator.md
[Offset]: TeleporterFacade.md#Offset
[ApplyDestinationRotation]: TeleporterFacade.md#ApplyDestinationRotation
[CameraValidity]: TeleporterFacade.md#CameraValidity
[Offset]: TeleporterFacade.md#Offset
[OffsetUsage]: TeleporterFacade.md#OffsetUsage
[SnapToFloorBlinkThreshold]: TeleporterFacade.md#SnapToFloorBlinkThreshold
[SnapToFloorThreshold]: TeleporterFacade.md#SnapToFloorThreshold
[Target]: TeleporterFacade.md#Target
[TargetValidity]: TeleporterFacade.md#TargetValidity
[OffsetUsage]: TeleporterFacade.md#OffsetUsage
[TeleporterFacade.OffsetType]: TeleporterFacade.OffsetType.md
[Target]: TeleporterFacade.md#Target
[Target]: TeleporterFacade.md#Target
[Target]: TeleporterFacade.md#Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Teleported]: #Teleported
[Teleporting]: #Teleporting
[Properties]: #Properties
[ApplyDestinationRotation]: #ApplyDestinationRotation
[CameraValidity]: #CameraValidity
[Configuration]: #Configuration
[Offset]: #Offset
[OffsetUsage]: #OffsetUsage
[SnapToFloorBlinkThreshold]: #SnapToFloorBlinkThreshold
[SnapToFloorThreshold]: #SnapToFloorThreshold
[Target]: #Target
[TargetValidity]: #TargetValidity
[Methods]: #Methods
[OnAfterApplyDestinationRotationChange()]: #OnAfterApplyDestinationRotationChange
[OnAfterCameraValidityChange()]: #OnAfterCameraValidityChange
[OnAfterOffsetChange()]: #OnAfterOffsetChange
[OnAfterOffsetUsageChange()]: #OnAfterOffsetUsageChange
[OnAfterSnapToFloorBlinkThresholdChange()]: #OnAfterSnapToFloorBlinkThresholdChange
[OnAfterSnapToFloorThresholdChange()]: #OnAfterSnapToFloorThresholdChange
[OnAfterTargetChange()]: #OnAfterTargetChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[SetOffsetUsage(Int32)]: #SetOffsetUsageInt32
[Teleport(GameObject)]: #TeleportGameObject
[Teleport(Transform)]: #TeleportTransform
[Teleport(TransformData)]: #TeleportTransformData