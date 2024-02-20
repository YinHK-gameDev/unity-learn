## Color 

Representation of RGBA colors.

This structure is used throughout Unity to pass colors around. Each color component is a floating point value with a range from 0 to 1.

| Static Properties | Descriptuion |
| --- | --- |
| black | Solid black. RGBA is (0, 0, 0, 1). |
| blue | Solid blue. RGBA is (0, 0, 1, 1). |
| clear | Completely transparent. RGBA is (0, 0, 0, 0). |
| cyan | Cyan. RGBA is (0, 1, 1, 1). |
| gray | Gray. RGBA is (0.5, 0.5, 0.5, 1). |
| green | Solid green. RGBA is (0, 1, 0, 1). |
| grey | English spelling for gray. RGBA is the same (0.5, 0.5, 0.5, 1). |
| magenta | Magenta. RGBA is (1, 0, 1, 1). |
| red | Solid red. RGBA is (1, 0, 0, 1). |
| white | Solid white. RGBA is (1, 1, 1, 1). |
| yellow | Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at! |

| Properties | Descriptuion |
| --- | --- |
| a | Alpha component of the color (0 is transparent, 1 is opaque). 
| b | Blue component of the color. |
| g | Green component of the color. |
| gamma | A version of the color that has had the gamma curve applied. |
| grayscale | The grayscale value of the color. (Read Only) |
| linear | A linear value of an sRGB color. |
| maxColorComponent | Returns the maximum color component value: Max(r,g,b). |
| r | Red component of the color. |
| this[int] | Access the r, g, b,a components using [0], [1], [2], [3] respectively. |


**Constructor** 
```cs
public Color(float r, float g, float b, float a);
```


| Static Methods | Description |
| --- | --- |
| HSVToRGB | Creates an RGB colour from HSV input. |
| Lerp | Linearly interpolates between colors a and b by t. |
| LerpUnclamped | Linearly interpolates between colors a and b by t. |
| RGBToHSV | Calculates the hue, saturation and value of an RGB input color. |


### ref 
https://docs.unity3d.com/ScriptReference/Color.html
