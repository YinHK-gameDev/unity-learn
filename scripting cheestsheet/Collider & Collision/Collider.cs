// Collider  


// property

// Is the collider a trigger?
public bool isTrigger;

// Enabled Colliders will collide with other Colliders, disabled Colliders won't.
public bool enabled;




// Method

// bool True when the ray intersects the collider, otherwise false.
public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance);

// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
Collider.OnCollisionEnter(Collision);

// OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider.
Collider.OnCollisionExit(Collision);

// OnCollisionStay is called once per frame for every collider/rigidbody that is touching rigidbody/collider.
Collider.OnCollisionStay(Collision);





