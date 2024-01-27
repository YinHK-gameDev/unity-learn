## Runtime UI

You can create a **runtime UI** and display it in a game view by the following steps:

- Create a UI Document (**`.uxml`**) with controls.
- Add a **UIDocument GameObject** in the scene and add the **UXML file** as the source asset for it.
- Create **`MonoBehaviours`** to define the behavior of your UI controls.


### Example
#### Create a UI Document with controls
Create a UI Document with a label, a button, and a Toggle.

1.   Create a project in Unity Editor with any template.
    
2.   Create a UI Document named **`SimpleRuntimeUI.uxml`** with the following contents:
    
     ```xml
      <ui:UXML xmlns:ui="UnityEngine.UIElements" xmlns:uie="UnityEditor.UIElements"
            xsi="http://www.w3.org/2001/XMLSchema-instance" engine="UnityEngine.UIElements"      editor="UnityEditor.UIElements"
            noNamespaceSchemaLocation="../UIElementsSchema/UIElements.xsd" editor-extension-mode="False">
        <ui:VisualElement style="flex-grow: 1;">
            <ui:Label text="This is a Label" display-tooltip-when-elided="true"/>
            <ui:Button text="This is a Button" display-tooltip-when-elided="true" name="button"/>
            <ui:Toggle label="Display the counter?" name="toggle"/>
            <ui:TextField picking-mode="Ignore" label="Text Field" text="filler text" name="input-message" />
        </ui:VisualElement>
      </ui:UXML>
     ```
#### Set up the scene
Create a UIDocument **GameObject** in the SampleScene and add the UI Document as the source asset.
 
1. In the SampleScene, select **GameObject** > **UI Toolkit** > **UI Document**. This creates the following:
    -  A UI Toolkit folder with a default **Panel Settings asset** and a **default runtime theme**. (You can change panel asset or use own customed panel setting asset in panel settings field)
    -  A GameObject with a UI Document component attached, and the **UI Document component** is connected to the **Panel Settings asset**.
2. Select the **UIDocument GameObject** in the hierarchy and drag **`SimpleRuntimeUI.uxml`** from your Project window to the **Source Asset** field of the UI Document component in the Inspector window. 

### Panel settings
Defines a Panel Settings asset that instantiates a panel at runtime. The panel makes it possible for Unity to display UXML-file based UI in the Game view.



#### Define the behavior of your UI controls
To add logic, create a companion script that derives from **`MonoBehaviour`** to access the controls that the UI Document component references.

Unity loads a UI Document component’s source UXML when **`OnEnable`** is called on the component. To ensure the visual tree is loaded correctly, add logic to interact with the controls inside the **`OnEnable`** method.

1. Create a C# script named **`SimpleRuntimeUI.cs`** with the following contents:
    ```csharp
    using UnityEngine;
    using UnityEngine.UIElements;
    
    public class SimpleRuntimeUI : MonoBehaviour
    {
        private Button _button;
        private Toggle _toggle;
    
        private int _clickCount;
    
        //Add logic that interacts with the UI controls in the `OnEnable` methods
        private void OnEnable()
        {
            // The UXML is already instantiated by the UIDocument component
            var uiDocument = GetComponent<UIDocument>();
    
            _button = uiDocument.rootVisualElement.Q("button") as Button;
            _toggle = uiDocument.rootVisualElement.Q("toggle") as Toggle;
    
            _button.RegisterCallback<ClickEvent>(PrintClickMessage);
    
            var _inputFields = uiDocument.rootVisualElement.Q("input-message");
            _inputFields.RegisterCallback<ChangeEvent<string>>(InputMessage);
        }
    
        private void OnDisable()
        {
            _button.UnregisterCallback<ClickEvent>(PrintClickMessage);
        }
    
        private void PrintClickMessage(ClickEvent evt)
        {
            ++_clickCount;
    
            Debug.Log($"{"button"} was clicked!" +
                    (_toggle.value ? " Count: " + _clickCount : ""));
        }
    
        public static void InputMessage(ChangeEvent<string> evt)
        {
            Debug.Log($"{evt.newValue} -> {evt.target}");
        }
    }
    ```
 2.  Add **SimpleRuntimeUI.cs** as a component of the UIDocument GameObject.



### Render UI in the Game view

To render UI and react to input from the users in the Game view, **connect the UI Document assets to a Panel Settings asset by a UI Document component**.
 
 
Every UI Document component references a UI Document asset (**`.uxml` file**) that defines the UI and a Panel Settings asset that renders it. You can connect more than one UI Document asset to a single Panel Settings asset.

### Configure a panel
A **Panel Settings** asset defines a **panel** in the Scene. The panel provides the **root visual element**
 that **UI hierarchies are attached to**, and **draws the UI in the Scene at runtime**. 
 
 
**Panel** defines an **area** that will by default stretch to fit it's parent RectTransform dimensions, more likely usable as container of other RectTransforms (could be called panels if these have same setup) that can define other types of UI elements, depending on what UI components you add to these RTs (Image, Button, ScrollRect...).

> **By default panel display fit to the Main camera size.**
 
How you **configure the Panel Settings asset determines how the UI is rendered**. It also determines how the UI reacts to input. For example, the panel that’s visually in the front intercepts clicks from the user before the panels that are visually in the back
 
 
 You can configure the Panel Settings asset to do the following:

-   **Control scale and resolution**
-   **Apply default styles**
-   **Display UI on Render Textures**
-   **Set the panel’s sort order**

To configure a panel:

