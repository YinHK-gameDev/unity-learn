### Volumes

In Unity, a Volume is a system used to **apply post-processing effects, lighting settings, skyboxes, fog, and other environment-related effects** in a defined 3D area of the scene.

A Volume is essentially a 3D area (usually with a box collider) that **applies rendering and environmental overrides** when the camera or objects enter it.

You can **blend post-processing, exposure, sky settings, ambient light, fog**, etc.

**Volumes** are used instead of **Post-Processing Stack v2** in **URP and HDRP**.

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

✅ Render Pipelines that support Volumes:
| Render Pipeline | Volume Support | Notes |
|-----------------|----------------|-------|
| HDRP            | ✅ Yes         | Full feature set (Post FX, Fog, Sky, Lighting, Custom FX, etc.) |
| URP             | ✅ Yes         | Supports volumes with Post Processing and limited environment overrides |
| Built-in RP     | ❌ No          | Uses legacy **Post-Processing Stack v2** or **custom scripts**; **no native Volume support** |

### 🔧 Types of Volumes

#### Global Volume
- **Description**: Affects the entire scene, regardless of position.
- **Collider**: No collider needed.
- **Use Case**: Ideal for scene-wide effects like skybox, general fog, or ambient light.

#### Local Volume
- **Description**: Affects a specific area defined by a Box Collider (usually with `IsTrigger = true`).
- **Behavior**: Effects apply or blend when the camera enters the volume area.
- **Use Case**: Suitable for zone-based lighting, post-processing effects, or interior/exterior transitions.

### 📦 How to Create a Volume (Example for HDRP)
1. Create a volume:
   - Go to **GameObject > Volume > Global Volume** for a global effect.
   - Or, create an empty GameObject and add a **Volume** component (**Add Component > Volume**).
2. Assign a **Volume Profile**:
   - In the Volume component, click **New** under Profile to create a new profile.
3. Add effects to the profile:
   - In the profile (Inspector), click **Add Override** to include effects such as:
     - Bloom
     - Color Adjustments
     - Exposure
     - Sky Settings
     - Visual Environment
     - Fog

#### 🎯 Use Case Examples
- Add an **HDRI Sky** in HDRP for realistic scene lighting.
- Blend **post-processing effects** between indoor and outdoor areas.
- Change **ambient lighting** based on specific areas in the scene.
- Apply **fog** or **lighting effects** exclusively inside a tunnel or cave.

### ref 
https://docs.unity3d.com/6000.2/Documentation/Manual/urp/Volumes.html \
https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@17.3/manual/understand-volumes.html?q=volume
