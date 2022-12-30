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
Colliders on a GameObject that has a Rigidbody are known as **dynamic colliders**. 

### Rigidbody colliders
This is a GameObject with a Collider and a normal, non-kinematic Rigidbody attached. Rigidbody colliders are fully simulated by the physics engine and can react to collisions and forces

### Kinematic Rigidbody collider
A a GameObject with a Collider and **a kinematic Rigidbody attached** (ie, the **`IsKinematic`** property of the Rigidbody is **enabled**).

If you don’t want the trigger to fall under gravity or otherwise be affected by physics then you can set the `IsKinematic` property on its rigidbody.

A Rigidbody component can be switched between normal and kinematic behavior at any time using the `IsKinematic` property.

> **Kinematic rigidbodies** should be used for colliders that can be moved or disabled/enabled **occasionally**

### Physic Material
The Physic Material adjusts friction and bouncing effects of colliding GameObjectsThe fundamental object in Unity scenes, which can represent characters, props, scenery, cameras, waypoints, and more. A GameObject’s functionality is defined by the Components attached to it.

https://docs.unity3d.com/Manual/class-PhysicMaterial.html


### Trigger
A collider configured as a **Trigger** (using the **Is Trigge**r property) does not behave as a solid object and **will simply allow other colliders to pass through**. When a collider enters its space, a **trigger will call the `OnTriggerEnter` function** on the trigger object’s scripts

#### Is **trigger** or not?
If one of collider is trigger, both collider **will pass through each other** whereas **non trigger do not**.  So,  if both collider without at least one of these is trigger, they **will not pass through each other**


.
