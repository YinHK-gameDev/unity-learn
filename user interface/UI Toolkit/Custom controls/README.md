## Custom controls
You can create custom controls and implement custom logic for user interface elements. A good custom control is abstract, self-contained, and recurring.

After you have created a custom control, you can style it with USS, add logic to handle events in C#, and expose and use it in UI Builder.


### Create a custom control
To create a custom control, you must create a custom control C# class and initialize it. You can expose it for use in UXML and UI Builder. You can also bind it to data.

Create a C# class derived from the `VisualElement` class or a **subclass** of the `VisualElement` class.

### Initialize a custom control
Custom controls inherit from **`VisualElement`**. A **`VisualElement`** isn’t bound to the lifetime of a GameObject and doesn’t receive any of these callbacks:

-   `Awake()`
-   `OnEnable()`
-   `OnDisable()`
-   `OnDestroy()`


You can initialize a custom control in its constructor. However, if your application needs, you can delay initialization until the custom control is added to the UI. To do this, register a callback for an [`AttachToPanelEvent`](https://docs.unity3d.com/Manual/UIE-create-custom-controls.html../ScriptReference/UIElements.AttachToPanelEvent.html). To detect that your custom control has been removed from the UI, use the [`DetachFromPanelEvent`](https://docs.unity3d.com/Manual/UIE-create-custom-controls.html../ScriptReference/UIElements.DetachFromPanelEvent.html) callback.


```cs
void OnEnable()
{
    var myCustomElement = rootVisualElement.Q(className: "my-custom-element");
    myCustomElement.RegisterCallback<AttachToPanelEvent>(e =>
        { /* do something here when element is added to UI */ });
    myCustomElement.RegisterCallback<DetachFromPanelEvent>(e =>
        { /* do something here when element is removed from UI */ });
}
```

### Respond to events with custom controls

If you’re implementing custom controls, you can respond to UI Toolkit events in two ways:

-   Registering an event callback.
-   Implementing a default action.

How you choose to respond to events depends on the situation.

The differences between callbacks and default actions are:

-   Callbacks must register on instances of the class. Default actions run as virtual functions on the class.
-   Callbacks execute for all visual elements in the propagation path. Default actions run only for the event target.
-   Callbacks might perform additional checks to determine whether they should react to an event. For example, a callback handling a mouse click might check if the element is the target of the event. Default actions can skip this step.
-   Default actions have a slight performance advantage because they don’t require a lookup in the callback registry during the propagation phase.



### Implement a default action

A default action applies to all instances of the class. A class that implements default actions can also have callbacks registered on its instances.

When a class implements a default action, it must derive a new subclass of `VisualElement` and implement either the `ExecuteDefaultActionAtTarget()` method, the `ExecuteDefaultAction()` method, or both.

Default actions execute on each instance of a visual element sub-class when that instance receives an event. To customize default actions, you can override `ExecuteDefaultActionAtTarget()` and `ExecuteDefaultAction()`, as shown in the example below:

```csharp
override void ExecuteDefaultActionAtTarget(EventBase evt)
{
    // Call the base function.
    base.ExecuteDefaultActionAtTarget(evt);

    if (evt.eventTypeId == MouseDownEvent.TypeId())
    {
        // ...
    }
    else if (evt.eventTypeId == MouseUpEvent.TypeId())
    {
        // ...
    }
    // More event types
}
```

Implementing your default actions in `ExecuteDefaultAction()` allows you to stop or prevent the execution of a default action.

If you want the target default action to execute before its parent callback, implement the default actions in `ExecuteDefaultActionAtTarget()`.

You should view default actions as the behaviors that an element type should have when it receives an event. For example, a checkbox should toggle its state in response to a click event. To execute this, you can override a default action virtual function, instead of registering callbacks on all checkboxes.






### ref 
https://docs.unity3d.com/Manual/UIE-custom-controls.html

https://docs.unity3d.com/Manual/UIE-create-custom-controls.html

https://docs.unity3d.com/Manual/UIE-expose-custom-control-to-uxml.html

https://docs.unity3d.com/Manual/UIE-custom-tag-name-and-attributes.html

https://docs.unity3d.com/Manual/UIE-Events-Handling.html


