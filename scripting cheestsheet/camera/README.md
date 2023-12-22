## Camera

#### `Camera.main`
The first enabled Camera component that is tagged **"MainCamera"** (Read Only).

If there is no enabled Camera component with the "MainCamera" tag, this property is null.

Internally, Unity caches all GameObjects with the "MainCamera" tag. When you access this property, Unity returns the first valid result from its cache. Accessing this property has a small CPU overhead, comparable to calling GameObject.GetComponent. Where CPU performance is important, consider caching this property.

```cs
public static Camera main;
```
Eg:

```cs
//Place this script on a GameObject to switch between the main Camera and your own second Camera on the press of the "L" key
//Place a second Camera in your Scene and assign it as the "Camera Two" in the Inspector.

using UnityEngine;

public class Example : MonoBehaviour
{
    //This is Main Camera in the Scene
    Camera m_MainCamera;
    //This is the second Camera and is assigned in inspector
    public Camera m_CameraTwo;

    void Start()
    {
        //This gets the Main Camera from the Scene
        m_MainCamera = Camera.main;
        //This enables Main Camera
        m_MainCamera.enabled = true;
        //Use this to disable secondary Camera
        m_CameraTwo.enabled = false;
    }

    void Update()
    {
        //Press the L Button to switch cameras
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Check that the Main Camera is enabled in the Scene, then switch to the other Camera on a key press
            if (m_MainCamera.enabled)
            {
                //Enable the second Camera
                m_CameraTwo.enabled = true;

                //The Main first Camera is disabled
                m_MainCamera.enabled = false;
            }
            //Otherwise, if the Main Camera is not enabled, switch back to the Main Camera on a key press
            else if (!m_MainCamera.enabled)
            {
                //Disable the second camera
                m_CameraTwo.enabled = false;

                //Enable the Main Camera
                m_MainCamera.enabled = true;
            }
        }
    }
}
```

### ref
https://docs.unity3d.com/ScriptReference/Camera.html
