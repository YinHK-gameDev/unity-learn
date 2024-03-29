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

### Importing a model with humanoid animations

The Animation System works with two types of models:

- A Humanoid model is a specific structure, containing at least 15 bones organized in a way that loosely conforms to an actual human skeleton. This page contains guidance on importing this type of model.
- A Generic model is everything else. This might be anything from a teakettle to a dragon.


#### Set up the Avatar
From the **Rig** tab of the Inspector window, **set the Animation Type to Humanoid**. By default, the Avatar Definition property is set to **Create From This Model**. If you keep this option, Unity attempts to map the set of bones defined in the file to a Humanoid Avatar. If you have 3d model and created Avatar already, and only import the additional animation to that model/avatar, you can choose **copy from other Avatar** in the Avatar definition and find the source of Avatar.

![](./Rig-2.png)

https://docs.unity3d.com/Manual/ConfiguringtheAvatar.html

### Retargeting of Humanoid animations
One of the most powerful features of Mecanim is retargeting of humanoid animations. This means that with relative ease, you can **apply the same set of animations to various character models**. 

Retargeting is **only possible** for **humanoid models**, where an Avatar has been configured, because this gives us a correspondence between the models’ bone structure.

When working with Mecanim animations, you can expect your scene to contain the following elements:-

- The Imported character model, which has an Avatar on it.
- The Animator Component, referencing an Animator Controller asset.
- A set of animation clips, referenced from the Animator Controller.
- Scripts for the character.
- Character-related components, such as the Character Controller.


Your project should also contain another character model **with a valid Avatar**.


In order to reuse the same animations on another model, you need to:

-   Disable the original model
-   Put the model as a child of the GameObject, together with the Animator component
-   Make sure scripts referencing the Animator are looking for the animator in the children instead of the root; use `GetComponentInChildren<Animator>()` instead of `GetComponent<Animator>()`.
-   Make sure the Animator Controller property for the new model is referencing the same controller asset

https://www.youtube.com/watch?v=fNgPkuMgWFg

https://docs.unity3d.com/Manual/Retargeting.html

