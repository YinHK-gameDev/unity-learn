## Emissive materials
"**Emission**" is a property of the Standard Shader which allows static objects in our scene to **emit light**.
 
Like area lights, emissive materials emit light across their surface area.

Example:


![](./img/EmissiveMaterial.png)

"**Emission**" is a property of the Standard **Shader** which allows **static objects** in our scene to emit light. 

> **Note**: Emission will only be received by objects marked as **Static** or **Lightmap Static** from the Inspector. Similarly, emissive materials applied to non-static, or dynamic geometry such as characters will not contribute to scene lighting.

Materials with an emission above zero will still appear to glow brightly on-screen even if they are not contributing to scene lighting.

> **Note**: Emissive materials only directly affect static geometry in your scene. If you need dynamic, or non-static geometry - such as characters, to pick up light from emissive materials, **Light Probes**
 must be used.
 
 
