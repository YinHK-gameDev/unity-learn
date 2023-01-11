## LayerMasks

Every GameObject exists on a single layer, but Unity APIs that let you set which layers the API affect don’t directly use layers. Instead, they use **layerMasks**.

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





