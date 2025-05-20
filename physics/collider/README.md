## collider

A collider is invisible, and does not need to be the exact same shape as the GameObject’s mesh. A rough approximation of the mesh is often more efficient and indistinguishable in gameplay.

The simplest (and least processor-intensive) colliders are primitive collider types. In 3D, these are the **Box Collider**, **Sphere Collider** and **Capsule Collider**. In 2D, you can use the **Box Collider 2D** and **Circle Collider 2D**. **You can add any number of these to a single GameObject to create compound colliders**.


### Mesh colliders
In 3D, you can use Mesh Colliders to **match the shape of the GameObject’s mesh exactly**.

The precision of a Mesh collider comes with a **higher processing overhead than primitive colliders** (such as the **Sphere**, **Box**, and **Capsule colliders**). For this reason, it is best practice to **only use Mesh colliders for colliders that do not otherwise require a high amount of processing power**, or for collisions where primitive colliders or a compound collider would have a greater overhead. A good approach is to use Mesh colliders for static scene geometry, and compound colliders for moving GameObjects.

https://docs.unity3d.com/Manual/class-MeshCollider.html \
https://docs.unity3d.com/2023.3/Documentation/Manual/mesh-colliders-introduction.html

### Polygon Collider 2D
The Collider’s shape is defined by a freeform edge made of line segments, that you can adjust to fit the shape of the Sprite or any other shape. 
 > **Note: that this Collider’s edge must completely enclose an area to function.**

https://docs.unity3d.com/Manual/class-PolygonCollider2D.html

### Static colliders
You can add colliders to a GameObject without a Rigidbody component to create floors, walls and other motionless elements of a Scene. These are referred to as **static colliders**.

Static colliders can interact with dynamic colliders but since they don’t have a Rigidbody, they don’t move in response to collisions.

A Static collider is a collider that has **no associated Rigidbody** or **ArticulationBody** (that is, there is **no Rigidbody or ArticulationBody on the associated GameObject**), and therefore **doesn’t respond to simulated physics forces**. Other colliders **can collide with Static colliders**, but **Static colliders don’t move in response to collisions**.

The only way to move a static collider at run time is via the Transform. However, in most cases you should not do this. The physics system cannot immediately take Transform-led movement into consideration while calculating physics updates, and you might see unintended side-effects if you move a static collider via the Transform. Instead, you should only use Static colliders for collider geometry that does not move at run time.

> A static collider is a GameObject that has a Collider but **no Rigidbody**. For motionless gameobject(**死物**), its collider is static collider(**no rigid body**)

### Dynamic colliders
Colliders on a GameObject that has a **Rigidbody** are known as **dynamic colliders**. \
Dynamic colliders: The GameObject’s physics body is dynamic (that is, it has **`IsKinematic` disabled**).

> **Note**: with **Rigidbody** component & disable **`IsKinematic`** field.

### Physics body colliders
A physics body collider is a collider on the same GameObject as a physics body (a **Rigidbody** or an **ArticulationBody**). Physics body colliders are included in **physics calculations**, but behave differently depending on whether they are **dynamic** or **kinematic** (that is, whether **Is Kinematic is disabled or enabled**).

> **Note**: A Rigidbody can be either **dynamic** or **kinematic**. An **ArticulationBody** can **only be dynamic**; it **cannot be kinematic**.

> **Note**: Physics body colliders are **dynamic** by **default**.

### Rigidbody colliders
This is a GameObject with a Collider and a normal, **non-kinematic Rigidbody attached**. Rigidbody colliders are fully simulated by the physics engine and can react to collisions and forces

> Adding a **Rigidbody component** to an object will **put its motion under the control of Unity's physics engine**. 

Even without adding any code, a Rigidbody object will be **pulled downward by gravity** and will react to collisions with incoming objects if the right Collider component is also present.

> Known as **dynamic coliider**

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
> Kinematic rigidbodies **still can apply force and push other rigidbody colliders**, but **cannot be pushed by others** because  **external force doesn't affect on the Kinematic rigidbodies**. \
> Even both game objects have colliders and they don't pass through each others, there is **no collision detection** because **kinematic rigidbodies will never compute collisions**. 



#### kinematics used for?
- **Moving platforms**: They need to be able to collide with objects, otherwise you cannot stand on them. They cannot be affected by physical forces, or they will be knocked out of their defined paths.
- **Animated obstacles or platforms**
- **Projectiles**

https://doc.stride3d.net/4.0/en/manual/physics/kinematic-rigid-bodies.html \
https://blog.terresquall.com/2023/09/what-is-a-kinematic-rigid-body-and-how-are-they-used-in-unity/ \
https://youtube.com/shorts/_77c2KnCdq4?si=VriPT47o8Bu4n39R

