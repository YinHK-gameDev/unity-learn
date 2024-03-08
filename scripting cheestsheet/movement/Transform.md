## Transform
https://docs.unity3d.com/ScriptReference/Transform.html

### `Transform.Translate`
Moves the transform in the direction and distance of translation.
```cs
public void Translate(Vector3 translation);
```
```cs
  transform.Translate(Vector3.forward * Time.deltaTime);

```
```cs
public void Translate(Vector3 translation, Space relativeTo = Space.Self);
```

https://docs.unity3d.com/ScriptReference/Transform.Translate.html

### `Transform.Rotate()`

Use Transform.Rotate to rotate GameObjects in a variety of ways. The rotation is **often provided as an Euler angle** and **not a Quaternion**.

You can specify a rotation in world axes or local axes.

```cs
public void Rotate(Vector3 eulers, Space relativeTo = Space.Self);
```

```cs
public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo = Space.Self);
```

```cs
public void Rotate(Vector3 axis, float angle, Space relativeTo = Space.Self);
```

```cs
public void Rotate(Vector3 eulers);
```

```cs
public void Rotate(float xAngle, float yAngle, float zAngle);
```

```cs
public void Rotate(Vector3 axis, float angle);
```

https://docs.unity3d.com/ScriptReference/Transform.Rotate.html

### `Transform.position`
The world space position of the Transform.

https://docs.unity3d.com/ScriptReference/Transform-position.html


### `Transform.LookAt()`
Rotates the transform so the forward vector points at target's current position. For example: camera point at the target object.
```cs
public void LookAt(Transform target);
```

```cs
public void LookAt(Transform target, Vector3 worldUp = Vector3.up);
```
| Parameters | Descriptions |
| - | - |
| target | Object to point towards |
| worldUp | Vector specifying the upward direction |

https://docs.unity3d.com/ScriptReference/Transform.LookAt.html


### `Transform.parent`
The parent of the transform.

Changing the parent will modify the parent-relative position, scale and rotation but keep the world space position, rotation and scale the same.

https://docs.unity3d.com/ScriptReference/Transform-parent.html


### `Transform.SetParent`
Set the parent of the transform.

This method is the same as the parent property except that it also lets the Transform keep its local orientation rather than its global orientation. 

https://docs.unity3d.com/ScriptReference/Transform.SetParent.html

### `Transform.GetChild`
Returns a transform child by index.

```cs
public Transform GetChild(int index);
```

https://docs.unity3d.com/ScriptReference/Transform.GetChild.html

### `Transform.Find`
Finds a child by name n and returns it.

If no child with name n can be found, null is returned. If n **contains a '/' character** it will **access the Transform in the hierarchy like a path name**.

> **Note**: `Find` does not perform a **recursive descend down a Transform hierarchy**.
> **Note**: `Find` can find transform of **disabled GameObject**.

```cs
public Transform Find(string n);
```

```cs
public Transform gun;
public Transform ammo;

//Finds and assigns the child named "Gun".
gun = player.transform.Find("Gun");

//Find the child named "ammo" of the gameobject "magazine" (magazine is a child of "gun").
ammo = gun.transform.Find("magazine/ammo");
```

https://docs.unity3d.com/ScriptReference/Transform.Find.html

### `Transform.TransformDirection`

Transforms `direction` from local space to world space.

This operation is not affected by scale or position of the transform. The returned vector has the same length as `direction`.

https://docs.unity3d.com/ScriptReference/Transform.TransformDirection.html


### Properties

| Properties | Descriptions |
| --- | --- |
| childCount | The number of children the parent Transform has. |
| eulerAngles | The rotation as Euler angles in degrees. |
| forward | Returns a normalized vector representing the blue axis of the transform in world space. |
| hasChanged | Has the transform changed since the last time the flag was set to 'false'? |
| hierarchyCapacity | The transform capacity of the transform's hierarchy data structure. |
| hierarchyCount | The number of transforms in the transform's hierarchy data structure. |
| localEulerAngles | The rotation as Euler angles in degrees relative to the parent transform's rotation. |
| localPosition | Position of the transform relative to the parent transform. |
| localRotation | The rotation of the transform relative to the transform rotation of the parent. |
| localScale | The scale of the transform relative to the GameObjects parent. |
| localToWorldMatrix | Matrix that transforms a point from local space into world space (Read Only). |
| lossyScale | The global scale of the object (Read Only). |
| parent | The parent of the transform. |
| position | The world space position of the Transform. |
| right | The red axis of the transform in world space. |
| root | Returns the topmost transform in the hierarchy. |
| rotation | A Quaternion that stores the rotation of the Transform in world space. |
| up | The green axis of the transform in world space. |
| worldToLocalMatrix | Matrix that transforms a point from world space into local space (Read Only). |


### Public Methods

| Public Methods | Descriptions |
| --- | --- |
| DetachChildren | Unparents all children. |
| Find | Finds a child by name n and returns it. |
| GetChild | Returns a transform child by index. |
| GetLocalPositionAndRotation | Gets the position and rotation of the Transform component in local space (that is, relative to its parent transform). |
| GetPositionAndRotation | Gets the position and rotation of the Transform component in world space. |
| GetSiblingIndex | Gets the sibling index. |
| InverseTransformDirection | Transforms a direction from world space to local space. The opposite of Transform.TransformDirection. |
| InverseTransformDirections | Transforms multiple directions from world space to local space overwriting each original position with the transformed version. The opposite of Transform.TransformDirections. |
| InverseTransformPoint | Transforms position from world space to local space. |
| InverseTransformPoints | Transforms multiple positions from world space to local space overwriting each original position with the transformed version. |
| InverseTransformVector | Transforms a vector from world space to local space. The opposite of Transform.TransformVector. |
| InverseTransformVectors | Transforms multiple vectors from world space to local space overwriting each original position with the transformed version. The opposite of Transform.TransformVectors. |
| IsChildOf | Is this transform a child of parent? |
| LookAt | Rotates the transform so the forward vector points at /target/'s current position. |
| Rotate | Use Transform.Rotate to rotate GameObjects in a variety of ways. The rotation is often provided as an Euler angle and not a Quaternion. |
| RotateAround | Rotates the transform about axis passing through point in world coordinates by angle degrees. |
| SetAsFirstSibling | Move the transform to the start of the local transform list. |
| SetAsLastSibling | Move the transform to the end of the local transform list. |
| SetLocalPositionAndRotation | Sets the position and rotation of the Transform component in local space (i.e. relative to its parent transform). |
| SetParent | Set the parent of the transform. |
| SetPositionAndRotation | Sets the world space position and rotation of the Transform component. |
| SetSiblingIndex | Sets the sibling index. |
| TransformDirection | Transforms direction from local space to world space. |
| TransformDirections | Transforms multiple directions from local space to world space overwriting each original direction with the transformed version. |
| TransformPoint | Transforms position from local space to world space. |
| TransformPoints | Transforms multiple points from local space to world space overwriting each original point with the transformed version. |
| TransformVector | Transforms vector from local space to world space. |
| TransformVectors | Transforms multiple vectors from local space to world space overwriting each original vector with the transformed version. |
| Translate | Moves the transform in the direction and distance of translation. |









