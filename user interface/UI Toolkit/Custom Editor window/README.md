## Custom Editor window

Custom Editor windows allow you to extend Unity by implementing your own editors and workflows. This guide covers creating an Editor window through code, reacting to user input, making the UI resizable and handling hot-reloading.

You can create Editor windows through **C#** scripts in your project. A custom Editor window is a class that derives from the **`EditorWindow`** class.

Create a new script file **`MyCustomEditor.cs`** under the **Assets/Editor** folder. Paste the following code into the script:

```cs
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MyCustomEditor : EditorWindow
{
   ...
}
```

> This is an **Editor-only** window that includes the **UnityEditor** namespace, so the file must be placed under the **Editor folder**, or inside an **Editor-only** Assembly Definition.


### Create a menu entry to open the window
To open the new Editor window, you must create an entry in the Editor menu.

Add the `MenuItem` attribute to a static method. In this example, the name of the static method is `ShowMyEditor()`.

Inside **`ShowMyEditor()`**, call the **`EditorWindow.GetWindow()`** method to create and display the window. It returns an **`EditorWindow`** object. To set the window title, change the **`EditorWindow.titleContent`** property.

Add the following function inside the **`MyCustomEditor`** class created in the previous step.


```cs
// The MenuItem attribute allows you to add menu items to the main menu and Inspector window context menus.
[MenuItem("Tools/My Custom Editor")]
public static void ShowMyEditor()  
{
  // This method is called when the user selects the menu item in the Editor, the EditorWindow.GetWindow()   // method to create and display the window
  EditorWindow wnd = GetWindow<MyCustomEditor>();
  wnd.titleContent = new GUIContent("My Custom Editor");  // To set the window title, change the EditorWindow.titleContent property.
}

```
> To open your new window in above example by opening it via the Unity Editor menu **Tools > My Custom Editor**.


### Add UI controls to the window
**UI Toolkit** uses the **`CreateGUI`** method to **add controls** to **Editor UI**, and Unity calls the `CreateGUI` method automatically when the window needs to display. This method works the same way as methods such as **`Awake`** or **`Update`**.

You can add UI controls to the UI by adding **visual elements** to the **visual tree**. The **`VisualElement.Add()`** method is used to **add children** to an existing visual element. The **visual tree** of an Editor window is accessed via the **`rootvisualElement`** **property**.


Example: \
To get started, add a **`CreateGUI()`** function to your custom Editor class and add a **"Hello"** label:

```cs
public void CreateGUI()
{
  rootVisualElement.Add(new Label("Hello"));
}
```


### ref 
https://docs.unity3d.com/Manual/UIE-HowTo-CreateEditorWindow.html

https://docs.unity3d.com/ScriptReference/EditorWindow.CreateGUI.html


