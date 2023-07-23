## Event handler for mouse


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


