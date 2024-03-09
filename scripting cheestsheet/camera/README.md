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

| Static Properties | Descriptions |
| --- | --- |
| allCameras | Returns all enabled cameras in the Scene. |
| allCamerasCount | The number of cameras in the current Scene. |
| current | The camera we are currently rendering with, for low-level render control only (Read Only). |
| kMaxAperture | The maximum allowed aperture. |
| kMaxBladeCount | The maximum blade count for the aperture diaphragm. |
| kMinAperture | The minimum allowed aperture. |
| kMinBladeCount | The minimum blade count for the aperture diaphragm. |
| main | The first enabled Camera component that is tagged "MainCamera" (Read Only). |
| onPostRender | Delegate that you can use to execute custom code after a Camera renders the scene. |
| onPreCull | Delegate that you can use to execute custom code before a Camera culls the scene. |
| onPreRender | Delegate that you can use to execute custom code before a Camera renders the scene. |


| Properties | Descriptions |
| --- | --- |
| activeTexture | Gets the temporary RenderTexture target for this Camera. |
| actualRenderingPath | The rendering path that is currently being used (Read Only). |
| allowDynamicResolution | Dynamic Resolution Scaling. |
| allowHDR | High dynamic range rendering. |
| allowMSAA | MSAA rendering. |
| anamorphism | The camera anamorphism. To use this property, enable UsePhysicalProperties. |
| aperture | The camera aperture. To use this property, enable UsePhysicalProperties. |
| areVRStereoViewMatricesWithinSingleCullTolerance | Determines whether the stereo view matrices are suitable to allow for a single pass cull. |
| aspect | The aspect ratio (width divided by height). |
| backgroundColor | The color with which the screen will be cleared. |
| barrelClipping | The camera barrel clipping. To use this property, enable UsePhysicalProperties. |
| bladeCount | The blade count in the lens of the camera. To use this property, enable UsePhysicalProperties. |
| cameraToWorldMatrix | Matrix that transforms from camera space to world space (Read Only). |
| cameraType | Identifies what kind of camera this is, using the CameraType enum. |
| clearFlags | How the camera clears the background. |
| clearStencilAfterLightingPass | Should the camera clear the stencil buffer after the deferred light pass? |
| commandBufferCount | Number of command buffers set up on this camera (Read Only). |
| cullingMask | This is used to render parts of the Scene selectively. |
| cullingMatrix | Sets a custom matrix for the camera to use for all culling queries. |
| curvature | The curvature of the blades. To use this property, enable UsePhysicalProperties. |
| depth | Camera's depth in the camera rendering order. |
| depthTextureMode | How and if camera generates a depth texture. |
| eventMask | Mask to select which layers can trigger events on the camera. |
| farClipPlane | The distance of the far clipping plane from the Camera, in world units. |
| fieldOfView | The vertical field of view of the Camera, in degrees. |
| focalLength | The camera focal length, expressed in millimeters. To use this property, enable UsePhysicalProperties. |
| focusDistance | The focus distance of the lens. To use this property, enable UsePhysicalProperties. |
| forceIntoRenderTexture | Should camera rendering be forced into a RenderTexture. |
| gateFit | There are two gates for a camera, the sensor gate and the resolution gate. The physical camera sensor gate is defined by the sensorSize property, the resolution gate is defined by the render target area. |
| iso | The sensor sensitivity of the camera. To use this property, enable UsePhysicalProperties. |
| layerCullDistances | Per-layer culling distances. |
| layerCullSpherical | How to perform per-layer culling for a Camera. |
| lensShift | The lens offset of the camera. The lens shift is relative to the sensor size. For example, a lens shift of 0.5 offsets the sensor by half its horizontal size. |
| nearClipPlane | The distance of the near clipping plane from the the Camera, in world units. |
| nonJitteredProjectionMatrix | Get or set the raw projection matrix with no camera offset (no jittering). |
| opaqueSortMode | Opaque object sorting mode. |
| orthographic | Is the camera orthographic (true) or perspective (false)? |
| orthographicSize | Camera's half-size when in orthographic mode. |
| overrideSceneCullingMask | Sets the culling mask used to determine which objects from which Scenes to draw. See EditorSceneManager.SetSceneCullingMask. |
| pixelHeight | How tall is the camera in pixels (not accounting for dynamic resolution scaling) (Read Only). |
| pixelRect | Where on the screen is the camera rendered in pixel coordinates. |
| pixelWidth | How wide is the camera in pixels (not accounting for dynamic resolution scaling) (Read Only). |
| previousViewProjectionMatrix | Get the view projection matrix used on the last frame. |
| projectionMatrix | Set a custom projection matrix. |
| rect | Where on the screen is the camera rendered in normalized coordinates. |
| renderingPath | The rendering path that should be used, if possible. |
| scaledPixelHeight | How tall is the camera in pixels (accounting for dynamic resolution scaling) (Read Only). |
| scaledPixelWidth | How wide is the camera in pixels (accounting for dynamic resolution scaling) (Read Only). |
| scene | If not null, the camera will only render the contents of the specified Scene. |
| sensorSize | The size of the camera sensor, expressed in millimeters. |
| shutterSpeed | The exposure time of the camera, in seconts. To use this property, enable UsePhysicalProperties. |
| stereoActiveEye | Returns the eye that is currently rendering. If called when stereo is not enabled it will return Camera.MonoOrStereoscopicEye.Mono. If called during a camera rendering callback such as OnRenderImage it will return the currently rendering eye. If called outside of a rendering callback and stereo is enabled, it will return the default eye which is Camera.MonoOrStereoscopicEye.Left. |
| stereoConvergence | Distance to a point where virtual eyes converge. |
| stereoEnabled | Stereoscopic rendering. |
| stereoSeparation | The distance between the virtual eyes. Use this to query or set the current eye separation. Note that most VR devices provide this value, in which case setting the value will have no effect. |
| stereoTargetEye | Defines which eye of a VR display the Camera renders into. |
| targetDisplay | Set the target display for this Camera. |
| targetTexture | Destination render texture. |
| transparencySortAxis | An axis that describes the direction along which the distances of objects are measured for the purpose of sorting. |
| transparencySortMode | Transparent object sorting mode. |
| useJitteredProjectionMatrixForTransparentRendering | Should the jittered matrix be used for transparency rendering? |
| useOcclusionCulling | Whether or not the Camera will use occlusion culling during rendering. |
| usePhysicalProperties | Enable usePhysicalProperties to use physical camera properties to compute the field of view and the frustum. |
| velocity | Get the world-space speed of the camera (Read Only). |
| worldToCameraMatrix | Matrix that transforms from world to camera space. |


