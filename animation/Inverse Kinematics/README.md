## Inverse Kinematics

In computer animation and robotics, inverse kinematics is the mathematical process of calculating the variable joint parameters needed to place the end of a kinematic chain, such as a robot manipulator or animation character's skeleton, in a given position and orientation relative to the start of the chain.

Given joint parameters, the position and orientation of the chain's end, e.g. the hand of the character or robot, can typically be calculated directly using multiple applications of trigonometric formulas, a process known as forward kinematics.

Most character animation is created by rotating the angles of joints in a skeleton to predetermined values. The position of a child joint
changes according to the rotation of its parent. The end point of a chain of joints is determined by the angles and relative positions of the individual joints along the chain. This method of posing a skeleton is known as **forward kinematics**.

However, it is often useful to pose joints from the opposite point of view. Start from a chosen position in space, or a goal, and work backwards to find a way to orient the joints so that the end point reaches the goal. This can be useful if you want a character to grab an object or stand on an uneven surface. This approach is known as inverse kinematics (IK). It is supported in Mecanim for a humanoid character with a correctly configured Avatar.



To set up IK for a character, you typically have objects around the scene
 that a character interacts with. You can use these objects and your character to set up IK within a script. You can use the following Animator functions: * SetIKPositionWeight * SetIKRotationWeight * SetIKPosition * SetIKRotation * SetLookAtPosition * bodyPosition * bodyRotation


 Create a valid Avatar for your character.
Create an Animator Controller
 with at least one animation for this character.
In the Layers pane of the Animator window
, click the Cog icon in the Base Layer and enable IK Pass from the context menu. When enabled, IK Pass sends an OnAnimatorIK callback. In a later step, you will use this callback to implement inverse kinematics in a script.




### ref 
https://docs.unity3d.com/Manual/InverseKinematics.html \
https://en.wikipedia.org/wiki/Inverse_kinematics
