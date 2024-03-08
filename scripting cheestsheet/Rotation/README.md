## Rotation

### Quaternion
Quaternions are used to **represent rotations**. 

Unity internally uses Quaternions to represent all rotations.

hey are based on complex numbers and are not easy to understand intuitively. 
You almost never access or modify individual **Quaternion components (x,y,z,w)**; 
most often you would just take existing rotations (e.g. from the Transform) and use them to construct new rotations (e.g. to smoothly interpolate between two rotations). 
The Quaternion functions that you use 99% of the time are: **`Quaternion.LookRotation`**, **`Quaternion.Angle`**, **`Quaternion.Euler`**, 
**`Quaternion.Slerp`**, **`Quaternion.FromToRotation`**, and **`Quaternion.identity`**.

> **Note**: Unity expects Quaternions to be normalized.

#### Constructor
```cs
public Quaternion(float x, float y, float z, float w);
```

#### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion-eulerAngles.html">eulerAngles</a></td><td class="desc">Returns or sets the euler angle representation of the rotation.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion-normalized.html">normalized</a></td><td class="desc">Returns this quaternion with a magnitude of 1 (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion.Index_operator.html">this[int]</a></td><td class="desc">Access the x, y, z, w components using [0], [1], [2], [3] respectively.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion-w.html">w</a></td><td class="desc">W component of the Quaternion. Do not directly modify quaternions.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion-x.html">x</a></td><td class="desc">X component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion-y.html">y</a></td><td class="desc">Y component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Quaternion.htmlQuaternion-z.html">z</a></td><td class="desc">Z component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</td></tr></tbody></table>

#### `Quaternion.Euler`
Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis; applied in that order.
```cs
public static Quaternion Euler(float x, float y, float z);
```

#### `Quaternion.LookRotation`
Creates a rotation with the specified `forward` and `upwards` directions.

Z axis will be aligned with `forward`, X axis aligned with c

```cs
public static Quaternion LookRotation(Vector3 forward, Vector3 upwards = Vector3.up);
```

forward	The direction to look in. \
upwards	The vector that defines in which direction up is.


#### `Quaternion.Angle`

Returns the angle in degrees between two rotations a and b.
```cs
public static float Angle(Quaternion a, Quaternion b);
```
Example: Think of two GameObjects (A and B) moving around a third GameObject (C). Lines from C to A and C to B create a triangle which can change over time. The angle between CA and CB is the value **`Quaternion.Angle`** provides.

```cs
using UnityEngine;
using System.Collections;

// Calculates the angle (degrees) between
// the rotation of this transform and target.

public class ExampleClass : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        float angle = Quaternion.Angle(transform.rotation, target.rotation);
    }
}
```

#### `Quaternion.Slerp`

Quaternion A quaternion spherically interpolated between quaternions a and b.
```cs
public static Quaternion Slerp(Quaternion a, Quaternion b, float t);
```
Spherically interpolates between quaternions a and b by ratio t. The parameter t is clamped to the range [0, 1].


- a : Start value, returned when t = 0. 
- b : End value, returned when t = 1. 
- t : Interpolation ratio.

```cs
// Interpolates rotation between the rotations "from" and "to"
// (Choose from and to not to be the same as
// the object you attach this script to)

using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform from;
    public Transform to;

    private float timeCount = 0.0f;

    void Update()
    {
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;
    }
}
```


#### `Quaternion.FromToRotation`

Creates a rotation which rotates from `fromDirection` to `toDirection`.

Usually you use this to rotate a transform so that one of its axes eg. the y-axis - follows a target direction `toDirection` in world space.



```cs
public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection);
```

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Sets the rotation so that the transform's y-axis goes along the z-axis
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
    }
}
```

#### `Quaternion.identity`

The identity rotation (Read Only).
```cs
public static Quaternion identity;
```

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        transform.rotation = Quaternion.identity;
    }
}
```

### Quaternions vs Euler Angles


https://www.youtube.com/watch?v=sJcVJEOwLUs

### ref
https://docs.unity3d.com/ScriptReference/Quaternion-ctor.html



