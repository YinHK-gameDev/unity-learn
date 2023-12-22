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

Eg:

**Lerp a Vector in movement**

```cs
float lerpDuration = 3; 
float startValue = 0; 
float endValue = 10; 
float valueToLerp;
void Start()
    {
        StartCoroutine(Lerp());
    }
IEnumerator Lerp()
    {
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        valueToLerp = endValue;
    }
```

```cs
public float targetValue;
void Start()
{
  StartCoroutine(LerpFunction(targetValue, 5));
}
IEnumerator LerpFunction(float endValue, float duration)
{
  float time = 0;
  float startValue = valueToChange;
  while (time < duration)
  {
    valueToChange = Mathf.Lerp(startValue, endValue, time / duration);
    time += Time.deltaTime;
    yield return null;
  }
  valueToChange = endValue;
}
```
```cs
public class LerpToPosition : MonoBehaviour
{
    public Vector3 positionToMoveTo;
    void Start()
    {
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
    }
    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
```
```cs
public class Lerp2D : MonoBehaviour
{
    public Vector2 positionToMoveTo;
    void Start()
    {
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
    }
    IEnumerator LerpPosition(Vector2 targetPosition, float duration)
    {
        float time = 0;
        Vector2 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector2.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
```


### ref

https://gamedevbeginner.com/the-right-way-to-lerp-in-unity-with-examples/

https://docs.unity3d.com/ScriptReference/Mathf.SmoothDamp.html

https://docs.unity3d.com/ScriptReference/Mathf.MoveTowards.html

https://docs.unity3d.com/ScriptReference/Mathf.Lerp.html
