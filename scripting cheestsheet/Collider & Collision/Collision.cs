// Collsion class
// Describes a collision.
// Collision information is passed to Collider.OnCollisionEnter, Collider.OnCollisionStay and Collider.OnCollisionExit events.


// Properties

// The Rigidbody or ArticulationBody of the collider that your Component collides with (Read Only).
public ArticulationBody articulationBody;
public Component body;

// The Collider we hit (Read Only)
public Collider collider;

// Gets the number of contacts for this collision
public int contactCount;

// The GameObject whose collider you are colliding with(Read Only)
public GameObject gameObject;

// The relative linear velocity of the two colliding objects
public Vector3 relativeVelocity;

// The Rigidbody we hit (Read Only). This is null if the object we hit is a collider with no rigidbody attached.
public Rigidbody rigidbody;

// The Transform of the object we hit (Read Only).
public Transform transform;


// Methods

// Gets the contact point at the specified index.
public ContactPoint GetContact(int index);

// Retrieves all contact points for this collision.
// When retrieving contacts, you should ensure that the provided array is large enough to contain all the contacts you are interested in. 
// The array is usually reused, so it should be large enough to return a reasonable quantity of contacts. This function also means that no allocations occur, 
// which means no work is produced for the garbage collector.
public int GetContacts(ContactPoint[] contacts);
