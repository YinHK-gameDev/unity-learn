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

v.X;   // X component of the vector
v.Y;   // Y component of the vector
v.Z;   // Z component of the vector

v.magnitude;     //Returns the length of this vector (Read Only).
v.normalized;    //Returns this vector with a magnitude of 1 (Read Only).
v.sqrMagnitude;  //Returns the squared length of this vector (Read Only).
```

#### `Vector3.SmoothDamp`
**Gradually changes a vector towards a desired goal over time**.

The vector is smoothed by some spring-damper like function, which will never overshoot. The most common use is for smoothing a follow camera.

```cs
public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = Mathf.Infinity, float deltaTime = Time.deltaTime);
```

```cs
 transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
```

| Parameters | Descriptions |
| --- | --- |
| `current` | The current position. |
| `target` | The position we are trying to reach. |
| `currentVelocity` | The current velocity, this value is modified by the function every time you call it. |
| `smoothTime` | Approximately the time it will take to reach the target. A smaller value will reach the target faster. |
| `maxSpeed` | Optionally allows you to clamp the maximum speed. |
| `deltaTime` | The time since the last call to this function. By default `Time.deltaTime`. |

https://docs.unity3d.com/ScriptReference/Vector3.SmoothDamp.html

#### `Vector3.Lerp`

**Linearly interpolates between two points**.

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

https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html

### Static Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-back.html">back</a></td><td class="desc">Shorthand for writing Vector3(0, 0, -1).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-down.html">down</a></td><td class="desc">Shorthand for writing Vector3(0, -1, 0).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-forward.html">forward</a></td><td class="desc">Shorthand for writing Vector3(0, 0, 1).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-left.html">left</a></td><td class="desc">Shorthand for writing Vector3(-1, 0, 0).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-negativeInfinity.html">negativeInfinity</a></td><td class="desc">Shorthand for writing Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-one.html">one</a></td><td class="desc">Shorthand for writing Vector3(1, 1, 1).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-positiveInfinity.html">positiveInfinity</a></td><td class="desc">Shorthand for writing Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-right.html">right</a></td><td class="desc">Shorthand for writing Vector3(1, 0, 0).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-up.html">up</a></td><td class="desc">Shorthand for writing Vector3(0, 1, 0).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-zero.html">zero</a></td><td class="desc">Shorthand for writing Vector3(0, 0, 0).</td></tr></tbody></table>

### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-magnitude.html">magnitude</a></td><td class="desc">Returns the length of this vector (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-normalized.html">normalized</a></td><td class="desc">Returns this vector with a magnitude of 1 (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-sqrMagnitude.html">sqrMagnitude</a></td><td class="desc">Returns the squared length of this vector (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Index_operator.html">this[int]</a></td><td class="desc">Access the x, y, z components using [0], [1], [2] respectively.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-x.html">x</a></td><td class="desc">X component of the vector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-y.html">y</a></td><td class="desc">Y component of the vector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-z.html">z</a></td><td class="desc">Z component of the vector.</td></tr></tbody></table>

### Constructors

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3-ctor.html">Vector3</a></td><td class="desc">Creates a new vector with given x, y, z components.</td></tr></tbody></table>

### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Equals.html">Equals</a></td><td class="desc">Returns true if the given vector is exactly equal to this vector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Set.html">Set</a></td><td class="desc">Set x, y and z components of an existing Vector3.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.ToString.html">ToString</a></td><td class="desc">Returns a formatted string for this vector.</td></tr></tbody></table>

### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Angle.html">Angle</a></td><td class="desc">Calculates the angle between vectors from and.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.ClampMagnitude.html">ClampMagnitude</a></td><td class="desc">Returns a copy of vector with its magnitude clamped to maxLength.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Cross.html">Cross</a></td><td class="desc">Cross Product of two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Distance.html">Distance</a></td><td class="desc">Returns the distance between a and b.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Dot.html">Dot</a></td><td class="desc">Dot Product of two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Lerp.html">Lerp</a></td><td class="desc">Linearly interpolates between two points.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.LerpUnclamped.html">LerpUnclamped</a></td><td class="desc">Linearly interpolates between two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Max.html">Max</a></td><td class="desc">Returns a vector that is made from the largest components of two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Min.html">Min</a></td><td class="desc">Returns a vector that is made from the smallest components of two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.MoveTowards.html">MoveTowards</a></td><td class="desc">Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Normalize.html">Normalize</a></td><td class="desc">Makes this vector have a magnitude of 1.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.OrthoNormalize.html">OrthoNormalize</a></td><td class="desc">Makes vectors normalized and orthogonal to each other.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Project.html">Project</a></td><td class="desc">Projects a vector onto another vector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.ProjectOnPlane.html">ProjectOnPlane</a></td><td class="desc">Projects a vector onto a plane defined by a normal orthogonal to the plane.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Reflect.html">Reflect</a></td><td class="desc">Reflects a vector off the plane defined by a normal.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.RotateTowards.html">RotateTowards</a></td><td class="desc">Rotates a vector current towards target.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Scale.html">Scale</a></td><td class="desc">Multiplies two vectors component-wise.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.SignedAngle.html">SignedAngle</a></td><td class="desc">Calculates the signed angle between vectors from and to in relation to axis.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.Slerp.html">Slerp</a></td><td class="desc">Spherically interpolates between two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.SlerpUnclamped.html">SlerpUnclamped</a></td><td class="desc">Spherically interpolates between two vectors.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Vector3.htmlVector3.SmoothDamp.html">SmoothDamp</a></td><td class="desc">Gradually changes a vector towards a desired goal over time.</td></tr></tbody></table>


### Vector3Int
Representation of 3D vectors and points using integers.

This structure is used in some places to represent 3D positions and vectors that don't require the precision of floating-point.

https://docs.unity3d.com/ScriptReference/Vector3Int.html



### ref 

https://docs.unity3d.com/ScriptReference/Vector3.html





