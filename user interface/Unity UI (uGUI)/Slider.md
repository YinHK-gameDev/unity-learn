## Slider

The value of a Slider is determined by the position of the handle along its length. The value increases from the _Min Value_ up to the _Max Value_ in proportion to the distance the handle is dragged. The default behaviour is for the slider to increase from left to right but it is also possible to reverse this behavior using the _Direction_ property. You can also set the slider to increase vertically by selecting _Bottom To Top_ or _Top To Bottom_ for the _Direction_ property.

The slider has a single event called _On Value Changed_ that responds as the user drags the handle. The current numeric value of the slider is passed to the function as a `float` parameter. Typical use cases include:

-   Choosing a level of difficulty in a game, brightness of a light, etc.
-   Setting a distance, size, time or angle.


### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-Slider.html

https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.Slider.html
