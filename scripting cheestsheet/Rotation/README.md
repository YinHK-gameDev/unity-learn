## Rotation

### Quaternion
Quaternions are used to **represent rotations**. 

Unity internally uses Quaternions to represent all rotations.

hey are based on complex numbers and are not easy to understand intuitively. 
You almost never access or modify individual **Quaternion components (x,y,z,w)**; 
most often you would just take existing rotations (e.g. from the Transform) and use them to construct new rotations (e.g. to smoothly interpolate between two rotations). 
The Quaternion functions that you use 99% of the time are: **`Quaternion.LookRotation`**, **`Quaternion.Angle**`, **`Quaternion.Euler`**, 
**`Quaternion.Slerp`**, **`Quaternion.FromToRotation`**, and **`Quaternion.identity`**.

> **Note**: Unity expects Quaternions to be normalized.


### ref
https://docs.unity3d.com/ScriptReference/Quaternion-ctor.html
