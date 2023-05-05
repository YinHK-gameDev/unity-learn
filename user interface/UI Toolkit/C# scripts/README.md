### Load UXML and USS C# scripts
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


The following example `EditorWindow` class receives default references from the Inspector:

```csharp
using UnityEditor;
using UnityEngine.UIElements;

public class MyWindow : EditorWindow
{
  [SerializeField]
  private VisualTreeAsset uxml;
  [SerializeField]
  private StyleSheet uss;
}
```

### Use the Asset Database (Editor only)
You can load your **UI Assets** by **path** or **GUID** with the **`AssetDatabase`** class.

The following example shows how to locate an asset by path:

```csharp
VisualTreeAsset uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/main_window.uxml");
StyleSheet uss = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/main_styles.uss");
```

The following example shows how to locate an asset by path from a package:

```csharp
VisualTreeAsset uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Packages/<name-of-the-package>/main_window.uxml");
StyleSheet uss = AssetDatabase.LoadAssetAtPath<StyleSheet>("Packages/<name-of-the-package>/main_styles.uss");
```

### Use Addressables
The Addressables system provides tools and scripts to organize and package content for your application and an API to load and release assets at runtime.

You can use UXML and USS assets with the Addressable system.

For information about how to set up Addressables for any assets in Unity, see [Getting started with Addressables](https://docs.unity3d.com/Packages/com.unity.addressables@1.19/manual/AddressableAssetsGettingStarted.html).


### Use a Resources folder
If you add a **`Resources`** folder in your project and place your UI assets in it, you can use the **`Resources.Load`** method to load your assets.

The following examples shows how to load an asset in the **`Resources`** folder:
```cs
VisualTreeAsset uxml = Resources.Load<VisualTreeAsset>("main_window");
StyleSheet uss = Resources.Load<StyleSheet>("main_styles");
```

> **Note**: This method increases the final build size significantly. If you are concerned with the build size, use **`Addressables`** instead.


### Instantiate UXML from C# scripts
To build **UI** from a **UXML** file, you must first load the file into a VisualTreeAsset, and then use the **`Instantiate()`** to instantiate without a parent, which creates a new `TemplateContainer`, or `CloneTree(parent))` to **clone inside a parent**.

Once the **UXML** is **instantiated**, you can retrieve specific elements from the visual tree with **UQuery**.


The following example creates a custom Editor window and loads a UXML file as its content:

```csharp
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class MyWindow : EditorWindow  {
    [MenuItem ("Window/My Window")]
    public static void  ShowWindow () {
        EditorWindow w = EditorWindow.GetWindow(typeof(MyWindow));

        VisualTreeAsset uiAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/MyWindow.uxml");
        VisualElement ui = uiAsset.Instantiate();

        w.rootVisualElement.Add(ui);
    }
}
```

### ref 
https://docs.unity3d.com/Manual/UIE-manage-asset-reference.html

https://docs.unity3d.com/Manual/UIE-Controls.html

https://docs.unity3d.com/Manual/UIE-apply-styles-with-csharp.html


