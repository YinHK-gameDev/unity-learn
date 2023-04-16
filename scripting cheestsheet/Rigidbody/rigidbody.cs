// Useful Rigidbody properties or Methods


// Property

// The position of the rigidbody.
public Vector3 position;

// The rotation of the Rigidbody.
public Quaternion rotation;

// The velocity vector of the rigidbody. It represents the rate of change of Rigidbody position.
public Vector3 velocity;


// Method

// Adds a force to the Rigidbody
public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force);

// Adds a torque to the rigidbody
public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force);


