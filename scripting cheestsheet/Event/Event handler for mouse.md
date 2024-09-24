## Event handler for mouse

In **Monoheaviour** class, there are some event handling for mouse

### `MonoBehaviour.OnMouseDown()`
**`OnMouseDown`** is called when the user has pressed the mouse button while over the GUIElement or Collider.
```cs
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
    }
}
```



### `MonoBehaviour.OnMouseUp()`
**`OnMouseUp`** is called when the user has released the mouse button.

```cs
// Register when mouse dragging has ended. OnMouseUp is called
// when the mouse button is released.

using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void OnMouseUp()
    {
        // If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Drag ended!");
    }
}
```

### `MonoBehaviour.OnMouseEnter()`
Called when the mouse enters the Collider.


### `MonoBehaviour.OnMouseExit()`
Called when the mouse is not any longer over the Collider.


### `MonoBehaviour.OnMouseOver()`
Called every frame while the mouse is over the Collider.


### `MonoBehaviour.OnMouseDrag()`
**`OnMouseDrag`** is called when the user has clicked on a Collider and is still holding down the mouse.







