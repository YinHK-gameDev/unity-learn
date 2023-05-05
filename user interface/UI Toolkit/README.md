## UI Toolkit

**UI Toolkit is the newest UI system in Unity**. It’s designed to optimize performance across platforms, and is based on standard web technologies.

You can use UI Toolkit to create extensions for the Unity Editor, and to create runtime UI for games and applications.


UI Toolkit is a collection of features, resources, and tools for developing user interface (UI). You can use UI Toolkit to develop custom UI and extensions for the Unity Editor, runtime debugging tools, and runtime UI for games and applications.

UI Toolkit is inspired by standard web technologies. If you have experience developing web pages or applications, your knowledge is transferable and the core concepts are familiar.

UI Toolkit is inspired by standard **web technologies**. If you have experience developing web pages or applications, your knowledge is transferable and the core concepts are familiar.

> **Note**: Unity recommends you to use **UI Toolkit** for your new UI development projects. However, Unity **UI (uGUI)** and **IMGUI** are appropriate for certain use cases, and are required to support deprecated projects.

> If you perform a **specific task** often, you can use UI Toolkit to create a **dedicated UI** for it. For example you can create a **custom Editor window**. The example demonstrates how to create a custom Editor window and add UI controls into your custom Editor window with **UI Builder, UXML, and C# script**.


UI Toolkit includes:

- A retained-mode UI system that contains the core features and functionality required to create user interfaces.
- UI Asset types inspired by standard web formats such as HTML, XML, and CSS. Use them to structure and style UI.
- Tools and resources for learning to use UI Toolkit, and for creating and debugging your interfaces.

### UI system
The core of UI Toolkit is a retained-mode UI system based on recognized web technologies. It supports stylesheets, and dynamic and contextual event handling.

The **UI system** includes the following features:

- **Visual tree**: An object graph, made of lightweight nodes, that holds all the elements in a window or panel. It defines every UI you build with the UI Toolkit.
- **Controls**: A library of standard UI controls such as buttons, popups, list views, and color pickers. You can use them as is, customize them, or create your own controls.
- **Data binding system**: A system links properties to the controls that modify their values.
- **Layout Engine**: A layout system based on the CSS Flexbox model. It positions elements based on layout and styling properties.
- **Event System**: A system communicates user interactions to elements, such as input, touch and pointer interactions, drag-and-drop operations, and other event types. The system includes a dispatcher, a handler, a synthesizer, and a library of event types.
- **UI Renderer**: A rendering system built directly on top of Unity’s graphics device layer.
- **Editor UI support**: A set of components to create Editor UI.
- **Runtime UI Support**: A set of components to create runtime UI.



### UI assets
Use the following asset types to build UI similar to how you develop web applications:

- **UXML documents**: **HTML** and **XML** inspired markup language defines the structure of UI and reusable UI templates. Although you can build interfaces directly in C# files, Unity recommends using UXML documents if possible. 
- **Unity Style Sheets (USS)**: Style sheets apply visual styles and behaviors to UI. They’re similar to **Cascading Style Sheets (CSS) used on the web**, and support a subset of standard CSS properties. Although you can apply styles directly in C# files, Unity recommends using USS files if possible. 


Eg:
```cs
  [SerializeField]
  private VisualTreeAsset uxml;
  
  [SerializeField]
  private StyleSheet uss;
 ```


### UI tools and resources

Use the following tools to create and debug your interfaces, and learn how to use the UI Toolkit:

- **UI Debugger**: \
  A diagnostic tool that resembles a web browser’s debugging view. Use it to explore a hierarchy of elements and get information about its underlying UXML structure and USS styles. You can find it in the Editor under **Window > UI Toolkit > Debugger**.
- **UI Builder**: \
  A UI tool lets you visually create and edit UI Toolkit assets such as UXML and USS files.
- **UI Samples**: \
  A library of code samples for UI controls that you can view in the Editor under **Window > UI Toolkit > Samples**.


### Create a custom Editor window
-   Create a project in Unity Editor with any template.
-   In the Project window, right-click in the `Assets` folder, and then select **Create** > **UI Toolkit** > **Editor Window**.
-   In **UI Toolkit Editor Window Creator**, enter `MyCustomEditor`.
-   Clear the **USS** checkbox.
-   Click **Confirm**.



> This creates a **custom Editor window** with two labels. You can open the Editor window from the menu (**Window** > **UI Toolkit** > **MyCustomEditor**). You can find the source files for it in the `Assets/Editor` folder.


### Add UI controls to the window

You can add **UI controls** into your window in the following ways:

-  Use the **UI Builder** to visually add the UI controls
-  Use an **XML-like** text file (**UXML**) to add the UI controls
-  Use **C#** script to add the UI controls

> You can use any of these methods individually, or combine.






### Define the behavior of your UI controls

You can set up event handlers for your UI controls so that when you click the button, and select or clear the toggle, your UI controls perform some tasks.

In this example, set up event handlers that:

-   When a button is clicked, the Editor Console displays a message.
-   When a toggle is selected, the Console shows how many times the buttons have been clicked.

Your finished `MyCustomEditor.cs` looks like the following:

```cs
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MyCustomEditor : EditorWindow
{
    [MenuItem("Window/UI Toolkit/MyCustomEditor")]
    public static void ShowExample()
    {
        MyCustomEditor wnd = GetWindow<MyCustomEditor>();
        wnd.titleContent = new GUIContent("MyCustomEditor");
    }

    [SerializeField]
    private VisualTreeAsset m_UXMLTree;

    private int m_ClickCount = 0;

    private const string m_ButtonPrefix = "button";

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        Label label = new Label("These controls were created using C# code.");
        root.Add(label);

        Button button = new Button();
        button.name = "button3";
        button.text = "This is button3.";
        root.Add(button);

        Toggle toggle = new Toggle();
        toggle.name = "toggle3";
        toggle.label = "Number?";
        root.Add(toggle);

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/MyCustomEditor.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        root.Add(labelFromUXML);

        root.Add(m_UXMLTree.Instantiate());

        //Call the event handler
        SetupButtonHandler();
    }

    //Functions as the event handlers for your button click and number counts 
    private void SetupButtonHandler()
    {
        VisualElement root = rootVisualElement;

        var buttons = root.Query<Button>();
        buttons.ForEach(RegisterHandler);
    }

    private void RegisterHandler(Button button)
    {
        button.RegisterCallback<ClickEvent>(PrintClickMessage);
    }

    private void PrintClickMessage(ClickEvent evt)
    {
        VisualElement root = rootVisualElement;

        ++m_ClickCount;

        //Because of the names we gave the buttons and toggles, we can use the
        //button name to find the toggle name.
        Button button = evt.currentTarget as Button;
        string buttonNumber = button.name.Substring(m_ButtonPrefix.Length);
        string toggleName = "toggle" + buttonNumber;
        Toggle toggle = root.Q<Toggle>(toggleName);

        Debug.Log("Button was clicked!" +
            (toggle.value ? " Count: " + m_ClickCount : ""));
    }
}
```



### ref
https://learn.unity.com/tutorial/ui-toolkit-first-steps

https://docs.unity3d.com/Manual/UIE-simple-ui-toolkit-workflow.html#use-uxml

https://docs.unity3d.com/Manual/UIElements.html

https://www.youtube.com/watch?v=J2KNj3bw0Bw

https://www.youtube.com/watch?v=VxpydMOgkGU

https://www.youtube.com/watch?v=BG6NCgkbbiA

https://www.youtube.com/watch?v=NQYHIH0BJbs


