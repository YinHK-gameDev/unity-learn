## TooltipAttribute

This attribute specify a tooltip for a field in the Inspector window.


In the following script a `Tooltip` is added. This provides information to the user about the range of values for the `health` variable. The suggested range is provided in the `TooltipAttribute` string.  
  
Note: Unity will only use Tooltips from Fields when displaying them in the Editor. You can add Tooltips to other areas, such as classes, structs, and properties to work with user created editor extensions, but Unity won't display them in the Editor.


```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    [Tooltip("Health value between 0 and 100.")]
    int health = 0;
}
```


### ref 
https://docs.unity3d.com/ScriptReference/TooltipAttribute.html


