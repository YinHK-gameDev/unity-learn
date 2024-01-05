// Physics 


// Property

// The gravity applied to all rigid bodies in the Scene
public static Vector3 gravity;

// Sets whether the physics should be simulated automatically or not
public static bool autoSimulation;


// Method

// Casts the box along a ray and returns detailed information on what was hit.
// bool True, if any intersections were found.
public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation = Quaternion.identity, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
Parameters

// Returns true if there is any collider intersecting the line between start and end.
public static bool Linecast(Vector3 start, Vector3 end, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);

// Casts a capsule against all colliders in the Scene and returns detailed information on what was hit.
public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);

// Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene.
public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);

// Casts a ray through the Scene and returns all hits. Note that order of the results is undefined.
public static RaycastHit[] RaycastAll(Ray ray, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);

// Makes the collision detection system ignore all collisions between collider1 and collider2.
public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore = true);


// Makes the collision detection system ignore all collisions between any collider in layer1 and any collider in layer2.
public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore = true);

