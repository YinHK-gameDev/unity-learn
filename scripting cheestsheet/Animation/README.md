## Use script to control animation 


### Animation 
The animation component is used to play back animations.

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

### Animator


https://docs.unity3d.com/ScriptReference/Animator.html


Use parameter to control animation and transitions between Animator states:

- **Animator.SetTrigger**
    
    [Animator.SetTrigger](https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html)
    
- **Animator.SetBool**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetBool.html
    
- **Animator.SetInteger**
    
    https://docs.unity3d.com/ScriptReference/Animator.SetInteger.html
    
- **Unity animation transition has exit time**
    
    https://jerrard-liu.blogspot.com/2016/04/MecanimPart3.html
    
- **Five tips for keeping animator controllers nice & tidy**
    
    [Neat and tidy animator controllers | Unity](https://unity3d.com/how-to/build-animator-controllers)
    
    [Game Design Tutorial: How to Use Blend Trees in Unity](https://www.studica.com/blog/game-design-tutorial-blend-trees-unity)




