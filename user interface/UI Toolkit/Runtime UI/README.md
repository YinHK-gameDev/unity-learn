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


### ref 
https://docs.unity3d.com/Manual/UIE-get-started-with-runtime-ui.html

https://docs.unity3d.com/Manual/UIE-render-runtime-ui.html

https://docs.unity3d.com/Manual/UIE-Runtime-Panel-Settings.html

https://docs.unity3d.com/Manual/UIE-Runtime-Event-System.html

https://docs.unity3d.com/Manual/UIE-performance-consideration-runtime.html

https://docs.unity3d.com/Manual/UIE-faq-event-and-input-system.html




