## Use script to control animation 


### Animation 
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

```cs
 public Animation anim;

// properties

// The default animation.
anim.clip;

// Is an animation currently being played?


```

https://docs.unity3d.com/ScriptReference/Animation.html

### Animator


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





