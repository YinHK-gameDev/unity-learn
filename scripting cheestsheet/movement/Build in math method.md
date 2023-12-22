### Mathf

#### `Mathf.SmoothDamp`

Gradually changes a value towards a desired goal over time.

The value is smoothed by some spring-damper like function, which will never overshoot. The function can be used to smooth any kind of value, positions, colors, scalars.


#### `Mathf.MoveTowards`

Moves a value `current` towards `target`.

This is essentially the same as `Mathf.Lerp` but instead the function will ensure that the speed never exceeds `maxDelta`. Negative values of `maxDelta` pushes the value away from `target`.

#### `Mathf.Lerp`
Linearly interpolates between `a` and `b` by `t`.

The parameter `t` is clamped to the range \[0, 1\].  
  
When `t` = 0 returns `a`. \
When `t` = 1 return `b`. \
When `t` = 0.5 returns the midpoint of `a` and `b`.

> A common use for Lerp is to produce an effect over a fixed period of time. For example, to animate a button, fade the screen to black or move an object to a new position in a fixed amount of time.






### ref

https://gamedevbeginner.com/the-right-way-to-lerp-in-unity-with-examples/

https://docs.unity3d.com/ScriptReference/Mathf.SmoothDamp.html

https://docs.unity3d.com/ScriptReference/Mathf.MoveTowards.html

https://docs.unity3d.com/ScriptReference/Mathf.Lerp.html