1.  In your project, select **Assets** > **Create** > **UI Toolkit** > **Panel Settings Asset** to create a Panel Settings asset if you don’t have it.
2.  In the Inspector window of the Panel Settings, configure the **Panel Settings properties**.


### Connect the UI to a panel
A panel can display UI from more than one UI Document asset. Each UI Document has a **Sort Order** property that sets the UI Document rendering order:

-   Child UI Document components are drawn on top of their parent UI Document components.
-   UI Documents components that are at the same level of the hierarchy are rendered in sequence according to their **Sort Order**.


To connect **more than one UI Document asset** to a panel:


1. Select or create a GameObject to host the UI.
2. Select **Component > UI Toolkit > UI Document** to add a UI Document component.
3. In the Inspector window of the UIDocument, do the following:
   - Set the **Panel Settings** to the Panel Settings asset to display the UI.
   - Set the **Source Asset** to the UI Document (**`.uxml` file**) asset that contains the UI you want to display.
   - set the **Sort Order**. UI Document with a smaller number rendered first.
4. Repeat the process for each UI Document asset.

> **Note**: If there are multiple UI documents attached to the same Panel Settings asset, all these documents have a common focus navigation context. If they have distinct Panel Settings, navigation won’t jump automatically from one to the other even if they’re arranged side by side.


### Runtime UI event system

**UI Toolkit** uses an **event system** to handle input and send events to all active panels.
 
### Event system with multiple Panel Settings assets

If the Scene uses more than one Panel Settings asset, the event system sends pointer events to their panels according to their **Sort Order**. A pointer event propagates through the panels until a panel reacts to it.

The first panel that uses an event to affect the focused element becomes the focused panel for the event system. That panel continues to receive keyboard events until another event causes a different panel to become the focused panel.

> **Note**: Stopping an event’s propagation and giving an element focus are two separate things. For example, when you click a button, it stops the propagation and allows only the button to react to being pressed, but it doesn’t prevent the other default actions for the click, such as giving focus to the button or, in general, any focusable element that is clicked.

### Use the event system and the input system with UI Toolkit
When you use UI Toolkit (and uGUI) with different input systems, you need to choose different input module and event system.

The following table describes the required components and settings for each input system usage:

  
| **Usage** | **Required components** | **Active Input Handling** |
| --- | --- | --- |
| **UI Toolkit elements with legacy Input Manager** | Uses the default event system. No scene component is required. | **Input Manager (Old)**. |
| **UI Toolkit elements with Input System package** | An **Input System UI Input Module** and an **Event System** components. | **Input System Package (New)** |
| **UI Toolkit elements and uGUI components with legacy Input Manager** | A **Standalone Input Module** and an **Event System** components. | **Input Manager (Old)** or **Both**. |
| **UI Toolkit elements and uGUI components with Input System package** | An **Input System UI Input Module** and an **Event System** components. | **Input System Package (New)** or **Both** |

_You can find the **Active Input Handling** setting in **Edit** > **Project Settings** > **Player** > **Active Input Handling**._


### Use uGUI with UI Toolkit
You can use UI Toolkit UI Documents and uGUI components at the same time.

When you add your first uGUI element in the Scene, an **Event System** and a **Standalone Input Module** are automatically added to the Scene:

- The **Event System** allows uGUI objects to respond to events.
- The **Standalone Input Module** dispatches events to UI Toolkit elements.

The Event System reads the scene and executes events, whereas the Standalone Input Module interprets the input and requests event execution. You can replace the Standalone Input Module with other input modules. Other input modules change what input is consumed, but all events still go through the Event System to execute.

UI Toolkit uses the sorting order of the Panel and compares it with the sorting order of uGUI canvases and other valid raycast targets, to decide whether pointer events should be sent to a UI Toolkit element or to a uGUI object, or to something else in the scene. Similarly, UI Toolkit sets the Event System’s `currentSelectedGameObject` to make sure that when a UI Toolkit panel wants to get focus, it removes the focus from other uGUI objects, and when a uGUI object becomes selected, UI Toolkit panels automatically lose their focus.

To add the event system manually, select **GameObject** > **UI** > **Event System**.


### Use Input System package
You can use **UI Toolkit** with the **Input System package**:

1. Use the **Package Manager** to install the **Input System** package.
2. Select **Edit > Project Settings > Player**.
3. Set **Active Input Handling** to **Input System Package (New)**.
4. Select **GameObject > UI > Event System**. This adds an **Event System GameObject** that includes a **Standalone Input Module** in the Scene. The module shows an error message along with a button in the Inspector
 window.
5. Select **Replace with InputSystemUIInputModule** to replace the **Standalone Input Module** with the **Input System UI Input Module**. The Input System UI Input Module and its accompanying **Event System** allows the events of both UI Toolkit and uGUI elements to be dispatched correctly.


### ref 
Panel Settings properties reference \
https://docs.unity3d.com/Manual/UIE-Runtime-Panel-Settings.html \
https://docs.unity3d.com/ScriptReference/UIElements.PanelSettings.html

Runtime UI event system \
https://docs.unity3d.com/Manual/UIE-Runtime-Event-System.html

https://docs.unity3d.com/Manual/UIE-get-started-with-runtime-ui.html

https://docs.unity3d.com/Manual/UIE-render-runtime-ui.html

https://docs.unity3d.com/Manual/UIE-Runtime-Panel-Settings.html

https://docs.unity3d.com/Manual/UIE-Runtime-Event-System.html

https://docs.unity3d.com/Manual/UIE-performance-consideration-runtime.html

https://docs.unity3d.com/Manual/UIE-faq-event-and-input-system.html




