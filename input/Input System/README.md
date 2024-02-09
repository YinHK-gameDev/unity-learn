## Input System
The Input System package allows your users to control your game or app using a device, touch, or gestures.


> Unity supports input through **two separate systems**, **one older**, and **one newer**.

> The older system, which is built-in to the editor, is called the **Input Manager**. The Input Manager is part of the core Unity platform and is the **default**, if you do not install this Input System Package.

> This **Input System package** is a newer, **more flexible system**, which allows you to use **any kind of Input Device** to control your Unity content. It's intended to be a replacement for Unity's classic Input Manager. It iss referred to as **"The Input System Package"**, or just **"The Input System"**. 

To use **Input System package**, you **must install it into your project** using the **Package Manager**.

### Installing the package
To install the new Input System, open Unity's package manager (menu: **Window > Package Manager**). Select the **Input System** package from the list, then click **Install**.

https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Installation.html



### Basic concepts


![](./img/ConceptsOverview.svg)

| Concept | Description |
| --- | --- |
| User | The person playing your game or using your app, by holding or touching the input device and providing input. |
| Input Device | Often referred to just as a "device" within the context of input. A physical piece of hardware, such as a keyboard, gamepad, mouse, or touchscreen which allows the user to send input into Unity. |
| Controls | The separate individual parts of an input device which each send input values into Unity. For example, a gamepad’s controls comprise multiple buttons, sticks and triggers, and a mouse’s controls include the two X and Y sensors on the underside, and the various buttons and scroll wheels on the top side. |
| Interactions | These describe different ways of using the controls on a device. For example, pressing a button down, releasing a button, a long press, or a double tap. Interactions can be thought of as "patterns of input". The Input System provides ways of identifying and responding to different types of interaction. |
| Actions | These are things a user can do in your game or app as a result of input, regardless of what device or control they use to perform it. Actions generally have conceptual names that you choose to suit your project, and should usually be verbs. For example "Run", "Jump" "Crouch", "Use", "Start", "Quit". The Input System can help you manage and edit your actions, or you can implement them yourself. |
| Action Asset | An **asset type which allows you to define and configure groups of actions as a set**. The Action Asset UI allows you to bind controls, group related actions into Action Maps, and specify which controls belong to different Control Schemes. |
| Embedded Actions | Actions defined directly as fields in your scripts (as opposed to in an Action Asset). These types of action are the same as those defined in an Action Asset, and their inspector UI allows you to bind controls. However, because they’re defined as individual fields in your script, you do not benefit from the Action Asset’s ability to group Actions together into Action Maps and Control Schemes. |
| Binding | A connection defined between an Action and one or more Controls. For example, in a car racing game, pressing the right shoulder button on a controller might be bound to the action "Change Gear Up". The Action Asset and Embedded Actions both provide a similar UI to create and edit bindings. |
| Processor | An operation that the Input System applies to an input value. For example, an "invert" Processor inverts a floating-point value. |
| Phase | The current state of an Interaction, for example, "Started", "Performed", or "Canceled". |
| Control Scheme | Allows you to define mappings of Bindings to different Control Schemes, and to switch your Action Maps between different Control Schemes to enable different subsets of Bindings for your Actions. Control Schemes can have associated Device types, so that the game can automatically enable them for users when using that type of Device. |
| Action Map | A **named collection of Actions**. You can simultaneously enable or disable all Actions in an action map, so it is useful to **group Actions in Action Maps by the context in which they are relevant** (for example: "gameplay"). |

### Input System Workflows
There are multiple ways to use the Input System, and the workflow that’s right for you depends on how quickly you want to get up and running, how flexible you want your input code to be, and whether you prefer to set things up in the Unity Editor, or in code.

- **Directly Reading Device States**:  Your script explicitly refers to device controls and reads the values directly.Can be the fastest way to set up input for one device, but it is the least flexible workflow
- **Using Embedded Actions**: Your script uses the InputAction class directly. The actions display in your script’s inspector, and allow you to configure them in the editor.
- **Using an Actions Asset**: Your script does not define actions directly. Instead your script references an Input Actions asset which defines your actions. The Input Actions window provides a UI to define, configure, and organize all your Actions into useful groupings.
- **Using an Actions Asset and a PlayerInput component**: In addition to using an Actions Asset, the PlayerInput component provides a UI in the inspector to connect actions to event handlers in your script, removing the need for any intermediary code between the Input System and your Action Methods.




### Migrating from the old input system(Input Manager)

https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Migration.html

### ref
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/index.html 

Scripting API \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/api/index.html

**`UnityEngine.InputSystem`** \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/api/UnityEngine.InputSystem.html

https://www.youtube.com/watch?v=HmXU4dZbaMw \
https://www.youtube.com/watch?v=Yjee_e4fICc \
https://www.youtube.com/watch?v=UyUogO2DvwY
