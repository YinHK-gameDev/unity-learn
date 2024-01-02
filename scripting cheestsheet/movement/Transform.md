## Transform

https://docs.unity3d.com/ScriptReference/Transform.html

### `Transform.Translate`

https://docs.unity3d.com/ScriptReference/Transform.Translate.html

### `Transform.Rotate()`

https://docs.unity3d.com/ScriptReference/Transform.Rotate.html

### `Transform.LookAt()`
Rotates the transform so the forward vector points at target's current position. For example: camera point at the target object.

https://docs.unity3d.com/ScriptReference/Transform.LookAt.html


### `Transform.parent`
The parent of the transform.

Changing the parent will modify the parent-relative position, scale and rotation but keep the world space position, rotation and scale the same.

https://docs.unity3d.com/ScriptReference/Transform-parent.html


### `Transform.SetParent`
Set the parent of the transform.

This method is the same as the parent property except that it also lets the Transform keep its local orientation rather than its global orientation. 

https://docs.unity3d.com/ScriptReference/Transform.SetParent.html

### `Transform.TransformDirection`

Transforms `direction` from local space to world space.

This operation is not affected by scale or position of the transform. The returned vector has the same length as `direction`.

https://docs.unity3d.com/ScriptReference/Transform.TransformDirection.html





