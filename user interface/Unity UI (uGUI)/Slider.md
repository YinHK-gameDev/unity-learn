## Slider

The value of a Slider is determined by the position of the handle along its length. The value increases from the _Min Value_ up to the _Max Value_ in proportion to the distance the handle is dragged. The default behaviour is for the slider to increase from left to right but it is also possible to reverse this behavior using the _Direction_ property. You can also set the slider to increase vertically by selecting _Bottom To Top_ or _Top To Bottom_ for the _Direction_ property.

The slider has a single event called **_On Value Changed_** that responds as the user drags the handle. The current numeric value of the slider is passed to the function as a **`float`** parameter. Typical use cases include:

-   Choosing a level of difficulty in a game, brightness of a light, etc.
-   Setting a distance, size, time or angle.

```cs
public virtual float value { get; set; }
```

```cs
using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class Example : MonoBehaviour
{
    public Slider mainSlider;

    //Invoked when a submit button is clicked.
    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        Debug.Log(mainSlider.value);
    }
}
```

```cs
public Slider.SliderEvent onValueChanged { get; set; }
```
``cs
using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class Example : MonoBehaviour
{
    public Slider mainSlider;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        mainSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        Debug.Log(mainSlider.value);
    }
}
```


```cs
public float maxValue { get; set; }
```

```cs
public float minValue { get; set; }
```



### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-Slider.html

https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.Slider.html
