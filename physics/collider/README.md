## collider

A collider is invisible, and does not need to be the exact same shape as the GameObject’s mesh. A rough approximation of the mesh is often more efficient and indistinguishable in gameplay.

The simplest (and least processor-intensive) colliders are primitive collider types. In 3D, these are the **Box Collider**, **Sphere Collider** and **Capsule Collider**. In 2D, you can use the **Box Collider 2D** and **Circle Collider 2D**. **You can add any number of these to a single GameObject to create compound colliders**.


### Mesh colliders
In 3D, you can use Mesh Colliders to match the shape of the GameObject’s mesh exactly.

https://docs.unity3d.com/Manual/class-MeshCollider.html

### Polygon Collider 2D
The Collider’s shape is defined by a freeform edge made of line segments, that you can adjust to fit the shape of the Sprite or any other shape. 
 > **Note: that this Collider’s edge must completely enclose an area to function.**

https://docs.unity3d.com/Manual/class-PolygonCollider2D.html

### Static colliders
You can add colliders to a GameObject without a Rigidbody component to create floors, walls and other motionless elements of a Scene. These are referred to as **static colliders**.

Static colliders can interact with dynamic colliders but since they don’t have a Rigidbody, they don’t move in response to collisions.

> A static collider is a GameObject that has a Collider but **no Rigidbody**. For motionless gameobject(**死物**), its collider is static collider(**no rigid body**)

### Dynamic colliders
Colliders on a GameObject that has a Rigidbody are known as dynamic colliders. 
