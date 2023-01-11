## LayerMasks

Every GameObject exists on a single layer, but Unity APIs that let you set which layers the API affect don’t directly use layers. Instead, they use layerMasks.

LayerMask is an integer formatted as a **bitmask** where every **1 represents a layer to includ**e and **every 0 represents a layer to exclude**. 



