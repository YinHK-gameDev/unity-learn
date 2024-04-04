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


To access the state and values of Exposed Properties, you can use multiple methods in the Visual Effect component. Most of the API methods allow access to the property via the following methods:

-   A `string` property name. This is easy to use, but is the least optimized method.
-   An `int` property ID. To generate this ID from a string property name, use `Shader.PropertyToID(string name)`. This is the most optimized method.
-   The ExposedProperty Helper Class. This combines the ease of use the string property name provides with the efficiency of the integer property ID.

### Checking for exposed properties

You can check if the component's Visual Effect Graph contains a specific exposed property. To do this, you can use the method from the following group that corresponds to the property's type:

-   `HasInt(property)`
-   `HasUInt(property)`
-   `HasBool(property)`
-   `HasFloat(property)`
-   `HasVector2(property)`
-   `HasVector3(property)`
-   `HasVector4(property)`
-   `HasGradient(property)`
-   `HasAnimationCurve(property)`
-   `HasMesh(property)`
-   `HasTexture(property)`
-   `HasMatrix4x4(property)`

For each method, if the Visual Effect Graph contains an exposed property of the correct type with the same name or ID you pass in, the method returns `true`. Otherwise the method returns `false`.


### Getting the values of exposed properties

The component API allows you to get the value of an exposed property in the component's Visual Effect Graph. To do this, you can use the method from the following group that corresponds to the property's type:

-   `GetInt(property)`
-   `GetUInt(property)`
-   `GetBool(property)`
-   `GetFloat(property)`
-   `GetVector2(property)`
-   `GetVector3(property)`
-   `GetVector4(property)`
-   `GetGradient(property)`
-   `GetAnimationCurve(property)`
-   `GetMesh(property)`
-   `GetTexture(property)`
-   `GetMatrix4x4(property)`

For each method, if the Visual Effect Graph contains an exposed property of the correct type with the same name or ID you pass in, the method returns the property's value. Otherwise the method returns the default value for the property type.


### Setting the values of exposed properties

The component API allows you to set the value of an exposed property in the component's Visual Effect Graph. To do this, you can use the method from the following group that corresponds to the property's type:

-   `SetInt(property,value)`
-   `SetUInt(property,value)`
-   `SetBool(property,value)`
-   `SetFloat(property,value)`
-   `SetVector2(property,value)`
-   `SetVector3(property,value)`
-   `SetVector4(property,value)`
-   `SetGradient(property,value)`
-   `SetAnimationCurve(property,value)`
-   `SetMesh(property,value)`
-   `SetTexture(property,value)`
-   `SetMatrix4x4(property,value)`

Each method overrides the value of the corresponding property with the value you pass in.


### rer

https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/ComponentAPI.html

https://docs.unity3d.com/ScriptReference/VFX.VisualEffect.html



