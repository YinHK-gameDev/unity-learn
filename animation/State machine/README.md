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


### Animation transitions

Animation transitions allow the state machine
 to switch or blend from one animation state to another. Transitions define not only how long the blend between states should take, but also under what conditions they should activate. You can set up a transition to occur only when certain conditions are true. To set up these conditions, specify values of parameters in the Animator Controller.
 
 

### Transition properties
To view properties for a transition, click on the transition line connecting two states in the Animator window. The properties appear in the Inspector window.

| Property | Function |
| --- | --- |
| Has Exit Time | Exit Time is a special transition that doesn’t rely on a parameter. Instead, it relies on the normalized time of the state. Check to make the transition happen at the specific time specified in Exit Time. |
| Settings | Fold-out menu containing detailed transition settings as below. |
| Exit Time | If Has Exit Time is checked, this value represents the exact time at which the transition can take effect. This is represented in normalized time (for example, an exit time of 0.75 means that on the first frame where 75% of the animation has played, the Exit Time condition is true). On the next frame, the condition is false.For looped animations, transitions with exit times smaller than 1 are evaluated every loop, so you can use this to time your transition with the proper timing in the animation every loop.Transitions with an Exit Time greater than 1 are evaluated only once, so they can be used to exit at a specific time after a fixed number of loops. For example, a transition with an exit time of 3.5 are evaluated once, after three and a half loops. |
| Fixed Duration | If the Fixed Duration box is checked, the transition time is interpreted in seconds. If the Fixed Duration box is not checked, the transition time is interpreted as a fraction of the normalized time of the source state. |
| Transition Duration | The duration of the transition, in normalized time or seconds depending on the Fixed Duration mode, relative to the current state’s duration. This is visualized in the transition graph as the portion between the two blue markers. |
| Transition Offset | The offset of the time to begin playing in the destination state which is transitioned to. For example, a value of 0.5 means the target state begins playing at 50% of the way through its own timeline. |
| Interruption Source | Use this to control the circumstances under which this transition may be interrupted (see Transition interruption below). |
| Ordered Interruption | Determines whether the current transition can be interrupted by other transitions independently of their order (see Transition interruption below). |
| Conditions | A transition can have a single condition, multiple conditions, or no conditions at all. If your transition has no conditions, the Unity Editor only considers the Exit Time, and the transition occurs when the exit time is reached. If your transition has one or more conditions, the conditions must all be met before the transition is triggered.A condition consists of:- An event parameter (the value considered in the condition).- A conditional predicate (if needed,for example, ‘less than’ or ‘greater than’ for floats).- A parameter value (if needed).If you have Has Exit Time selected for the transition and have one or more conditions, note that the Unity Editor considers whether the conditions are true after the Exit Time. This allows you to ensure that your transition occurs during a certain portion of the animation. |


### Transition interruption
Use the Interruption Source and Ordered Interruption properties to control how your transition can be interrupted.

**Interruption Source property** \
The transitions in AnyState are always added first in the queue, then other transitions are queued depending on the value of Interruption Source:

| Value | Function |
| --- | --- |
| None | Don’t add any more transitions. |
| Current State | Queue the transitions from the current state. |
| Next State | Queue the transitions from the next state. |
| Current State then Next State | Queue the transitions from the current state, then queue the ones from the next state. |
| Next State then Current State | Queue the transitions from the next state, then queue the ones from the current state. |

**Ordered Interruption property** \

The property Ordered Interruption changes how the queue is parsed.

| Value | Ends when |
| --- | --- |
| Checked | A valid transition or the current transition has been found. |
| Unchecked | A valid transition has been found. |

> Only an AnyState transition can be interrupted by itself.



https://docs.unity3d.com/Manual/class-Transition.html
