## Runtime UI

You can create a **runtime UI** and display it in a game view by the following steps:

- Create a UI Document (**`.uxml`**) with controls.
- Add a UIDocument GameObject in the scene and add the UXML file as the source asset for it.
- Create **`MonoBehaviours`** to define the behavior of your UI controls.


### Example
#### Create a UI Document with controls
Create a UI Document with a label, a button, and a Toggle.

1.   Create a project in Unity Editor with any template.
    
2.   Create a UI Document named `SimpleRuntimeUI.uxml` with the following contents:
    
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
    -  A UI Toolkit folder with a Panel Settings asset and a default runtime theme.
    -  A GameObject with a UI Document component attached, and the **UI Document component** is connected to the **Panel Settings asset**.
2. Select the **UIDocument GameObject** in the hierarchy and drag **`SimpleRuntimeUI.uxml`** from your Project window to the **Source Asset** field of the UI Document component in the Inspector window. 


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

### ref 
https://docs.unity3d.com/Manual/UIE-get-started-with-runtime-ui.html

https://docs.unity3d.com/Manual/UIE-render-runtime-ui.html

https://docs.unity3d.com/Manual/UIE-Runtime-Panel-Settings.html

https://docs.unity3d.com/Manual/UIE-Runtime-Event-System.html

https://docs.unity3d.com/Manual/UIE-performance-consideration-runtime.html

https://docs.unity3d.com/Manual/UIE-faq-event-and-input-system.html




