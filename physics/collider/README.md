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
Colliders on a GameObject that has a **Rigidbody** are known as **dynamic colliders**. \
Dynamic colliders: The GameObject’s physics body is dynamic (that is, it has **`IsKinematic` disabled**).

> **Note**: with **Rigidbody** & **`IsKinematic` disabled**

### Rigidbody colliders
This is a GameObject with a Collider and a normal, non-kinematic Rigidbody attached. Rigidbody colliders are fully simulated by the physics engine and can react to collisions and forces


> Adding a **Rigidbody component** to an object will **put its motion under the control of Unity's physics engine**. 

Even without adding any code, a Rigidbody object will be **pulled downward by gravity** and will react to collisions with incoming objects if the right Collider component is also present.


### Kinematic Rigidbody collider
A a GameObject with a Collider and **a kinematic Rigidbody attached** (ie, the **`IsKinematic`** property of the Rigidbody is **enabled**).

Kinematic rigidbody **cannot be affected by collisions and other forces**. If you don’t want the **trigger to fall under gravity** or otherwise **be affected by physics** then you can set the **`IsKinematic`** property on its rigidbody.

You can switch the **`IsKinematic`** property to make the gameobject a normal physics object, which will affected by physics. Like gravity or physical interaction pushed by other game objects.

A Rigidbody component can be switched between normal and kinematic behavior at any time using the **`IsKinematic`** property.

If the object with the Collider needs to be moved during gameplay then you should also attach a **Rigidbody component** to the object. The Rigidbody can be set to be **kinematic** if you don't want the object to have **physical interaction with other objects**. 

When you make something a kinematic, what you are essentially trying to do is disable, **the physics behaviour of a `Rigidbody` component**. This means that a **kinematic Rigidbody** does not get affected by **external forces**. **In essence, they can still push other rigid body colliders, but they cannot be pushed by other rigid bodies.**

> **Note**: **Kinematic rigidbodies** should be used for colliders that can be moved or disabled/enabled **occasionally** \
> Unlike a **static collider**, a moving kinematic rigidbody **will apply friction** to other objects \
> You can move a **kinematic rigidbody object** from a script by modifying its Transform Component
 but it **will not respond to collisions and forces**. \
> Kinematic rigidbodies **still can apply force and push other rigidbody colliders**, but cannot be pushed by others because  external force doesn't affect on the Kinematic rigidbodies. \
> Even both game objects have colliders and they don't pass through each others, there is **no collision detection** because **kinematic rigidbodies will never compute collisions**. 



#### kinematics used for?
- **Moving platforms**: They need to be able to collide with objects, otherwise you cannot stand on them. They cannot be affected by physical forces, or they will be knocked out of their defined paths.
- **Animated obstacles or platforms**
- **Projectiles**

https://doc.stride3d.net/4.0/en/manual/physics/kinematic-rigid-bodies.html \
https://blog.terresquall.com/2023/09/what-is-a-kinematic-rigid-body-and-how-are-they-used-in-unity/ \
https://youtube.com/shorts/_77c2KnCdq4?si=VriPT47o8Bu4n39R


### Box Collider 
https://docs.unity3d.com/Manual/class-BoxCollider.html \
https://docs.unity3d.com/Manual/class-BoxCollider2D.html

### Wheel Collider
https://docs.unity3d.com/Manual/class-WheelCollider.html

### Capsule Collider
https://docs.unity3d.com/Manual/class-CapsuleCollider.html \
https://docs.unity3d.com/Manual/class-CapsuleCollider2D.html

### Terrain Collider
https://docs.unity3d.com/Manual/class-TerrainCollider.html

### Sphere Collider
https://docs.unity3d.com/Manual/class-SphereCollider.html

### Circle Collider 2D
https://docs.unity3d.com/Manual/class-CircleCollider2D.html

### Edge Collider 2D
https://docs.unity3d.com/Manual/class-EdgeCollider2D.html

### Composite Collider 2D
https://docs.unity3d.com/Manual/class-CompositeCollider2D.html

### Custom Collider 2D
https://docs.unity3d.com/Manual/class-CustomCollider2D.html

### Physic Material
The Physic Material adjusts friction and bouncing effects of colliding GameObjectsThe fundamental object in Unity scenes, which can represent characters, props, scenery, cameras, waypoints, and more. A GameObject’s functionality is defined by the Components attached to it.

https://docs.unity3d.com/Manual/class-PhysicMaterial.html


### Multiple collider detecting which collider to hit
https://forum.unity.com/threads/detecting-which-collider-was-hit.738020/


### Trigger
A collider configured as a **Trigger** (using the **Is Trigge**r property) does not behave as a solid object and **will simply allow other colliders to pass through**. When a collider enters its space, a **trigger will call the `OnTriggerEnter` function** on the trigger object’s scripts

#### Is **trigger** or not?
If one of collider is trigger, both collider **will pass through each other** whereas **non trigger do not**.  So,  if both collider without at least one of these is trigger, they **will not pass through each other**


### ref
https://docs.unity3d.com/Manual/collider-types-introduction.html

