## LayerMasks

Every GameObject exists on a single layer, but Unity APIs that let you **set which layers the API affect don’t directly use layers**. Instead, they use **layerMasks**.

> Specifies Layers to use in a **`Physics.Raycast`**.

A layer is a standard integer, but a LayerMask is an integer formatted as a **bitmask** where every **1 represents a layer to includ**e and **every 0 represents a layer to exclude**. 

his means that you can pass a layer to an API that expects a layerMasks and the script will still compile because layers and layerMasks use the same underlying type. However, the API call won’t produce the behavior you expect.

For example, if you want to perform a **`RayCast`** against GameObjects on layer 9, if you pass `9` into the **`Physics.Raycast`** call as the layerMask, Unity actually performs the ray cast against GameObjects on layers `3` and `0`. This is because the binary representation of 9 is `00001001` and if you interpret this as a mask, the `1`s are in the place of layers `3` and `0`.

### Set up a layerMask

**Convert from a layer** \
If you want to **convert a layer to a layermask in a script at runtime**, use the **binary left-shift operator** to **left-shift 1** by the layer. The result is a layermask that represents the single layer.

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
