## Multiple cameras
You can have as many cameras in a scene as you like and their views can be combined in different ways, as described below.

- Switching cameras:
  By default, a camera renders its view to cover the whole screen and so only one camera view can be seen at a time (**the visible camera is the one that has the highest value for its depth property**). By disabling one camera and enabling another from a script, you can “cut” from one camera to another to give different views of a scene.
```cs
using UnityEngine;
public class ExampleScript : MonoBehaviour {
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
}
  ```




### ref
https://blog.theknightsofunity.com/using-multiple-unity-cameras-why-this-may-be-important/
