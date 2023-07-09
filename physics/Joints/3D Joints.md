## 3D Joints
| Property: | Function: |
| --- | --- |
| Character Joint | Emulates a ball and socket joint, like a hip or shoulder. Constrains rigid body movement along all linear degrees of freedom, and enables all angular freedoms. Rigidbodies attached to a Character Joint orient around each axis and pivot from a shared origin. |
| Configurable Joint | Emulates any skeletal joint, like those in a ragdoll. You can configure this joint to force and restrict rigid body movement in any degree of freedom. https://medium.com/luna-labs-ltd/luna-tech-series-a-deep-dive-into-unity-configurable-joints-96c49138b9b7|
| Fixed Joint | Restricts the movement of a rigid body to follow the movement of the rigid body it is attached to. This is useful when you need rigid bodies that easily break apart from each other, or you want to connect the movement of two rigid bodies without parenting in a Transform hierarchy. |
| Hinge Joint | Attaches a rigid body to another rigid body or a point in space at a shared origin and allows the rigid bodies to rotate around a specific axis from that origin. Useful for emulating doors and finger joints. |
| Spring Joint | Keeps rigid bodies apart from each other but lets the distance between them stretch slightly. The spring acts like a piece of elastic that tries to pull the two anchor points together to the exact same position. |



### ref
https://docs.unity3d.com/Manual/Joints.html

https://www.youtube.com/watch?v=MElbAwhMvTc
