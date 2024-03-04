## Editor 
Derive from this base class to create a custom inspector or editor for your custom object.

### `Editor` class

#### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor-hasUnsavedChanges.html">hasUnsavedChanges</a></td><td class="desc">This property specifies whether the Editor prompts the user to save or discard unsaved changes before the Inspector gets rebuilt.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor-saveChangesMessage.html">saveChangesMessage</a></td><td class="desc">The message that displays to the user if they are prompted to save.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor-serializedObject.html">serializedObject</a></td><td class="desc">A SerializedObject representing the object or objects being inspected.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor-target.html">target</a></td><td class="desc">The object being inspected.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor-targets.html">targets</a></td><td class="desc">An array of all the object being inspected.</td></tr></tbody></table>

#### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.CreateInspectorGUI.html">CreateInspectorGUI</a></td><td class="desc">Implement this method to make a custom UIElements inspector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.DiscardChanges.html">DiscardChanges</a></td><td class="desc">Discards unsaved changes to the contents of the editor.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.DrawDefaultInspector.html">DrawDefaultInspector</a></td><td class="desc">Draws the built-in Inspector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.DrawHeader.html">DrawHeader</a></td><td class="desc">Call this function to draw the header of the editor.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.DrawPreview.html">DrawPreview</a></td><td class="desc">The first entry point for Preview Drawing.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.GetInfoString.html">GetInfoString</a></td><td class="desc">Implement this method to show asset information on top of the asset preview.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.GetPreviewTitle.html">GetPreviewTitle</a></td><td class="desc">Override this method if you want to change the label of the Preview area.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.HasPreviewGUI.html">HasPreviewGUI</a></td><td class="desc">Override this method in subclasses if you implement OnPreviewGUI.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.OnInspectorGUI.html">OnInspectorGUI</a></td><td class="desc">Implement this function to make a custom inspector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.OnInteractivePreviewGUI.html">OnInteractivePreviewGUI</a></td><td class="desc">Implement to create your own interactive custom preview. Interactive custom previews are used in the preview area of the inspector and the object selector.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.OnPreviewGUI.html">OnPreviewGUI</a></td><td class="desc">Creates a custom preview for the preview area of the Inspector, the headers of the primary Editor, and the object selector.You must implement Editor.HasPreviewGUI for this method to be called.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.OnPreviewSettings.html">OnPreviewSettings</a></td><td class="desc">Override this method if you want to show custom controls in the preview header.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.RenderStaticPreview.html">RenderStaticPreview</a></td><td class="desc">Override this method if you want to render a static preview.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.Repaint.html">Repaint</a></td><td class="desc">Redraw any inspectors that shows this editor.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.RequiresConstantRepaint.html">RequiresConstantRepaint</a></td><td class="desc">Checks if this editor requires constant repaints in its current state.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.SaveChanges.html">SaveChanges</a></td><td class="desc">Performs a save action on the contents of the editor.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.UseDefaultMargins.html">UseDefaultMargins</a></td><td class="desc">Override this method in subclasses to return false if you don't want default margins.</td></tr></tbody></table>

#### Protected Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.ShouldHideOpenButton.html">ShouldHideOpenButton</a></td><td class="desc">Returns the visibility setting of the "open" button in the Inspector.</td></tr></tbody></table>

#### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.CreateCachedEditor.html">CreateCachedEditor</a></td><td class="desc">On return previousEditor is an editor for targetObject or targetObjects. The function either returns if the editor is already tracking the objects, or destroys the previous editor and creates a new one.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.CreateCachedEditorWithContext.html">CreateCachedEditorWithContext</a></td><td class="desc">Creates a cached editor using a context object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.CreateEditor.html">CreateEditor</a></td><td class="desc">Make a custom editor for targetObject or targetObjects.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.CreateEditorWithContext.html">CreateEditorWithContext</a></td><td class="desc">Make a custom editor for targetObject or targetObjects with a context object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Editor.htmlEditor.DrawFoldoutInspector.html">DrawFoldoutInspector</a></td><td class="desc">Draws the inspector GUI with a foldout header for target.</td></tr></tbody></table>




Eg:
```cs
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
[CustomEditor(typeof(MyPlayer))]
public class MyPlayerEditor : Editor
{
    const string resourceFilename = "custom-editor-uie";
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement customInspector = new VisualElement();
        var visualTree = Resources.Load(resourceFilename) as VisualTreeAsset;
        visualTree.CloneTree(customInspector);
        customInspector.styleSheets.Add(Resources.Load($"{resourceFilename}-style") as StyleSheet);
        return customInspector;
    }
}
```


### `EditorWindow` class
Derive from this class to create an editor window.

