## LayerMasks

Every GameObject exists on a single layer, but Unity APIs that let you **set which layers the API affect don’t directly use layers**. Instead, they use **layerMasks**.

LayerMask is an integer formatted as a **bitmask** where every **1 represents a layer to includ**e and **every 0 represents a layer to exclude**. 


### Set up a layerMask

**Convert from a layer** \
If you want to convert a layer to a layermask in a script at runtime, use the binary left-shift operator to left-shift 1 by the layer. The result is a layermask that represents the single layer.

```cs
using UnityEngine;

public class LayerExample : MonoBehaviour
{
    [SerializeField] private int layer = 10;
    private int layerAsLayerMask;

    private void Start()
    {
        layerAsLayerMask = (1 << layer);
    }
}
```
### Add a layer to a layerMask
To add a layer to a layermask, use the **logical OR operator** on the original layermask and the layer to add.
```cs
originalLayerMask |= (1 << layerToAdd);
```

### Remove a layer from a layerMask
To remove a layer from a layermask, use the logical AND operator on the original layermask and the bitwise complement of the layer to remove it.
```cs
originalLayerMask &= ~(1 << layerToRemove);
```

### ref
https://docs.unity3d.com/Manual/layers-and-layermasks.html

**Scripting API for LayerMask** \
https://docs.unity3d.com/ScriptReference/LayerMask.html
