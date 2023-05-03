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



### Best practices for custom controls


#### Implement behaviors
You should implement behaviors from your element with default actions. You can call `PreventDefault()` in a callback attached to an instance to cancel default element behaviors.

Additional benefits of implementing behaviors as default actions are:

-   Default actions don’t require a lookup in the callback registry.
-   Instances without callbacks don’t enter the propagation process.

For greater flexibility, you can execute default actions of the event target at two moments during the event dispatch process:

-   Between the trickle-down and the bubble-up propagation phase, immediately after execution of the target callbacks, override `ExecuteDefaultActionsAtTarget()`.
-   At the end of the event dispatch process, override `ExecuteDefaultActions()`.



#### Default actions on a class

Implement your class default actions in `ExecuteDefaultActions()`, if possible. This allows more options to override the class. You can call `PreventDefault()` to override the class during the trickle-down phase or the bubble-up phase of the event propagation process.

You must stop propagation of an event during a default action if the event shouldn’t propagate to the parent element. For example, a text field receives a `KeyDownEvent` that modifies its value, such as the `Delete` key to delete content. This event must not propagate to the parent visual element. Use `ExecuteDefaultActionsAtTarget()` to implement a default action, and call `StopPropagation()` to make sure the event isn’t processed during the bubble-up phase.

Default actions only execute for an event target. For a class to react to events that target their child or parent elements, you must register a callback to receive the event either during the trickle-down or the bubble-up propagation phase. Avoid registering callbacks in your class to improve performance.


#### Stop event propagation and cancel default actions

When handling an event inside a callback or a default action, you can stop further event propagation and the execution of default actions. For example, a parent panel could stop propagation during the trickle-down phase to prevent its children from receiving events.

You can’t prevent the execution of the `EventBase.PreDispatch()` and `EventBase.PostDispatch()` methods inside the event class itself.

The following methods affect event propagation and default actions:

-   `StopImmediatePropagation()`: Stops the event propagation process immediately, so no other callbacks execute for the event. However, the `ExecuteDefaultActionAtTarget()` and `ExecuteDefaultAction()` default actions still execute.
-   `StopPropagation()`: Stops the event propagation process after the last callback on the current element. This ensures that all callbacks execute on the current element, but no further elements react to the event. The `ExecuteDefaultActionAtTarget()` and `ExecuteDefaultAction()` default actions still execute.
-   `PreventDefaultAction()`: Prevents the event propagation process from calling the `ExecuteDefaultActionAtTarget()` and `ExecuteDefaultAction()` default actions. `PreventDefaultAction()` doesn’t prevent the execution of other callbacks and doesn’t affect the `ExecuteDefaultActionAtTarget()` action during the bubble-up phase.






### ref 
https://docs.unity3d.com/Manual/UIE-custom-controls.html

https://docs.unity3d.com/Manual/UIE-create-custom-controls.html

https://docs.unity3d.com/Manual/UIE-expose-custom-control-to-uxml.html

https://docs.unity3d.com/Manual/UIE-custom-tag-name-and-attributes.html

https://docs.unity3d.com/Manual/UIE-Events-Handling.html


