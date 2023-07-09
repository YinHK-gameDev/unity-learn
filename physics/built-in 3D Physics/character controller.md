## character controller

The character in a first- or third-person game usually needs some collision-based physics so that it doesn’t fall through the floor or walk through walls. In many applications, the character’s acceleration and movement are intentionally not physically realistic, so that the character can accelerate, brake and change direction almost instantly and without being affected by momentum.

A simple, capsule-shaped collider component with specialized features for behaving as a character in a game. Unlike true collider components, a Rigidbody is not needed and the momentum effects are not realistic.

A character controller **cannot walk through static colliders in a scene**, and so will follow floors and be obstructed by walls. It can push rigidbody objects aside while moving but will not be accelerated by incoming collisionsA collision occurs when the physics engine detects that the colliders of two GameObjects make contact or overlap, when at least one has a Rigidbody component and is in motion. More info
See in Glossary.

In a first-person or third-person application, a user’s character or avatar
 usually needs some collision-based physics, so that it doesn’t fall through the floor or walk through walls. In 3D physics, you can **create and configure character physics** and **control with a Character Controller**.



### Character Controller component
> The **Character Controller** is mainly **used for third-person or first-person player control** that **does not make use of Rigidbody
 physics**.




| **_Property:_** | **_Function:_** |
| --- | --- |
| **Slope Limit** | Limits the collider to only climb slopes that are less steep (in degrees) than the indicated value. |
| **Step Offset** | The character will step up a stair only if it is closer to the ground than the indicated value. This should not be greater than the Character Controller’s height or it will generate an error. |
| **Skin width** | Two colliders can penetrate each other as deep as their Skin Width. Larger Skin Widths reduce jitter. Low Skin Width can cause the character to get stuck. A good setting is to make this value 10% of the Radius. |
| **Min Move Distance** | If the character tries to move below the indicated value, it will not move at all. This can be used to reduce jitter. In most situations this value should be left at 0. |
| **Center** | This will offset the Capsule Collider in world space, and won’t affect how the Character pivots. |
| **Radius** | Length of the Capsule Collider’s radius. This is essentially the width of the collider. |
| **Height** | The Character’s **Capsule Collider** height. Changing this will scale the collider along the Y axis in both positive and negative directions. |


### ref
https://docs.unity3d.com/Manual/class-CharacterController.html

Character Controller component reference \
https://docs.unity3d.com/Manual/class-CharacterController.html


