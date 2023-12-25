## Bounds
Represents an axis **aligned bounding box**.

An a**xis-aligned bounding box**, or **AABB** for short, is a box aligned with coordinate axes and fully enclosing some object. Because the box is never rotated with respect to the axes, it can be defined by just its center and extents, or alternatively by min and max points.

### `Collider.bounds`
The world space bounding volume of the collider (Read Only).
> **Note**: this will be an empty bounding box if the collider is disabled or the game object is inactive.
 
https://docs.unity3d.com/ScriptReference/Collider-bounds.html

### `Mesh.bounds`
The bounding volume of the Mesh.
This is the axis-aligned bounding box of the mesh in its own space, so the bounds don't change if you change the Transform position, rotation or scale.

https://docs.unity3d.com/ScriptReference/Mesh-bounds.html

### `Renderer.bounds`
The bounding box of the renderer in world space. \
This is the axis-aligned bounding box fully enclosing the object in world space.

https://docs.unity3d.com/ScriptReference/Renderer-bounds.html

### ref
https://docs.unity3d.com/ScriptReference/Bounds.html



