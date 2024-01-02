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




### ref
https://docs.unity3d.com/ScriptReference/Quaternion-ctor.html
