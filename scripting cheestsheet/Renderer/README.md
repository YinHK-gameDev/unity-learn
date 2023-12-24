## Renderer
General functionality for all renderers.

A renderer is what **makes an object appear on the screen**. Use this class to access the renderer of any object, mesh or Particle System. Renderers can be disabled to make objects invisible (**`Renderer.enabled`**), and the materials can be accessed and modified through them (**`Renderer.material`**).

### `Renderer.isVisible`
Is this renderer visible in any camera? (Read Only)

```cs
public bool isVisible;
```
https://docs.unity3d.com/ScriptReference/Renderer-isVisible.html

### `Renderer.enabled`
Makes the rendered 3D object **visible if enabled**.

```cs
public bool enabled;
```
```cs
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Toggle the Object's visibility each second.
    void Update()
    {
        // Find out whether current second is odd or even
        bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;

        // Enable renderer accordingly
        rend.enabled = oddeven;
    }
}
```

#### `Renderer.material`
Returns the first instantiated Material assigned to the renderer.
```cs
public Material material;
```


#### `Renderer.materials`
Returns all the instantiated materials of this object.

```cs
public Material[] materials;
```


### ref 
https://docs.unity3d.com/ScriptReference/Renderer.html
