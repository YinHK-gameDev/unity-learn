## Animation State Machines



> The **Exit** node is used to indicate that a state machine should exit.

> The **Any State** is a special state which is always present. It exists for the situation where you want to go to a specific state regardless of which state you are currently in. This is a shorthand way of adding the same outward transition to all states in your machine. Note that the special meaning of Any State implies that it cannot be the end point of a transition (ie, jumping to “any state” cannot be used as a way to pick a random state to enter next).



https://docs.unity3d.com/Manual/StateMachineBasics.html


### Animation States
Animation States are the basic building blocks of an Animation State Machine
. Each state contains an animation sequence (or blend tree) that plays when the character is in that state. Select the state in the Animator Controller
, to view the properties for the state in the Inspector
 window.
 
| Property: | Description: |
| --- | --- |
| Motion | The animation clip or blend tree assigned to this state. |
| Speed | The default speed of the motion for this state. Enable Parameter to modify the speed with a custom value from a script. For example, you can multiply the speed with a custom value to decelerate or accelerate the play speed. |
| Motion Time | The time used to play the motion for this state. Enable Parameter to control the motion time with a custom value from a script. |
| Mirror | This property only applies to states with humanoid animation. Enable to mirror the animation for this state. Enable Parameter to enable or disable mirroring from a script. |
| Cycle Offset | The offset added to the state time of the motion. This offset does not affect the Motion Time. Enable Parameter to specify the Cycle Offset from a script. |
| Foot IK | This property only applies to states with humanoid animation. Enable to respect Foot IK for this state. |
| Write Defaults | Whether the AnimatorStates writes the default values for properties that are not animated by its motion. |
| Transitions | The list of transitions originating from this state. |
 


https://docs.unity3d.com/Manual/class-State.html
