## Editor Scripting




### `MenuItem` attribute
The `MenuItem` attribute allows you to add menu items to the main menu and Inspector window context menus.

The `MenuItem` attribute turns any static function into a menu command. Only static functions can use the `MenuItem` attribute.  
  
To create a hotkey, use the following special characters: **%** (ctrl on Windows and Linux, cmd on macOS), **^** (ctrl on Windows, Linux, and macOS), **#** (shift), **&** (alt). If no special modifier key combinations are required, the key can be given after an underscore. For example, to create a menu with the hotkey Shift+Alt+G, use `"MyMenu/Do Something #&g"`. To create a menu with hotkey **G** and no key modifiers pressed, use `"MyMenu/Do Something _g"`.

https://docs.unity3d.com/ScriptReference/MenuItem.html




### `EditorWindow` class
Derive from this class to create an editor window.

Create your own custom editor window that can float free or be docked as a tab, just like the native windows in the Unity interface.

Editor windows are typically opened using a menu item.

https://docs.unity3d.com/ScriptReference/EditorWindow.html

```cs
using UnityEngine;
using UnityEditor;

public class MyWindow : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;    
    
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/My Window")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        MyWindow window = (MyWindow)EditorWindow.GetWindow(typeof(MyWindow));
        window.Show();
    }    
    
    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);        
        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}

```

### ref 
https://learn.unity.com/tutorial/editor-scripting#


