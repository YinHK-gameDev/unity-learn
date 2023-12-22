## Lerp(Linear Interpolation)


Lerp, or Linear Interpolation, is a mathematical function in Unity that returns a value between two others at a point on a linear scale.

Most commonly it’s used for moving or changing values over a period of time.

```cs
lerpValue = Mathf.Lerp(minValue, maxValue, interpolationPoint);
```

```cs
float a = 0;
float b = 50;
float t = 0.5f;
lerpValue = Mathf.Lerp(a, b, t);
// Returns 25
```
```cs
float a = 10;
float b = 50;
float t = 1;
lerpValue = Mathf.Lerp(a, b, t);
// Returns 50
```

> A common use for Lerp is to produce an effect over a fixed period of time.


```cs
float timeElapsed;
float lerpDuration = 3;
float startValue=0;
float endValue=10;
float valueToLerp;
void Update()
{
  if (timeElapsed < lerpDuration)
  {
    valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
    timeElapsed += Time.deltaTime;
  }
}
```
```cs
void Lerp()
  {
    if (timeElapsed < lerpDuration)
    {
      valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
      timeElapsed += Time.deltaTime;
    }
    else 
    {
      valueToLerp = endValue;
    }
  }
```
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

#### Lerp slowing down at the end (and how to stop it)

```cs
transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
```
`
#### Using formular for lerp

define a interpolation formular equation for lerping

Eg: 
Define equation t = t * t * (3f - 2f * t) for lerping

```cs
float t = time / duration;
t = t * t * (3f - 2f * t);
transform.position = Vector3.Lerp(startPosition, endPosition, t);
```

#### Using Lerp by speed (instead of time)

Incrementing a speed value that’s multiplied by Time.delta Time and then passing that in as the interpolation point.

Eg: 

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

#### Lerp a Vector 3

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

#### Lerp a Vector 2

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

#### Lerp Rotation

```cs
public Vector3 targetRotation;
    void Start()
    {
        StartCoroutine(LerpFunction(Quaternion.Euler(targetRotation), 5));
    }
    IEnumerator LerpFunction(Quaternion endValue, float duration)
    {
        float time = 0;
        Quaternion startValue = transform.rotation;
        while (time < duration)
        {
            transform.rotation = Quaternion.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = endValue;
    }
```

#### Lerp scale

```cs
public float targetScale;
public float timeToLerp = 0.25f;
float scaleModifier = 1;
void Start()
{
    StartCoroutine(LerpFunction(targetScale, timeToLerp));
}
IEnumerator LerpFunction(float endValue, float duration)
{
    float time = 0;
    float startValue = scaleModifier;
    Vector3 startScale = transform.localScale;
    while (time < duration)
    {
        scaleModifier = Mathf.Lerp(startValue, endValue, time / duration);
        transform.localScale = startScale * scaleModifier;
        time += Time.deltaTime;
        yield return null;
    }
    
    transform.localScale = startScale * endValue;
    scaleModifier = endValue;
}

```

#### Lerp a Material’s Colour

```cs
public class LerpMaterialColour : MonoBehaviour
{
    public Color targetColor = new Color(0, 1, 0, 1); 
    public Material materialToChange;
    void Start()
    {
        materialToChange = gameObject.GetComponent<Renderer>().material;
        StartCoroutine(LerpFunction(targetColor, 5));
    }
    IEnumerator LerpFunction(Color endValue, float duration)
    {
        float time = 0;
        Color startValue = materialToChange.color;
        while (time < duration)
        {
            materialToChange.color = Color.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        materialToChange.color = endValue;
    }
}

```


#### Fade Camera to black

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class FadeToBlack : MonoBehaviour
{
    public float targetValue = 0;
    CanvasRenderer elementToFade;
    void Start()
    {
        elementToFade = gameObject.GetComponent<CanvasRenderer>();
        StartCoroutine(LerpFunction(targetValue, 3));
    }
    IEnumerator LerpFunction(float endValue, float duration)
    {
        float time = 0;
        float startValue = elementToFade.GetAlpha();
        while (time < duration)
        {
            elementToFade.SetAlpha(Mathf.Lerp(startValue, endValue, time / duration));
            time += Time.deltaTime;
            yield return null;
        }
        elementToFade.SetAlpha(endValue);
    }
}
```

#### fade out Text 

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class LerpColour : MonoBehaviour
{
    // Fades the text out
    public Color targetColor = new Color(0,0,0,0);
    Text textToFade;
    void Start()
    {
        textToFade = gameObject.GetComponent<Text>();
        StartCoroutine(LerpFunction(targetColor, 5));
    }
    IEnumerator LerpFunction(Color endValue, float duration)
    {
        float time = 0;
        Color startValue = textToFade.color;
        while (time < duration)
        {
            textToFade.color = Color.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        textToFade.color = endValue;
    }
}
```

#### Fade out a sprite

```cs
public float targetValue=0;
public AudioSource audioSource;
void Start()
  {
    audioSource = GetComponent<AudioSource>();
    StartCoroutine(LerpFunction(targetValue, 5));
  }
  IEnumerator LerpFunction(float endValue, float duration)
  {
    float time = 0;
    float startValue = audioSource.volume;
    while (time < duration)
    {
      audioSource.volume = Mathf.Lerp(startValue, endValue, time / duration);
      time += Time.deltaTime;
      yield return null;
    }
    audioSource.volume = endValue;
  }
```

#### Fade out an Audio Source

```cs
public float targetValue=0;
public AudioSource audioSource;
void Start()
  {
    audioSource = GetComponent<AudioSource>();
    StartCoroutine(LerpFunction(targetValue, 5));
  }
  IEnumerator LerpFunction(float endValue, float duration)
  {
    float time = 0;
    float startValue = audioSource.volume;
    while (time < duration)
    {
      audioSource.volume = Mathf.Lerp(startValue, endValue, time / duration);
      time += Time.deltaTime;
      yield return null;
    }
    audioSource.volume = endValue;
  }
```



### ref 
https://gamedevbeginner.com/the-right-way-to-lerp-in-unity-with-examples/

https://youtu.be/RNccTrsgO9g

https://docs.unity3d.com/ScriptReference/Mathf.Lerp.html

https://docs.unity3d.com/ScriptReference/Color.Lerp.html

https://docs.unity3d.com/ScriptReference/Quaternion.Lerp.html

https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