Create your own custom editor window that can float free or be docked as a tab, just like the native windows in the Unity interface.

Editor windows are typically opened using a menu ite

```cs
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MyEditorWindow : EditorWindow
{
    [MenuItem("Examples/My Editor Window")]
    public static void ShowExample()
    {
        MyEditorWindow wnd = GetWindow<MyEditorWindow>();
        wnd.titleContent = new GUIContent("MyEditorWindow");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy
        Label label = new Label("Hello World!");
        root.Add(label);

        // Create button
        Button button = new Button();
        button.name = "button";
        button.text = "Button";
        root.Add(button);

        // Create toggle
        Toggle toggle = new Toggle();
        toggle.name = "toggle";
        toggle.label = "Toggle";
        root.Add(toggle);
    }
}
```

| Static Properties | Descriptions |
| --- | --- |
| `focusedWindow` | The EditorWindow which currently has keyboard focus. (Read Only) |
| `mouseOverWindow` | The EditorWindow currently under the mouse cursor. (Read Only) |


| Properties | Descriptions |
| --- | --- |
| `autoRepaintOnSceneChange` | Enable this property to automatically repaint the window when the SceneView is modified. |
| `dataModeController` | An instance of IDataModeController to handle DataMode functionalities for the current window. |
| `docked` | Returns true if EditorWindow is docked. |
| `hasFocus` | Returns true if EditorWindow is focused. |
| `hasUnsavedChanges` | This property specifies whether the Editor prompts the user to save or discard unsaved changes before the window closes. |
| `maximized` | Whether or not this window is maximized? |
| `maxSize` | The maximum size of this window when it is floating or modal. The maximum size is not used when the window is docked. |
| `minSize` | The minimum size of this window when it is floating or modal. The minimum size is not used when the window is docked. |
| `overlayCanvas` | The OverlayCanvas for this window. |
| `position` | The desired position of the window in screen space. |
| `rootVisualElement` | Retrieves the root visual element of this window hierarchy. |
| `saveChangesMessage` | The message that displays to the user if they are prompted to save |
| `titleContent` | The GUIContent used for drawing the title of EditorWindows. |
| `wantsLessLayoutEvents` | Specifies whether a layout pass is performed before all user events (for example, EventType.MouseDown or EventType.KeyDown), or is only performed before repaint events. |
| `wantsMouseEnterLeaveWindow` | Checks whether MouseEnterWindow and MouseLeaveWindow events are received in the GUI in this Editor window. |
| `wantsMouseMove` | Checks whether MouseMove events are received in the GUI in this Editor window. |


| Public Methods | Descriptions |
| --- | --- |
| `BeginWindows` | Mark the beginning area of all popup windows. |
| `Close` | Close the editor window. |
| `DiscardChanges` | Discards unsaved changes to the contents of the window. |
| `EndWindows` | Close a window group started with EditorWindow.BeginWindows. |
| `Focus` | Moves keyboard focus to another EditorWindow. |
| `GetExtraPaneTypes` | Gets the extra panes associated with the window. |
| `RemoveNotification` | Stop showing notification message. |
| `Repaint` | Make the window repaint. |
| `SaveChanges` | Performs a save action on the contents of the window. |
| `SendEvent` | Sends an Event to a window. |
| `Show` | Show the EditorWindow window. |
| `ShowAsDropDown` | Shows a window with dropdown behaviour and styling. |
| `ShowAuxWindow` | Show the editor window in the auxiliary window. |
| `ShowModal` | Show modal editor window. |
| `ShowModalUtility` | Shows the EditorWindow as a floating modal window. |
| `ShowNotification` | Show a notification message. |
| `ShowPopup` | Shows an Editor window using popup-style framing. |
| `ShowTab` | Shows a docked Editor window. |
| `ShowUtility` | Show the EditorWindow as a floating utility window. |
| `TryGetOverlay` | Get an Overlay with matching ID from an EditorWindow canvas. |


| Protected Methods | Descriptions |
| --- | --- |
| `OnBackingScaleFactorChanged` | Called when the UI scaling for this EditorWindow is changed. |


| Static Methods | Descriptions |
| --- | --- |
| `CreateWindow` | Creates an EditorWindow of type T. |
| `FocusWindowIfItsOpen` | Focuses the first found EditorWindow of specified type if it is open. |
| `GetWindow` | Returns the first EditorWindow of type windowType which is currently on the screen. |
| `GetWindowWithRect` | Returns the first EditorWindow of type t which is currently on the screen. |
| `HasOpenInstances` | Checks if an editor window is open. |


### ref 
**Editor** \
https://docs.unity3d.com/ScriptReference/Editor.html

**EditorWindow** \
https://docs.unity3d.com/ScriptReference/EditorWindow.html
