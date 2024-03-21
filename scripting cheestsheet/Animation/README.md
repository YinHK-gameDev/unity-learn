## Use script to control animation 

### Animator

```cs
// Properties

// The playback speed of the Animator. 1 is normal playback speed.
public float speed;

// The AnimatorControllerParameter list used by the animator. (Read Only)
public AnimatorControllerParameter[] parameters;

// Gets/Sets the current Avatar.
public Avatar avatar;

// Returns the number of layers in the controller.
public int layerCount;

// Should root motion be applied?
public bool applyRootMotion;

// Methods

// Plays a state.
public void Play(string stateName, int layer = -1, float normalizedTime = float.NegativeInfinity);

// Evaluates the animator based on deltaTime.
public void Update(float deltaTime);

// Returns the value of the given boolean parameter.
public bool GetBool(string name);
public bool GetBool(int id);

// Returns the value of the given float parameter.
public float GetFloat(string name);
public float GetFloat(int id);

// Returns the value of the given integer parameter.
public int GetInteger(string name);
public int GetInteger(int id);

// The runtime AnimatorController that controls the Animator.
public RuntimeAnimatorController runtimeAnimatorController;


```





https://docs.unity3d.com/ScriptReference/Animator.html

Use parameter to control animation and transitions between Animator states:

- **`Animator.SetTrigger`**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html
    
- **`Animator.SetBool`**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetBool.html
    
- **`Animator.SetInteger`**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetInteger.html
    

#### Change Animator Controller during runtime

```cs
Animator animator = gameObject.GetComponent<Animator>();
animator.runtimeAnimatorController = Resources.Load("path_to_your_controller") as RuntimeAnimatorController;
```

https://discussions.unity.com/t/how-to-set-animators-controller-in-script/63474/8 \
https://discussions.unity.com/t/change-animatorcontroller-during-runtime/118974


### AnimationClip
AnimationClip is used by Animation to **play back** animations.

```cs
// properties

// Animation length in seconds. (Read Only)
public float length;

// Returns true if the animation clip has no curves and no events.
public bool empty;

// Returns true if the AnimationClip has root Curves.
public bool hasRootCurves;

// Returns true if the AnimationClip has root motion curves.
public bool hasMotionCurves;

// Returns true if the AnimationClip has editor curves for its root motion.
public bool hasMotionFloatCurves;

// Animation Events for this animation clip.
public AnimationEvent[] events;


// Methods

// Adds an animation event to the clip
public void AddEvent(AnimationEvent evt);

// Clears all curves from the clip
public void ClearCurves();

// Assigns the curve to animate a specific property.
public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve);


//Eg:
// This script example shows how SetCurve() can be used
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    // Animate the position and color of the GameObject
    public void Start()
    {
        Animation anim = GetComponent<Animation>();
        AnimationCurve curve;

        // create a new AnimationClip
        AnimationClip clip = new AnimationClip();
        clip.legacy = true;

        // create a curve to move the GameObject and assign to the clip
        Keyframe[] keys;
        keys = new Keyframe[3];
        keys[0] = new Keyframe(0.0f, 0.0f);
        keys[1] = new Keyframe(1.0f, 1.5f);
        keys[2] = new Keyframe(2.0f, 0.0f);
        curve = new AnimationCurve(keys);
        clip.SetCurve("", typeof(Transform), "localPosition.x", curve);

        // update the clip to a change the red color
        curve = AnimationCurve.Linear(0.0f, 1.0f, 2.0f, 0.0f);
        clip.SetCurve("", typeof(Material), "_Color.r", curve);

        // now animate the GameObject
        anim.AddClip(clip, clip.name);
        anim.Play(clip.name);
    }
}
```

AnimationClip \
https://docs.unity3d.com/ScriptReference/AnimationClip.html

AnimationCurve \
https://docs.unity3d.com/ScriptReference/AnimationCurve.html

Keyframe \
https://docs.unity3d.com/ScriptReference/Keyframe.html

### AnimatorOverrideController

https://docs.unity3d.com/ScriptReference/AnimatorOverrideController.html


### AnimatorController


https://docs.unity3d.com/ScriptReference/Animations.AnimatorController.html


### Animation(As Animation component is legacy, use Animator instead)
The animation component is used to **play back animations**.

You can assign animation clips to the animation component and control playback from your script.


```cs
    public Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }
    }

```

https://docs.unity3d.com/ScriptReference/Animation.html

