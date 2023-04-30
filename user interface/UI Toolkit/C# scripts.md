## Load UXML and USS C# scripts
Unity represents UXML files as `VisualTreeAsset` objects in C# and represents USS files as `StyleSheet` objects in C#. Since `VisualTreeAsset` and `StyleSheet` are regular Unity assets, you can use Unity’s standard workflows to load them.

Unity automatically detect fields from your C# scripts
 which are of type `VisualTreeAsset` or `StyleSheet`. You can use the Inspector
 to set references to specific UXML or USS files imported in your project. Such **references remain valid even when the location of your assets change in your project**.


The following example `MonoBehaviour` class receives a UXML file and a list of USS files from the Inspector:

```csharp
using UnityEngine;
using UnityEngine.UIElements;

public class MyBehaviour : MonoBehaviour
{
  // Note that public fields are automatically exposed in the Inspector
  public VisualTreeAsset mainUI;
  [Reorderable]
  public StyleSheet[] seasonalThemes;
}
```


### ref 
https://docs.unity3d.com/Manual/UIE-manage-asset-reference.html


