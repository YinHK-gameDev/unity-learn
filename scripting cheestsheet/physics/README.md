## Physics

Global physics properties and helper methods



| Static Properties | Description |
| --- | --- |
| AllLayers | Layer mask constant to select all layers. |
| autoSimulation | Sets whether the physics should be simulated automatically or not. |
| autoSyncTransforms | Whether or not to automatically sync transform changes with the physics system whenever a Transform component changes. |
| bounceThreshold | Two colliding objects with a relative velocity below this will not bounce (default 2). Must be positive. |
| clothGravity | Cloth Gravity setting. Set gravity for all cloth components. |
| defaultContactOffset | The default contact offset of the newly created colliders. |
| defaultMaxAngularSpeed | Default maximum angular speed of the dynamic Rigidbody, in radians (default 50). |
| defaultMaxDepenetrationVelocity | The maximum default velocity needed to move a Rigidbody's collider out of another collider's surface penetration. Must be positive. |
| defaultPhysicsScene | The PhysicsScene automatically created when Unity starts. |
| DefaultRaycastLayers | Layer mask constant to select default raycast layers. |
| defaultSolverIterations | The defaultSolverIterations determines how accurately Rigidbody joints and collision contacts are resolved. (default 6). Must be positive. |
| defaultSolverVelocityIterations | The defaultSolverVelocityIterations affects how accurately the Rigidbody joints and collision contacts are resolved. (default 1). Must be positive. |
| gravity | The gravity applied to all rigid bodies in the Scene. |
| IgnoreRaycastLayer | Layer mask constant to select ignore raycast layer. |
| interCollisionDistance | Sets the minimum separation distance for cloth inter-collision. |
| interCollisionStiffness | Sets the cloth inter-collision stiffness. |
| queriesHitBackfaces | Whether physics queries should hit back-face triangles. |
| queriesHitTriggers | Specifies whether queries (raycasts, spherecasts, overlap tests, etc.) hit Triggers by default. |
| reuseCollisionCallbacks | Determines whether the garbage collector should reuse only a single instance of a Collision type for all collision callbacks. |
| sleepThreshold | The mass-normalized energy threshold, below which objects start going to sleep. |


| Static Methods | Description |
| --- | --- |
| BakeMesh | Prepares the Mesh for use with a MeshCollider. |
| BoxCast | Casts the box along a ray and returns detailed information on what was hit. |
| BoxCastAll | Like Physics.BoxCast, but returns all hits. |
| BoxCastNonAlloc | Cast the box along the direction, and store hits in the provided buffer. |
| CapsuleCast | Casts a capsule against all colliders in the Scene and returns detailed information on what was hit. |
| CapsuleCastAll | Like Physics.CapsuleCast, but this function will return all hits the capsule sweep intersects. |
| CapsuleCastNonAlloc | Casts a capsule against all colliders in the Scene and returns detailed information on what was hit into the buffer. |
| CheckBox | Check whether the given box overlaps with other colliders or not. |
| CheckCapsule | Checks if any colliders overlap a capsule-shaped volume in world space. |
| CheckSphere | Returns true if there are any colliders overlapping the sphere defined by position and radius in world coordinates. |
| ClosestPoint | Returns a point on the given collider that is closest to the specified location. |
| ComputePenetration | Compute the minimal translation required to separate the given colliders apart at specified poses. |
| GetIgnoreCollision | Checks whether the collision detection system will ignore all collisions/triggers between collider1 and collider2 or not. |
| GetIgnoreLayerCollision | Are collisions between layer1 and layer2 being ignored? |
| IgnoreCollision | Makes the collision detection system ignore all collisions between collider1 and collider2. |
| IgnoreLayerCollision | Makes the collision detection system ignore all collisions between any collider in layer1 and any collider in layer2.Note that IgnoreLayerCollision will reset the trigger state of affected colliders, so you might receive OnTriggerExit and OnTriggerEnter messages in response to calling this. |
| Linecast | Returns true if there is any collider intersecting the line between start and end. |
| OverlapBox | Find all colliders touching or inside of the given box. |
| OverlapBoxNonAlloc | Find all colliders touching or inside of the given box, and store them into the buffer. |
| OverlapCapsule | Check the given capsule against the physics world and return all overlapping colliders. |
| OverlapCapsuleNonAlloc | Check the given capsule against the physics world and return all overlapping colliders in the user-provided buffer. |
| OverlapSphere | Computes and stores colliders touching or inside the sphere. |
| OverlapSphereNonAlloc | Computes and stores colliders touching or inside the sphere into the provided buffer. |
| Raycast | Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene. |
| RaycastAll | Casts a ray through the Scene and returns all hits. Note that order of the results is undefined. |
| RaycastNonAlloc | Cast a ray through the Scene and store the hits into the buffer. |
| RebuildBroadphaseRegions | Rebuild the broadphase interest regions as well as set the world boundaries. |
| Simulate | Simulate physics in the Scene. |
| SphereCast | Casts a sphere along a ray and returns detailed information on what was hit. |
| SphereCastAll | Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects. |
| SphereCastNonAlloc | Cast sphere along the direction and store the results into buffer. |
| SyncTransforms | Apply Transform changes to the physics engine. |

### `Physics.OverlapCapsule`
Check the given capsule against the physics world and return all overlapping colliders.

```cs
public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask = AllLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```


| Parameters | Descriptions |
| --- | --- |
| point0 | The center of the sphere at the start of the capsule. |
| point1 | The center of the sphere at the end of the capsule. |
| radius | The radius of the capsule. |
| layerMask | A Layer mask that is used to selectively ignore colliders when casting a capsule. |
| queryTriggerInteraction | Specifies whether this query should hit Triggers. |


### `Physics.OverlapBox`
Find all colliders touching or inside of the given box.
```cs
public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation = Quaternion.identity, int layerMask = AllLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```

| Parameters | Descriptions |
| --- | --- |
| center | Center of the box. |
| halfExtents | Half of the size of the box in each dimension. |
| orientation | Rotation of the box. |
| layerMask | A Layer mask that is used to selectively ignore colliders when casting a ray. |
| queryTriggerInteraction | Specifies whether this query should hit Triggers. |


### `Physics.OverlapSphere`

Computes and stores colliders touching or inside the sphere. Returns an array with all colliders touching or inside the sphere.


```cs
public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask = AllLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```

| Parameters | Descriptions |
| --- | --- |
| position | Center of the sphere. |
| radius | Radius of the sphere. |
| layerMask | A Layer mask defines which layers of colliders to include in the query. |
| queryTriggerInteraction | Specifies whether this query should hit Triggers. |



### ref 
**Physics scripting API** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Physics.html

**Physics2D scripting API** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Physics2D.html


**`Physics.OverlapCapsule`** \
https://docs.unity3d.com/ScriptReference/Physics.OverlapCapsule.html

**`Physics.OverlapBox`** \
https://docs.unity3d.com/ScriptReference/Physics.OverlapBox.html

**`Physics.OverlapSphere`** \
https://github.com/YinHK-gameDev/unity-learn/edit/2021.3.0(LTS)/scripting%20cheestsheet/check%20grounded.md


**PhysicsMaterial2D scripting API** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/PhysicsMaterial2D.html

**PhysicsScene** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/PhysicsScene.html

**PhysicsScene2D** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/PhysicsScene2D.html


