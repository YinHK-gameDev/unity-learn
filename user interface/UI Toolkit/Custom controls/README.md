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

### ref 
https://docs.unity3d.com/Manual/UIE-custom-controls.html

https://docs.unity3d.com/Manual/UIE-create-custom-controls.html

https://docs.unity3d.com/Manual/UIE-expose-custom-control-to-uxml.html

https://docs.unity3d.com/Manual/UIE-custom-tag-name-and-attributes.html
