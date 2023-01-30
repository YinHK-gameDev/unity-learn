## Root motion
Motion of character’s root node, whether it’s controlled by the animation itself or externally.

### Root node
A transform in an animation hierarchy that allows Unity to establish consistency between Animation clips for a generic model. It also enables Unity to properly blend between Animations that have not been authored “in place” (that is, where the whole Model moves its world position while animating). 


### Explain root motion
Animations set things to a specific value. For example, if a movement animation might start the position.x at 0 and move it to 1 over the course of the animation, but then when the animation loops it will set it to 0 again and teleport back to the start.

**Root motion changes any movement that would normally be applied to the root object to be additive instead**. So if your position.x is at 4 and you play that animation it will add the motion so it moves towards 5 and not jump back to the starting value when it loops.


In Unity, it is possible to move our game objects using **root motion** without writing any script. Unity calculate the motion and move the object according to the animation.

https://forum.unity.com/threads/confused-about-apply-root-motion-in-the-animator-component.940223/


https://youtu.be/Xl_5roq4UlI

https://youtu.be/Kn6jxLWA31M

https://www.youtube.com/watch?v=9bV0K-pifXE


### What's root motion and how it works?
**Treadmill vs root motion**: There are two types of animation, **treadmill** and **root motion**. 
- **Treadmill** means that the animation stays at the origin and we use code to move that asset around.
- **Root motion** means the motion is built right into the animation and it's the animation that determines how far something moves rather than code.

https://answers.unity.com/questions/1238987/whats-root-motion-and-how-it-works.html


### Root motion with character controller 

https://youtu.be/mNxEetKzc04


### Control the root motion
The **Animation Clip Editor** settings - **Root Transform Rotation**, **Root Transform Position (Y)** and **Root Transform Position (XZ)** - let you control the Root Transform projection from the Body Transform. Depending on these settings some parts of the Body Transform may be transferred to Root Transform. For example you can decide if you want the motion Y position to be part of the Root Motion (trajectory) or part of the pose (body transform), which is known as Baked into Pose.


### Body Transform
The Body Transform is the mass center of the character. It is used in Mecanim’s retargeting engine and provides the most stable displacement model. The Body Orientation is an average of the lower and upper body orientation relative to the Avatar T-Pose.

### Root Transform
The Root Transform is a projection on the Y plane of the Body Transform and is computed at runtime. At every frame, a change in the Root Transform is computed. This change in transform is then applied to the Game Object to make it move.

### Root Transform Rotation
- **Bake into Pose**: The orientation will stay on the body transform (or Pose). The Root Orientation will be constant and delta Orientation will be identity. This means that the Game Object will not be rotated at all by that AnimationClip.

Only AnimationClips that have similar start and stop Root Orientation should use this option. You will have a Green Light in the UI
telling you that an AnimationClip is a good candidate. A suitable candidate would be a straight walk or a run.

- **Based Upon**: This lets you set the orientation of the clip. Using Body Orientation, the clip will be oriented to follow the forward vector of body. This default setting works well for most Motion Capture (Mocap) data like walks, runs, and jumps, but it will fail with motion like strafing where the motion is perpendicular to the body’s forward vector. In those cases you can manually adjust the orientation using the Offset setting. Finally you have Original that will automatically add the authored offset found in the imported clip. It is usually used with Keyframed data to respect orientation that was set by the artist.

- **Offset**: used to enter the offset when that option is chosen for Based Upon.

### Root Transform Position (Y)
- **Bake Into Pose**: The Y component of the motion will stay on the Body Transform (Pose). The Y component of the Root Transform will be constant and Delta Root Position Y will be 0. This means that this clip won’t change the Game Object Height. Again you have a Green Light telling you that a clip is a good candidate for baking Y motion into pose.

Most of the AnimationClips will enable this setting. Only clips that will change the GameObject
 height should have this turned off, like jump up or down.

> **Note**: the Animator.gravityWeight is driven by Bake Into Pose position Y. When enabled, gravityWeight = 1, when disabled = 0. gravityWeight is blended for clips when transitioning between states.

- **Based Upon**: In a similar way to Root Transform Rotation you can choose from Original or Mass Center (Body). There is also a Feet option that is very convenient for AnimationClips that change height (Bake Into Pose disabled). When using Feet the Root Transform Position Y will match the lowest foot Y for all frames. Thus the blending point always remains around the feet which prevents floating problem when blending or transitioning.

- **Offset**: In a similar way to Root Transform Rotation, you can manually adjust the AnimationClip height using the Offset setting.

### Root Transform Position (XZ)

**Bake Into Pose** will usually be used for “Idles” where you want to force the delta Position (XZ) to be 0. It will stop the accumulation of small deltas drifting after many evaluations. It can also be used for a Keyframed clip with Based Upon Original to force an authored position that was set by the artist.

### Loop Pose
Loop Pose (like Pose Blending in Blend Trees or Transitions) happens in the referential of Root Transform. Once the Root Transform is computed, the Pose becomes relative to it. The relative Pose difference between Start and Stop frame is computed and distributed over the range of the clip from 0–100%

### Ref
https://docs.unity3d.com/Manual/RootMotion.html
