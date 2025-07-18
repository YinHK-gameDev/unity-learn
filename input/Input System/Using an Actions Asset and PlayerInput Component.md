## Using an Actions Asset and Player Input Component

The highest level of abstraction provided by the Input System is when you use the **Actions Asset** and 
the **Player Input component** together.

The **Player Input component** takes a **reference to an Actions Asset**, and 
**provides a way to make connections between the Actions defined in that asset**, and **C# methods in your own MonoBehaviour scripts**, 
so that your desired C# methods are called when the user performs an input action.


![](./img/PlayerInputWithGameplayEvents.png)

In the above example image, you can see the PlayerInput component set up to map the "move", "jump" actions to OnMove and OnJump methods in a script, via Unity Events.

This is an example of the script which would provide an implementation of these methods

```cs
using UnityEngine;
using UnityEngine.InputSystem;

// This script is designed to have the OnMove and
// OnJump methods called by a PlayerInput component

public class ExampleScript : MonoBehaviour
{
    Vector2 moveAmount;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // read the value for the "move" action each event call
        moveAmount = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        // your jump code goes here.
	print("Is jumping!");
	print(context);
	rb.AddForce(Vector3.up * 2f, ForceMode.Impulse);
    }

    public void Update()
    {
        // to use the Vector2 value from the "move" action each
        // frame, use the "moveAmount" variable here.
	transform.Translate(new Vector3(moveAmount.x, 0, moveAmount.y));
    }

}

```


For movement:

```cs
public void Move(InputAction.CallbackContext value)
{
    moveVal = value.ReadValue<Vector2>();
}

public void Update()
{
    transform.Translate(new Vector3(moveAmount.x, 0, moveAmount.y));
}

```


### The Player Input component

The Input System provides two related components that simplify how you set up and work with input: the **Player Input component** and the **Player Input Manager component**.

The **Player Input component** represents a **single player**, and that player's associated **Input Actions**, whereas the **Player Input Manager component** handles setups that allow for** several concurrent users (for example, player lobbies and split-screen gameplay in a game)**.


#### Getting started

To get started using the Player Input component, use the following steps:

1. **Add** a **Player Input** component to a GameObject. This would usually be the GameObject that represents the player in your game.

2. **Create an Input Actions asset**. You can do this by clicking the "Create Actions..." button which is visible in the Player Input component inspector if you have not yet assigned actions to it (shown below).

    ![](./img/PlayerInputCreateActions.png)

3. When creating the actions asset, Unity asks you where to create the new Asset. Choose a name and folder inside the **Assets** folder of your Project (or just accept the defaults) and select Okay. This creates a new **`.inputactions`** Asset in your Project, connects it to the Player Input component, and brings up the editor window for the Input Action asset.

4. **Configure the Actions Asset** so that it contains the actions you want your users to be able to perform, bound to the controls they should use to perform them.

    ![](./img/MyGameActions.png)

5. Set up Action responses, by selecting a **Behaviour** type from the Behaviour menu. The Behaviour type you select affects how you should implement the methods that handle your Action responses. See the **notification behaviors** section further down for details.

    ![](./img/PlayerInputNotificationBehaviors.png)


#### Configuring the Player Input component


You can use the following properties to configure `PlayerInput`:

| Property | Description |
| --- | --- |
| **Actions** | The set of Input Actions associated with the player. To receive input, each player must have an associated set of Actions. See documentation on Actions for details. |
| **Default Control Scheme** | Which Control Scheme (from what is defined in Actions) to enable by default.|
| **Default Action Map** | Which Action Map in Actions to enable by default. If set to None, then the player starts with no Actions being enabled. |
| **Camera** | The individual camera associated with the player. This is only required when employing split-screen setups and has no effect otherwise. |
| **Behavior** | How the PlayerInput component notifies game code about things that happen with the player. See documentation on notification behaviors. |

### Notification behaviors
You can use the Behavior property in the Inspector to determine how a PlayerInput component notifies game code when something related to the player has occurred.

The following options are available:

| Behavior | Description |
| --- | --- |
| **Send Messages** | Uses `GameObject.SendMessage` on the GameObject that the PlayerInput component belongs to. |
| **Broadcast Messages** | Uses `GameObject.BroadcastMessage` on the GameObject that the PlayerInput component belongs to. This broadcasts the message down the GameObject hierarchy. |
| **Invoke Unity Events** | Uses a separate `UnityEvent` for each individual type of message. When this is selected, the events available on the `PlayerInput` are accessible from the Events foldout. The argument received by events triggered for Actions is the same as the one received by started, performed, and canceled callbacks. |
| **Invoke CSharp Events** | Similar to **Invoke Unity Events**, except that the events are plain C# events available on the `PlayerInput` API. You cannot configure these from the Inspector. Instead, you have to register callbacks for the events in your scripts.The following events are available: `onActionTriggered` (collective event for all actions on the player), `onDeviceLost`, `onDeviceRegained` |
 
> **Note**: If using `SendMessage` or `BoardcastMessage` method, just declare a Handler method and name it like "On" + Input Action name, use `InputionValue` as an agruement for the handler method.


> **Note**: If using **Invoke C# Events**, need to add event handler for the events like `Action<InputAction.CallbackContext> canceled` / `Action<InputAction.CallbackContext> performed` / `Action<InputAction.CallbackContext> started`.

#### Use PlayerInput with "Invoke C# Events"
- Set Behavior to Invoke C# Events
- Assign your Input Actions asset
- Enable Auto-Switch
- Ensure your actions are named (eg: Move, Jump etc)


eg: 

```cs
using UnityEngine;
using UnityEngine.InputSystem;

public class MyPlayerInput : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction moveAction;
    private InputAction jumpAction;

    void Awake()
    {
	playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        // Get the actions from the PlayerInput
        moveAction = playerInput.actions["Move"];
        jumpAction = playerInput.actions["Jump"];

        // Subscribe to events
        moveAction.performed += OnMove;
        moveAction.canceled += OnMoveCancel;
        jumpAction.performed += OnJump;
	jumpAction.canceled += OnJumpCancel;
    }

    private void OnDisable()
    {
        // Unsubscribe
        moveAction.performed -= OnMove;
        moveAction.canceled -= OnMoveCancel;
        jumpAction.performed -= OnJump;
        jumpAction.canceled -= OnJumpCancel;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 movement = context.ReadValue<Vector2>();
        Debug.Log("Move: " + movement);
    }

    private void OnMoveCancel(InputAction.CallbackContext context)
    {
        Debug.Log("Move stopped");
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump pressed");
    }

    private void OnJumpCancel(InputAction.CallbackContext context)
    {
        Debug.Log("Jump stopped");
    }
}

```

### ref
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Workflow-PlayerInput.html \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/PlayerInput.html

**`PlayerInput`** \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/api/UnityEngine.InputSystem.PlayerInput.html?q=playerinput#events


https://matteolopiccolo.medium.com/unity-new-input-system-player-input-component-part-xiii-3c83d35b1373 \
https://matteolopiccolo.medium.com/unity-new-input-system-player-input-component-part-xii-17e4b932b544