| Public Methods | Descriptions |
| --- | --- |
| AddCommandBuffer | Add a command buffer to be executed at a specified place. |
| AddCommandBufferAsync | Adds a command buffer to the GPU's async compute queues and executes that command buffer when graphics processing reaches a given point. |
| CalculateFrustumCorners | Given viewport coordinates, calculates the view space vectors pointing to the four frustum corners at the specified camera depth. |
| CalculateObliqueMatrix | Calculates and returns oblique near-plane projection matrix. |
| CopyFrom | Makes this camera's settings match other camera. |
| CopyStereoDeviceProjectionMatrixToNonJittered | Sets the non-jittered projection matrix, sourced from the VR SDK. |
| GetCommandBuffers | Get command buffers to be executed at a specified place. |
| GetGateFittedFieldOfView | Retrieves the effective vertical field of view of the camera, including GateFit. Fitting the sensor gate and the resolution gate has an impact on the final field of view. If the sensor gate aspect ratio is the same as the resolution gate aspect ratio or if the camera is not in physical mode, then this method returns the same value as the fieldofview property. |
| GetGateFittedLensShift | Retrieves the effective lens offset of the camera, including GateFit. Fitting the sensor gate and the resolution gate has an impact on the final obliqueness of the projection. If the sensor gate aspect ratio is the same as the resolution gate aspect ratio, then this method returns the same value as the lenshift property. If the camera is not in physical mode, then this methods returns Vector2.zero. |
| GetStereoNonJitteredProjectionMatrix | Gets the non-jittered projection matrix of a specific left or right stereoscopic eye. |
| GetStereoProjectionMatrix | Gets the projection matrix of a specific left or right stereoscopic eye. |
| GetStereoViewMatrix | Gets the left or right view matrix of a specific stereoscopic eye. |
| RemoveAllCommandBuffers | Remove all command buffers set on this camera. |
| RemoveCommandBuffer | Remove command buffer from execution at a specified place. |
| RemoveCommandBuffers | Remove command buffers from execution at a specified place. |
| Render | Render the camera manually. |
| RenderToCubemap | Render into a static cubemap from this camera. |
| RenderWithShader | Render the camera with shader replacement. |
| Reset | Revert all camera parameters to default. |
| ResetAspect | Revert the aspect ratio to the screen's aspect ratio. |
| ResetCullingMatrix | Make culling queries reflect the camera's built in parameters. |
| ResetProjectionMatrix | Make the projection reflect normal camera's parameters. |
| ResetReplacementShader | Remove shader replacement from camera. |
| ResetStereoProjectionMatrices | Reset the camera to using the Unity computed projection matrices for all stereoscopic eyes. |
| ResetStereoViewMatrices | Reset the camera to using the Unity computed view matrices for all stereoscopic eyes. |
| ResetTransparencySortSettings | Resets this Camera's transparency sort settings to the default. Default transparency settings are taken from GraphicsSettings instead of directly from this Camera. |
| ResetWorldToCameraMatrix | Make the rendering position reflect the camera's position in the Scene. |
| ScreenPointToRay | Returns a ray going from camera through a screen point. |
| ScreenToViewportPoint | Transforms position from screen space into viewport space. |
| ScreenToWorldPoint | Transforms a point from screen space into world space, where world space is defined as the coordinate system at the very top of your game's hierarchy. |
| SetReplacementShader | Make the camera render with shader replacement. |
| SetStereoProjectionMatrix | Sets a custom projection matrix for a specific stereoscopic eye. |
| SetStereoViewMatrix | Sets a custom view matrix for a specific stereoscopic eye. |
| SetTargetBuffers | Sets the Camera to render to the chosen buffers of one or more RenderTextures. |
| SubmitRenderRequest | Submit a renderRequest. |
| TryGetCullingParameters | Get culling parameters for a camera. |
| ViewportPointToRay | Returns a ray going from camera through a viewport point. |
| ViewportToScreenPoint | Transforms position from viewport space into screen space. |
| ViewportToWorldPoint | Transforms position from viewport space into world space. |
| WorldToScreenPoint | Transforms position from world space into screen space. |
| WorldToViewportPoint | Transforms position from world space into viewport space |


