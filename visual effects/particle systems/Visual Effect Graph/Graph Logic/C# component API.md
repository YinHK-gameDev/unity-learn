## C# component API

To create an instance of a Visual Effect Graph in a Scene, 
Unity uses the Visual Effect component. 

The Visual Effect component attaches to GameObjects in your Scene and references a Visual Effect Graph which defines the visual effect. 

This allows you to create different instances of effects at various positions and orientations, and control each effect independently. To control an effect at runtime, Unity provides C# API that you can use to modify the Visual Effect component and set Property overrides.


### Controlling play state
You can use the API to control effect playback.

#### Common controls

   **Play** : `effect.Play()` or `effect.Play(eventAttribute)` if needing Event Attributes.
-   **Stop** : `effect.Stop()` or `effect.Stop(eventAttribute)` if needing Event Attributes.
-   **Pause** : `effect.pause = true` or `effect.pause = false`. Unity does not serialize this change.
-   **Step** : `effect.AdvanceOneFrame()`. This only works if `effect.pause` is set to `true`.
-   **Reset Effect** : `effect.Reinit()` this also :
    -   Resets `TotalTime` to 0.0f.
    -   Re-sends the **Default Event** to the Visual Effect Graph.
-   **Play Rate** : `effect.playRate = value`. Unity does not serialize this change.


### Default Event

When the Visual Effect component (or the GameObject it attaches to) enables, it sends an Event to the graph. By default, this Event is OnPlay which is the standard start for Spawn Contexts.

You can **change the default Event** in the following ways:

- On the **Visual Effect Inspector**, **change the Initial Event Name** field.
- In the component API : **`initialEventName = "MyEventName";`**.
- In the component API : **`initialEventID = Shader.PropertyToID("MyEventName");`**.
- Using the **ExposedProperty Helper Class**.




### rer

https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/ComponentAPI.html

https://docs.unity3d.com/ScriptReference/VFX.VisualEffect.html