### Primitive collider shapes
There are three primitive collider shapes in Unity:
- **Box collider**: rectangular box-shaped collider that is suitable for most rectangular objects.
- **Sphere collider**: A spherical collider that is suitable for most circular objects.
- **Capsule collider**: A cylindrical collider that is suitable for objects that have a cylindrical shape, or for rounding out the collision edges on sharp corners. Capsule colliders are also useful for player and non-player characters.

### Box Collider 
https://docs.unity3d.com/Manual/class-BoxCollider.html \
https://docs.unity3d.com/Manual/class-BoxCollider2D.html

### Wheel Collider
https://docs.unity3d.com/Manual/class-WheelCollider.html \
https://www.youtube.com/watch?v=c-yhZwXSx_c

### Capsule Collider
https://docs.unity3d.com/Manual/class-CapsuleCollider.html \
https://docs.unity3d.com/Manual/class-CapsuleCollider2D.html

### Terrain Collider
https://docs.unity3d.com/Manual/class-TerrainCollider.html

### Sphere Collider
https://docs.unity3d.com/Manual/class-SphereCollider.html

### compound colliders
A compound collider is a **collection of colliders** on the **same Rigidbody GameObject**. \
Compound colliders collectively behave like a **single Rigidbody collider**. They are useful when you need an **accurate collider for a concave shape**, or if you have a model that would be **too computationally demanding** to simulate with a **Mesh collider**.

> A compound collider is made up of a **parent GameObject which has a Rigidbody component**, and **child GameObjects that have colliders**.

#### Construction of a compound collider

A compound collider is made of the following elements:

-   A **parent GameObject** that has a **Rigidbody**
-   **Empty child GameObjects** that **contain colliders**

A compound collider should **only have one Rigidbody**, which should be on the **root GameObject**.

This configuration offers more flexibility than a single GameObject that contains a Rigidbody and several colliders. When each collider is on a different GameObject, you can modify the Transform of each collider individually. However, you should monitor the Rigidbody’s behavior when you reposition colliders. Changes to collider position and scale can change the **Rigidbody’s center of mass**, which can result in some unexpected behavior if continuous change is made over several frames at runtime. If this happens, you can use **`rigidbody.centerOfMass`** to manually set the **center of mass**.

> When you attach several colliders to the **same Rigidbody**, the p**hysics system treats the whole collection as a single Rigidbody collider**. The collider type (**dynamic or kinematic**) is defined by the **Rigidbody configuration**.

> When a compound collider touches another collider, Unity registers collisions per each individual collider in the compound. For this reason, you should try to **arrange your colliders so that you only get the collision pairs you want at runtime**, or use collider labels to determine behaviors caused by specific colliders.

### Circle Collider 2D
https://docs.unity3d.com/Manual/class-CircleCollider2D.html

### Edge Collider 2D
https://docs.unity3d.com/Manual/class-EdgeCollider2D.html

### Composite Collider 2D
https://docs.unity3d.com/Manual/class-CompositeCollider2D.html

### Custom Collider 2D
https://docs.unity3d.com/Manual/class-CustomCollider2D.html

### Physic Material
The Physic Material adjusts **friction** and **bouncing effects** of colliding GameObjectsThe fundamental object in Unity scenes, which can represent characters, props, scenery, cameras, waypoints, and more. A GameObject’s functionality is defined by the Components attached to it.

https://docs.unity3d.com/Manual/class-PhysicMaterial.html


### Multiple collider detecting which collider to hit
https://forum.unity.com/threads/detecting-which-collider-was-hit.738020/


### `Collider.enabled` vs `SetActive`
Does `Collider.enabled` same as `SetActive`?? \

**NO**, `Collider.enabled` is not the same as disabling the entire component with SetActive.

- To disables the collider functionality: it will no longer participate in collisions or trigger detection.
- The GameObject and the component still exist and are active.
- Useful when you want to turn off just the physics interaction, but still render or use other scripts.

### Trigger
A collider configured as a **Trigger** (using the **Is Trigge**r property) does not behave as a solid object and **will simply allow other colliders to pass through**. When a collider enters its space, a **trigger will call the `OnTriggerEnter` function** on the trigger object’s scripts

#### Is **trigger** or not?
If one of collider is trigger, both collider **will pass through each other** whereas **non trigger do not**.  So,  if both collider without at least one of these is trigger, they **will not pass through each other**


### ref
https://docs.unity3d.com/Manual/collider-types-introduction.html

