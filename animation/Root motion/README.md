## Root motion
Motion of character’s root node, whether it’s controlled by the animation itself or externally.

### Root node
A transform in an animation hierarchy that allows Unity to establish consistency between Animation clips for a generic model. It also enables Unity to properly blend between Animations that have not been authored “in place” (that is, where the whole Model moves its world position while animating). 


### Explain root motion
Animations set things to a specific value. For example, if a movement animation might start the position.x at 0 and move it to 1 over the course of the animation, but then when the animation loops it will set it to 0 again and teleport back to the start.

**Root motion changes any movement that would normally be applied to the root object to be additive instead**. So if your position.x is at 4 and you play that animation it will add the motion so it moves towards 5 and not jump back to the starting value when it loops.

https://forum.unity.com/threads/confused-about-apply-root-motion-in-the-animator-component.940223/


https://youtu.be/Xl_5roq4UlI

https://www.youtube.com/watch?v=9bV0K-pifXE


### Root motion with character controller 
https://youtu.be/mNxEetKzc04





### Ref
https://docs.unity3d.com/Manual/RootMotion.html
