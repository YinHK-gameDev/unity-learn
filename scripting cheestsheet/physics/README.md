## Physics

Global physics properties and helper methods


### `Physics.OverlapCapsule`
heck the given capsule against the physics world and return all overlapping colliders.

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

**`Physics.OverlapSphere**` \
https://github.com/YinHK-gameDev/unity-learn/edit/2021.3.0(LTS)/scripting%20cheestsheet/check%20grounded.md


**PhysicsMaterial2D scripting API** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/PhysicsMaterial2D.html

**PhysicsScene** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/PhysicsScene.html

**PhysicsScene2D** \
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/PhysicsScene2D.html


