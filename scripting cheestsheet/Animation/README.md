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





