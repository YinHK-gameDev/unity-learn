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


## Structure UI with C# scripts

Technical users can define the layout of the **UI** directly in C# scripts.

> You can define the **look of controls** in a **USS** file, or **modify the style properties** of the control in your C# script.

Controls are interactive and represent a value that you can change. For example, a **FloatField** represents a float value. You can create C# scripts to change the value of a control, register a callback, or apply data binding.


### Add controls to a UI with C# scripts
To use a control in a UI, add it to the visual tree.

The following example adds a Button control to an existing visual tree.
```cs
var newButton = new Button("Click me!");
rootVisualElement.Add(newButton);
```

> When adding controls to a UI hierarchy, the **layout engine** automatically handles the **sizing** and **positioning**. You can also **override the size and position of visual elements**.

### Acess or change the control value

To access or change the value of a control, use its `value` property.


The following example creates a Toggle control and a Button control. When you click the button, the value of the toggle flips.

```csharp
// Create a toggle and register callback
m_MyToggle = new Toggle("Test Toggle") { name = "My Toggle" };
rootVisualElement.Add(m_MyToggle);

// Create button to flip the toggle's value
Button button01 = new Button() { text = "Toggle" };
button01.clicked += () =>
{
    m_MyToggle.value = !m_MyToggle.value;
};
rootVisualElement.Add(button01);
```

### Register a callback
Controls that have `value` properties send an event if the value changes. You can register a callback to receive this event.

The following example creates a Toggle control and registers a callback:

```csharp
// Create a toggle and register callback
m_MyToggle = new Toggle("Test Toggle") { name = "My Toggle" };
m_MyToggle.RegisterValueChangedCallback((evt) => { Debug.Log("Change Event received"); });
rootVisualElement.Add(m_MyToggle);
```

### Apply data binding
You can **bind controls** to an **object** or a **serialized property**. 
For example, you can bind a **FloatField control** to a **public float variable** that belongs to a `MonoBehaviour`. When the control binds to the property, it **automatically displays the value of the property**. When you modify the control, the value of the property updates.


> Not all controls are bindable. 

https://docs.unity3d.com/Manual/UIE-Binding.html


## Apply styles in C# scripts

In a C# script, you can set styles directly to the **`style`** properties of a visual element
. For example, the following code sets the background color of a button to red:

```cs
button.style.backgroundColor = Color.red
```

You can also add a **Unity style sheet (USS)** to any visual element. Unity represents **USS files as `StyleSheet` objects** in C# scripts.

To add style sheets to a visual element:

1.  Load **`StyleSheet`** objects with standard Unity APIs such as **`AssetDatabase.Load()`** or **`Resources.Load()`**.
2.  Use the **`styleSheets`** property of a visual element to add the **`StyleSheet`** object.

For example, given a style sheet in the local variable **`styleSheet`** and an element in the local variable **`element`**, the following example adds the style sheet to the element:

```csharp
element.styleSheets.Add(styleSheet);
```


Eg:
```cs
private void CreateGUI()
{
    // Reference to the root of the window.
    var root = rootVisualElement;

    // Associates a stylesheet to our root. Thanks to inheritance, all root’s
    // children will have access to it.
    root.styleSheets.Add(Resources.Load<StyleSheet>(Path));

    ...
}
```


> **Note**: Style rules apply to the visual element and all its descendants, but don’t apply to the parent or siblings of the element. Any change to the USS file automatically refreshes the UI
 that uses this style sheet.


### ref 
https://docs.unity3d.com/Manual/UIE-manage-asset-reference.html

https://docs.unity3d.com/Manual/UIE-Controls.html

https://docs.unity3d.com/Manual/UIE-apply-styles-with-csharp.html

**`UnityEngine.UIElements` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEngine.UIElements.html

**`UnityEditor.UIElements` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEditor.UIElements.html


**`UIDocument` class** \
https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEngine.UIElements.UIDocument.html
