### Rotation and orientation

In Unity, you can use both **Euler angles** and **quaternions** to represent rotations and orientation. These representations are equivalent but have different uses and limitations.

Typically, you rotate objects in your scene using the Transform component, which displays orientation as a Euler angle. However, Unity stores rotations and orientations internally as quaternions, which can be useful for more complex motions that might otherwise lead to gimbal lock.


### Euler angles
In the Transform coordinate, Unity displays rotation with the vector property Transform.eulerAngles X, Y, and Z. Unlike a normal vector, these values actually represent the angle (in degrees) of rotation about the X, Y, and Z axes.

Euler angle rotations perform three separate rotations around the three axes. Unity performs the Euler rotations sequentially around the z-axis, the x-axis and then the y-axis. This method of rotation is extrinsic rotation; the original coordinate system doesn’t change while the rotations occur.

To rotate a GameObject
, you can enter angle values of how far you want each axis to rotate into the Transform component. To rotate your GameObjects with script, use Transform.eulerAngles. If you convert to Euler angles to do calculations and rotations, you risk problems with gimbal lock.


### Quaternions
**Quaternions** provide mathematical notation for unique representations of spatial orientation and rotation in 3D space. A quaternion uses four numbers to encode the direction and angle of rotation around unit axes in 3D. These four values are complex numbers rather than angles or degrees.

Unity converts rotational values to quaternions to store them because quaternion rotations are efficient and stable to compute. The Editor doesn’t display rotations as quaternions because a single quaternion can’t represent a rotation greater than 360 degrees about any axis.

You can use quaternions directly if you use the Quaternion class. If you use script for your rotations, you can use the Quaternion class and functions to create and change rotational values. You can apply values to your rotation as Euler angles but you need to store them as quaternions to avoid problems.

### Convert between Euler angles and quaternions

- To convert from **Euler angles** to **quaternions**, you can use the **`Quaternion.Euler`** function.
- To convert a **quaternion** to **Euler angles**, you can use the **`Quaternion.eulerAngles`** function.


