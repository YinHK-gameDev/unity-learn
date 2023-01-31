## Humanoid & Avatar

Unity’s Animation System has special features for working with humanoid characters. Because humanoid characters are so common in games, Unity provides a specialized workflow, and an extended tool set for humanoid animation

The Avatar system is how Unity identifies that a particular animated model is humanoid in layout, and which parts of the model correspond to the legs, arms, head and body.

Because of the similarity in bone structure between different humanoid characters, it is possible to map animations from one humanoid character to another, allowing retargeting and inverse kinematics(IK).

https://docs.unity3d.com/Manual/ConfiguringtheAvatar.html

https://youtu.be/BEZHVYk6Fa4


### Unity animation for humanoid model
https://www.youtube.com/watch?v=HPwu7eIwjV8

### Animation Avatar from Mixamo
https://www.youtube.com/watch?v=76Lh0UApjNI

https://www.youtube.com/watch?v=679WLW2igns

### Retargeting of Humanoid animations
One of the most powerful features of Mecanim is retargeting of humanoid animations. This means that with relative ease, you can apply the same set of animations to various character models. Retargeting is only possible for humanoid models, where an Avatar has been configured, because this gives us a correspondence between the models’ bone structure.

When working with Mecanim animations, you can expect your scene
 to contain the following elements:-

- The Imported character model, which has an Avatar on it.
- The Animator Component, referencing an Animator Controller asset.
- A set of animation clips, referenced from the Animator Controller.
- Scripts for the character.
- Character-related components, such as the Character Controller.

https://www.youtube.com/watch?v=fNgPkuMgWFg

https://docs.unity3d.com/Manual/Retargeting.html

