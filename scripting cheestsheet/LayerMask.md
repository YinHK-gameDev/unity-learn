## LayerMask
Specifies Layers to use in a **`Physics.Raycast`**.

A GameObject can use up to **32 LayerMasks** supported by the Editor. The **first 8** of these Layers are specified by Unity; the following **24 are controllable by the user**.

LayerMask is an integer formatted as a **bitmask** where every **1 represents a layer to includ**e and **every 0 represents a layer to exclude**.


**Bitmasks** represent the **32 Layers** and define them as **true** or **false**. Each bitmask describes **whether the Layer is used**. 

As an example, bit 5 can be set to 1 (true). This will allow the use of the built-in Water setting.


**Edit > Project Settings > Tags and Layers** option shows the use of the 32 bitmasks. Each `Layer` is shown with a string setting. As an example `Built-in Layer 0` is set as `Default`; `Built-in Layer 1` is set as `TransparentFX`. New named `Layer`s are added above bitmask layer 8. A selected `GameObject` will show the chosen `Layer` at top right of the Inspector. 

The example below has `User Layer 13` set to "Wall". This causes the assigned `GameObject` to be treated as part of a building.

Eg:
```cs
using UnityEngine;

// Fire a gun at 3 walls in the scene.
//
// The Raycast will be aimed in the range of -45 to 45 degrees. If the Ray hits any of the
// walls true will be returned . The three walls all have a Wall Layer attached.  The left
// and right keys, and the space key, are all used to aim and fire.
//
// Quad floor based at (0, -0.5, 0), rotated in x by 90 degrees, scale (8, 8, 8).
// ZCube wall at (0, 0.5, 6), scale (3, 2, 0.5).
// LCube wall at (-3, 0, 3), scale (0.5, 1, 4).
// RCube wall at (3, 1.5, 3), scale (1, 4, 4).

public class ExampleScript : MonoBehaviour
{
    private float cameraRotation;

    void Start()
    {
        Camera.main.transform.position = new Vector3(0, 0.5f, 0);
        cameraRotation = 0.0f;
    }

    // Rotate the camera based on what the user wants to look at.
    // Avoid rotating more than +/-45 degrees.
    void Update()
    {
        if (Input.GetKey("left"))
        {
            cameraRotation -= 1f;
            if (cameraRotation < -45.0f)
            {
                cameraRotation = -45.0f;
            }
        }

        if (Input.GetKey("right"))
        {
            cameraRotation += 1f;
            if (cameraRotation > 45.0f)
            {
                cameraRotation = 45.0f;
            }
        }

        // Rotate the camera
        Camera.main.transform.localEulerAngles = new Vector3(0.0f, cameraRotation, 0.0f);
    }

    void FixedUpdate()
    {
        Transform transform = Camera.main.transform;

        if (Input.GetKeyUp("space"))
        {
            // Check for a Wall.
            LayerMask mask = LayerMask.GetMask("Wall");

            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                Debug.Log("Fired and hit a wall");
            }
        }
    }
}
```

#### `LayerMask.value`
Converts a layer mask value to an integer value

#### `LayerMask.GetMask`
Given a set of layer names as defined by either a Builtin or a User Layer in the Tags and Layers manager, returns the equivalent layer mask for all of them.

#### `LayerMask.NameToLayer`
Given a layer name, returns the layer index as defined by either a Builtin or a User Layer in the Tags and Layers manager.

Returns -1 if not found.



### ref

https://docs.unity3d.com/ScriptReference/LayerMask.html



