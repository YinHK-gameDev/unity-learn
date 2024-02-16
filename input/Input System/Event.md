## Events

### Event System

- **`IPointerEnterHandler`** - **`OnPointerEnter`** - Called when a pointer enters the object

- **`IPointerExitHandler`** - **`OnPointerExit`** - Called when a pointer exits the object

- **`IPointerDownHandler`** - **`OnPointerDown`** - Called when a pointer is pressed on the object

- **`IPointerUpHandler`** - **`OnPointerUp`** - Called when a pointer is released (called on the GameObject that the pointer is clicking)

- **`IPointerClickHandler`** - **`OnPointerClick`** - Called when a pointer is pressed and released on the same object

- **`IInitializePotentialDragHandler`** - **`OnInitializePotentialDrag`** - Called when a drag target is found, can be used to initialize values

- **`IBeginDragHandler`** - **`OnBeginDrag`** - Called on the drag object when dragging is about to begin

- **`IDragHandler`** - **`OnDrag`** - Called on the drag object when a drag is happening

- **`IEndDragHandler`** - **`OnEndDrag`** - Called on the drag object when a drag finishes

- **`IDropHandler`** - **`OnDrop`** - Called on the object where a drag finishes

- **`IScrollHandler`** - **`OnScroll`** - Called when a mouse wheel scrolls

- **`IUpdateSelectedHandler`** - **`OnUpdateSelected`** - Called on the selected object each tick

- **`ISelectHandler**` - **`OnSelect`** - Called when the object becomes the selected object

- **`IDeselectHandler`** - **`OnDeselect`** - Called on the selected object becomes deselected

- **`IMoveHandler`** - **`OnMove`** - Called when a move event occurs (left, right, up, down)

- **`ISubmitHandler`** - **`OnSubmit`** - Called when the submit button is pressed

- **`ICancelHandler`** - **`OnCancel`** - Called when the cancel button is pressed

### InputAction Events

- **canceled** \
  Event that is triggered when the action has been started **but then canceled** before being fully performed.
  ```cs
    public event Action<InputAction.CallbackContext> canceled
  ```
  ```cs
    InputAction.canceled += eventHandeler 
  ```
- **performed** \
  Event that is triggered when the action has been fully performed.
  ```cs
    public event Action<InputAction.CallbackContext> performed
  ```
  ```cs
    InputAction.performed += eventHandeler 
  ```

- **started** \
  Event that is triggered when the action has been started.
  ```cs
    public event Action<InputAction.CallbackContext> started
  ```
  ```cs
    InputAction.started += eventHandeler 
  ```

### ref 
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Events.html

https://onewheelstudio.com/blog/2022/4/15/input-event-handlers-or-adding-juice-the-easy-way

**`UnityEngine.InputSystem.InputAction`** \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/api/UnityEngine.InputSystem.InputAction.html#events

**`UnityEngine.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.EventSystems.html

**UI Events reference** \
https://docs.unity3d.com/Manual/UIE-Events-Reference.html

