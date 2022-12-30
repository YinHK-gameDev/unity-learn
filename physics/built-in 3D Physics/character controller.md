## character controller

The character in a first- or third-person game usually needs some collision-based physics so that it doesn’t fall through the floor or walk through walls. In many applications, the character’s acceleration and movement are intentionally not physically realistic, so that the character can accelerate, brake and change direction almost instantly and without being affected by momentum.

A simple, capsule-shaped collider component with specialized features for behaving as a character in a game. Unlike true collider components, a Rigidbody is not needed and the momentum effects are not realistic.

A character controller cannot walk through static colliders in a scene
, and so will follow floors and be obstructed by walls. It can push rigidbody objects aside while moving but will not be accelerated by incoming collisionsA collision occurs when the physics engine detects that the colliders of two GameObjects make contact or overlap, when at least one has a Rigidbody component and is in motion. More info
See in Glossary.


> The **Character Controller** is mainly **used for third-person or first-person player control** that **does not make use of Rigidbody
 physics**.


https://docs.unity3d.com/Manual/class-CharacterController.html
