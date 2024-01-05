## Animator component

Use the **Animator component to assign animation to a GameObject** in your Scene. \
The Animator component requires a **reference to an Animator Controller** which defines which **animation clips** to **use**, and **controls** when and how to **blend** and **transition between them**.

If the GameObject is a humanoid character with an Avatar definition, the Avatar should also be assigned in this component


### Properties

- Controller:  The animator controller attached to this character.
- Avatar:  The Avatar for this character. (If the Animator is being used to animate a humanoid character)
- Apply Root Motion: Select whether to control the character’s position and rotation from the animation itself or from script.
- Update Mode: This allows you to select when the Animator updates, and which timescale it should use.
  - Normal: The Animator is updated in-sync with the Update call, and the animator’s speed matches the current timescale. If the timescale is slowed, animations will slow down to match.
  - Animate Physics: The animator is updated in-sync with the FixedUpdate call (i.e. in lock-step with the physics system). You should use this mode if you are animating the motion of objects with physics interactions, such as characters which can push rigidbody objects around.
  - Unscaled Time: The animator is updated in-sync with the Update call, but the animator’s speed ignores the current timescale and animates at 100% speed regardless. This is useful for animating a GUI system at normal speed while using modified timescales for special effects or to pause gameplay.
- Culling Mode: Culling mode you can choose for animations.
  - Always Animate: Always animate, don’t do culling even when offscreen.
  - Cull Update Transforms: Retarget, IK and write of Transforms are disabled when renderers are not visible.
  - Cull Completely: Animation is completely disabled when renderers are not visible.
  
  
https://docs.unity3d.com/Manual/class-Animator.html


  
