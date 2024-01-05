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


// Methods

// Plays a state.
public void Play(string stateName, int layer = -1, float normalizedTime = float.NegativeInfinity);

// Evaluates the animator based on deltaTime.
public void Update(float deltaTime);

// Returns the value of the given boolean parameter.
public bool GetBool(string name);

// Returns the value of the given float parameter.
public float GetFloat(string name);

// Returns the value of the given integer parameter.
public int GetInteger(string name);
public int GetInteger(int id);

```





https://docs.unity3d.com/ScriptReference/Animator.html

Use parameter to control animation and transitions between Animator states:

- **`Animator.SetTrigger`**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html
    
- **`Animator.SetBool`**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetBool.html
    
- **`Animator.SetInteger`**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetInteger.html
    
#### Unity animation transition has exit time
https://jerrard-liu.blogspot.com/2016/04/MecanimPart3.html
    
#### Five tips for keeping animator controllers nice & tidy
https://unity3d.com/how-to/build-animator-controllers \
https://www.studica.com/blog/game-design-tutorial-blend-trees-unity


### AnimationClip
AnimationClip is used by Animation to play back animations.


https://docs.unity3d.com/ScriptReference/AnimationClip.html


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

