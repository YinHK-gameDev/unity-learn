## Adaptive Probe Volumes (APV)
Adaptive Probe Volumes make Light Probes
 easier to use by automating placement. They also provide higher quality, more accurate lighting, because they light per-pixel not per-object.

An Adaptive Probe Volume is a group of Light Probes
 that Unity places automatically based on the geometry density in your Scene
, to create baked indirect lighting. You can use Adaptive Probe Volumes instead of manually placing and configuring Light Probes.


### 🌟 Advantages of Adaptive Probe Volumes

- Unity samples surrounding probes **per-pixel** rather than per GameObject.  
  → This results in **better lighting consistency** and **fewer seams** between adjacent GameObjects.
- You can **adjust Light Probe layouts** across a scene. For example, use a **denser set of Light Probes** in interior areas with more detailed lighting or geometry.  
- Adaptive Probe Volumes work well with **multiple scenes**.  
- They include **streaming functionality** to support **large open worlds**.
- You can update **light from the sky at runtime** with **sky occlusion** using **Adaptive Probe Volumes**

### ⚠️ Limitations of Adaptive Probe Volumes
- You **can’t adjust the locations of Light Probes** inside an Adaptive Probe Volume. \
  You can use **settings and overrides** to try to **fix visible artifacts**, \
  but it might not be possible to ensure Light Probes follow walls or lie exactly at the boundary between different lighting areas.  
- You **can’t convert Light Probe Groups** into an Adaptive Probe Volume.

### 💡 Use Adaptive Probe Volumes

#### 🔧 Add and Bake an Adaptive Probe Volume

#### ✅ Enable Adaptive Probe Volumes

- Go to **Edit > Project Settings > Quality**
- In the **Rendering** section, double-click the active **Render Pipeline Asset** to open it in the **Inspector**
- In the **Inspector**, go to **Lighting > Light Probe Lighting**
- Set **Light Probe System** to `Adaptive Probe Volumes`


#### ➕ Add an Adaptive Probe Volume to the Scene

- Go to **GameObject > Light > Adaptive Probe Volume**
- In the **Inspector** of the Adaptive Probe Volume:
  - Set **Mode** to `Global`
  - The Adaptive Probe Volume now covers your entire Scene


#### 🔧 Adjust Light and Mesh Renderer Settings

- To include a **light source** in APV baked lighting:
  - Open the **Inspector** for the light
  - Go to **Light > General**
  - Set **Mode** to `Mixed` or `Baked`

- To include a **GameObject** in APV baked lighting:
  - Open the **Inspector** for the GameObject
  - Go to **Mesh Renderer > Lighting**
  - Enable **Contribute Global Illumination**

- To make a GameObject **receive** lighting from probes:
  - Open the **Inspector** for the GameObject
  - Go to **Mesh Renderer > Lighting**
  - Set **Receive Global Illumination** to `Light Probes`


#### 🔥 Bake Your Lighting

- Go to **Window > Rendering > Lighting**
- In the **Scene** tab, under **Mixed Lighting**, enable **Baked Global Illumination**
- In the **Adaptive Probe Volumes** tab:
  - Under **Baking**, set **Baking Mode** to `Single Scene`

##### 🧱 To Bake:

- To bake **all lighting data** of the scene, click **Generate Lighting**
- To bake **only Adaptive Probe Volumes**, open the **Generate Lighting** dropdown and select **Bake Probe Volumes**

 


### ref 
https://docs.unity3d.com/6000.1/Documentation/Manual/urp/probevolumes.html \
https://docs.unity3d.com/6000.1/Documentation/Manual/urp/probevolumes-concept.html
