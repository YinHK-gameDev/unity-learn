### Vector3
Representation of 3D vectors and points.

This structure is used throughout Unity to pass 3D positions and directions around. It also contains functions for doing common vector operations.

```cs

// Constructor
public Vector3(float x, float y, float z);

private Vector3 myVector = new Vector3(0.0f, 1.0f, 0.0f);


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

#### `Vector3.SmoothDamp`
Gradually changes a vector towards a desired goal over time.

The vector is smoothed by some spring-damper like function, which will never overshoot. The most common use is for smoothing a follow camera.

```cs
public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = Mathf.Infinity, float deltaTime = Time.deltaTime);
```

```cs
 transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
```

#### `Vector3.Lerp`

Linearly interpolates between two points.

Interpolates between the points `a` and `b` by the interpolant `t`. The parameter `t` is clamped to the range \[0, 1\]. This is most commonly used to find a point some fraction of the way along a line between two endpoints (e.g. to move an object gradually between those points).  
  
The value returned equals **a + (b - a) \* t** (which can also be written **a \* (1-t) + b\*t**).  
When `t` = 0, **Vector3.Lerp(a, b, t)** returns `a`.  
When `t` = 1, **Vector3.Lerp(a, b, t)** returns `b`.

```cs
public class LerpToPosition : MonoBehaviour
{
    public Vector3 positionToMoveTo;
    void Start()
    {
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
    }
    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
```


https://docs.unity3d.com/ScriptReference/Vector3.html


### Vector3Int
Representation of 3D vectors and points using integers.

This structure is used in some places to represent 3D positions and vectors that don't require the precision of floating-point.

https://docs.unity3d.com/ScriptReference/Vector3Int.html









