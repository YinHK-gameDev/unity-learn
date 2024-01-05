// Collider  
// A base class of all colliders, eg:  BoxCollider, SphereCollider, CapsuleCollider, MeshCollider


// property

// Is the collider a trigger?
public bool isTrigger;

// Enabled Colliders will collide with other Colliders, disabled Colliders won't.
public bool enabled;

//The world space bounding volume of the collider (Read Only)
public Bounds bounds;

//Eg:
m_Collider = GetComponent<Collider>();  //Fetch the Collider from the GameObject
m_Center = m_Collider.bounds.center;    //Fetch the center of the Collider volume
m_Size = m_Collider.bounds.size;        //Fetch the size of the Collider volume
m_Min = m_Collider.bounds.min;          //Fetch the minimum bounds of the Collider volume
m_Max = m_Collider.bounds.max;          ////Fetch the maximum bounds of the Collider volume


// Method

// bool True when the ray intersects the collider, otherwise false.
public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance);

// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
Collider.OnCollisionEnter(Collision);
void OnCollisionEnter(Collision collision);

// OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider.
Collider.OnCollisionExit(Collision);
void OnCollisionExit(Collision collision);

// OnCollisionStay is called once per frame for every collider/rigidbody that is touching rigidbody/collider.
Collider.OnCollisionStay(Collision);
void OnCollisionStay(Collision collision);

// OnTriggerEnter happens on the FixedUpdate function when two GameObjects collide.
Collider.OnTriggerEnter(Collider);
void OnTriggerEnter(Collider other);

// OnTriggerExit is called when the Collider other has stopped touching the trigger.
Collider.OnTriggerExit(Collider);
void OnTriggerExit(Collider other);

// OnTriggerStay is called almost all the frames for every Collider other that is touching the trigge
Collider.OnTriggerStay(Collider);
void OnTriggerStay(Collider other);

