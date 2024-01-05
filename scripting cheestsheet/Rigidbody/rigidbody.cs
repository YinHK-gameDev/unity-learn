// Useful Rigidbody properties or Methods


// Property

// Controls whether physics affects the rigidbody.
public bool isKinematic;

// The position of the rigidbody.
public Vector3 position;

// The rotation of the Rigidbody.
public Quaternion rotation;

// The velocity vector of the rigidbody. It represents the rate of change of Rigidbody position.
public Vector3 velocity;

// Should collision detection be enabled? (By default always enabled).
// Disabling collision detections is useful when you have a ragdoll which is setup to be kinematic and you want to avoid heavy collision detection calculations 
// on that rigidbody. detectCollisions is not serialized. 
public bool detectCollisions;

// The mass of the rigidbody.
public float mass;

// Controls whether gravity affects this rigidbody.
public bool useGravity;

// Method

// Adds a force to the Rigidbody
public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force);

// Adds a torque to the rigidbody
public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force);

// Moves the kinematic Rigidbody towards position. Rigidbody.MovePosition moves a Rigidbody and complies with the interpolation settings. 
public void MovePosition(Vector3 position);

// Rotates the rigidbody to rotation. Use Rigidbody.MoveRotation to rotate a Rigidbody, complying with the Rigidbody's interpolation setting.
public void MoveRotation(Quaternion rot);

// Forces a rigidbody to sleep at least one frame.
// A common use is to call this from Awake in order to make a rigidbody sleep at startup.
public void Sleep();

// Is the rigidbody sleeping?
public bool IsSleeping();

// Forces a rigidbody to wake up
public void WakeUp();

// The velocity of the rigidbody at the point worldPoint in global space. GetPointVelocity will take the angularVelocity of the rigidbody into account when calculating the velocity.
public Vector3 GetPointVelocity(Vector3 worldPoint);

// The velocity relative to the rigidbody at the point relativePoint.
public Vector3 GetRelativePointVelocity(Vector3 relativePoint);





