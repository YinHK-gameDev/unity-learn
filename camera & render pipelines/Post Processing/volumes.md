### Volumes

In Unity, a Volume is a system used to **apply post-processing effects, lighting settings, skyboxes, fog, and other environment-related effects** in a defined 3D area of the scene.


- The Universal Render Pipeline(URP) uses volumes for post-processing
 effects. **Volumes can override or extend scene properties depending on the camera
 position relative to each volume**.
 You can create the following dedicated volume GameObjects:
  - Global Volume
  - Box Volume
  - Sphere Volume
  - Convex Mesh Volume
- The High Definition Render Pipeline (HDRP) uses volumes. Volumes allow you to partition your scene into areas, so you can control lighting and effects depending on the camera position relative to each volume, rather than tuning an entire scene. \
 You can add a Volume component to any GameObject. A scene can contain multiple GameObjects with Volume components. You can add multiple Volume components to a GameObject. \
 At runtime, HDRP goes through all the enabled Volume components attached to active GameObjects in the scene, and determines each volume's contribution to the final scene settings. HDRP uses the camera position and the Volume component properties to calculate the contribution. HDRP interpolates values from all volumes with a non-zero contribution to calculate the final property values.

### ref 
https://docs.unity3d.com/6000.2/Documentation/Manual/urp/Volumes.html \
https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@17.3/manual/understand-volumes.html?q=volume
