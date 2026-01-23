## oblique clip plane

In Unity, an oblique clip plane is achieved by modifying a camera's projection matrix using the built-in Camera.CalculateObliqueMatrix function. This technique is commonly used for effects like planar reflections (water, mirrors) or portals, where objects behind a specific plane need to be clipped. 
How to use **`Camera.CalculateObliqueMatrix`**

The process involves defining a clipping plane in world space and then converting it to camera space to generate the modified projection matrix. This new matrix is then assigned to the camera's projectionMatrix property. 
Here is an example script demonstrating the general approach:


- Custom Projections: \
  Modifying the projection matrix is an advanced technique that requires knowledge of transformation matrices.
- Compatibility: \
  Oblique projection matrices might have compatibility issues with certain rendering features, such as some post-processing effects or deferred rendering pipelines.
- Resetting the Matrix: \
  If the camera is used for other rendering (e.g., a main player camera), you may need to reset the projectionMatrix to its default value using Camera.ResetProjectionMatrix() after the oblique pass to avoid inconsistencies in subsequent frames.
- Performance: \
  This method is more efficient than using a custom shader for clipping every object in the scene. 

```cs
using UnityEngine;

public class ObliqueClipExample : MonoBehaviour
{
    public Camera targetCamera; // Assign your camera here in the Inspector
    public GameObject clippingPlaneObject; // Assign a GameObject (e.g., a simple Plane) to define the clip plane

    void LateUpdate()
    {
        if (targetCamera == null || clippingPlaneObject == null) return;

        // 1. Define the clipping plane in world space using the GameObject's position and normal
        // The Plane constructor takes a normal and a point on the plane
        Plane worldSpacePlane = new Plane(clippingPlaneObject.transform.forward, clippingPlaneObject.transform.position);

        // 2. Convert the world space plane to camera space
        // A plane can be represented as a Vector4 (a, b, c, d) where ax + by + cz + d = 0
        Vector4 clipPlaneCameraSpace = CameraSpacePlane(targetCamera, worldSpacePlane);

        // 3. Calculate the oblique projection matrix
        Matrix4x4 obliqueMatrix = targetCamera.CalculateObliqueMatrix(clipPlaneCameraSpace);

        // 4. Apply the new projection matrix to the camera
        targetCamera.projectionMatrix = obliqueMatrix;
    }

    // Helper function to convert a world space plane to camera space
    private static Vector4 CameraSpacePlane(Camera cam, Plane p)
    {
        Vector3 normal = p.normal;
        Vector3 point = p.normal * p.distance;

        Vector3 cpos = cam.worldToCameraMatrix.MultiplyPoint(point);
        Vector3 cnormal = cam.worldToCameraMatrix.MultiplyVector(normal).normalized;

        return new Vector4(cnormal.x, cnormal.y, cnormal.z, -Vector3.Dot(cpos, cnormal));
    }

    // Remember to reset the projection matrix if needed, for instance, in OnPreRender/OnPostRender for reflection cameras
    void OnPreRender()
    {
        // Optional: Store and reset the original matrix if the camera is used for other things
    }

    void OnPostRender()
    {
        // Optional: Reset to the original projection matrix
        // targetCamera.ResetProjectionMatrix(); 
    }
}

```

#### `CalculateObliqueMatrix` implement
```cs
// https://forum.unity.com/threads/oblique-near-plane-clipping.194722/
public class Clipper : MonoBehaviour
{
    Matrix4x4 projection;
    Camera offscreenCam;
   
    void Start ()
    {
        projection            = camera.projectionMatrix;
    }
   
    void OnPreRender()
    {
        camera.projectionMatrix      = projection;
        Matrix4x4 obliqueProjection  = projection; 
       
        Vector4 cameraSpaceClipPlane = CameraSpacePlane(camera, new Vector3(0.0f, 0.0f, 0.0f), Vector3.up, 1.0f);
        CalculateObliqueMatrix(ref obliqueProjection, cameraSpaceClipPlane);
        camera.projectionMatrix = obliqueProjection;
    }
   
    static Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
    {
        Vector3 offsetPos = pos + normal * 0.07f;
        Matrix4x4 m = cam.worldToCameraMatrix;
        Vector3 cpos = m.MultiplyPoint(offsetPos);
        Vector3 point = m.inverse.MultiplyPoint(new Vector3(0.0f, 0.0f, 0.0f));
        cpos -= new Vector3(0.0f, point.y, 0.0f);
        Vector3 cnormal = m.MultiplyVector( normal ).normalized * sideSign;
        return new Vector4(cnormal.x, cnormal.y, cnormal.z, -Vector3.Dot(cpos,cnormal));
    }  
       
    static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
    {
        Vector4 q = projection.inverse * new Vector4(
            sgn(clipPlane.x),
            sgn(clipPlane.y),
            1.0f,
            1.0f
        );
        Vector4 c = clipPlane * (2.0F / (Vector4.Dot (clipPlane, q)));
        // third row = clip plane - fourth row
        projection[2] = c.x - projection[3];
        projection[6] = c.y - projection[7];
        projection[10] = c.z - projection[11];
        projection[14] = c.w - projection[15];
    }
   
    private static float sgn(float a)
    {
        if (a > 0.0f) return 1.0f;
        if (a < 0.0f) return -1.0f;
        return 0.0f;
    }
}

```

### ref
https://gist.github.com/fuqunaga/d87a0123efde61d0aa9cf9718c38a63c \
https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Camera.CalculateObliqueMatrix.html