| Static Methods | Descriptions |
| --- | --- |
| CalculateProjectionMatrixFromPhysicalProperties | Calculates the projection matrix from focal length, sensor size, lens shift, near plane distance, far plane distance, and Gate fit parameters. To calculate the projection matrix without taking Gate fit into account, use Camera.GateFitMode.None . Additional resources: GateFitParameters |
| FieldOfViewToFocalLength | Converts field of view to focal length. Use either sensor height and vertical field of view or sensor width and horizontal field of view. |
| FocalLengthToFieldOfView | Converts focal length to field of view. |
| GetAllCameras | Fills an array of Camera with the current cameras in the Scene, without allocating a new array. |
| HorizontalToVerticalFieldOfView | Converts the horizontal field of view (FOV) to the vertical FOV, based on the value of the aspect ratio parameter. |
| VerticalToHorizontalFieldOfView | Converts the vertical field of view (FOV) to the horizontal FOV, based on the value of the aspect ratio parameter. |


| Messages | Descriptions |
| --- | --- |
| OnPostRender | Event function that Unity calls after a Camera renders the scene. |
| OnPreCull | Event function that Unity calls before a Camera culls the scene. |
| OnPreRender | Event function that Unity calls before a Camera renders the scene. |
| OnRenderImage | Event function that Unity calls after a Camera has finished rendering, that allows you to modify the Camera's final image. |
| OnRenderObject | OnRenderObject is called after camera has rendered the Scene. |
| OnWillRenderObject | OnWillRenderObject is called for each camera if the object is visible. |

### ref
https://docs.unity3d.com/ScriptReference/Camera.html
