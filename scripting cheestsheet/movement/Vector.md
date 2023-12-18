### Vector3
Representation of 3D vectors and points.

This structure is used throughout Unity to pass 3D positions and directions around. It also contains functions for doing common vector operations.

```cs
// Static Properties

Vector3.back;     // Shorthand for writing Vector3(0, 0, -1)
Vector3.down;     // Shorthand for writing Vector3(0, -1, 0)
Vector3.forward;  // Shorthand for writing Vector3(0, 0, 1)
Vector3.left;     // Shorthand for writing Vector3(-1, 0, 0)
Vector3.right;    // Shorthand for writing Vector3(1, 0, 0)
Vector3.up;       // Shorthand for writing Vector3(0, 1, 0)

Vector3.zero;     // Shorthand for writing Vector3(0, 0, 0)
Vector3.one;      // Shorthand for writing Vector3(1, 1, 1)


// Properties
public Vector3 v;

v.magnitude;       // Returns the length of this vector (Read Only)
v.normalized;      // Returns this vector with a magnitude of 1 (Read Only)

Vector3.this[int];    // Access the x, y, z components using [0], [1], [2] respectively
v[0] = 5.0f;
v[1] = 5.0f;
v[2] = 5.0f;

v.X   // X component of the vector
v.Y   // Y component of the vector
v.Z   // Z component of the vector

```


https://docs.unity3d.com/ScriptReference/Vector3.html


### Vector3Int
Representation of 3D vectors and points using integers.

This structure is used in some places to represent 3D positions and vectors that don't require the precision of floating-point.

https://docs.unity3d.com/ScriptReference/Vector3Int.html









