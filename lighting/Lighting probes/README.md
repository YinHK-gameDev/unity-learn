## Light Probes

**Light Probes** provide a way to capture and use information about light that is passing through the empty space in your scene.

Similar to lightmaps, **light probes** store **"baked"** information about lighting in your scene. The difference is that while **lightmaps store lighting information about light hitting the surfaces in your scene**, **light probes store information about light passing through empty space in your scene**.

Light Probes are positions in the scene where the light is measured (probed) during the bake. 

At runtime, the indirect light that hits dynamic GameObjects is approximated using the values from the nearest Light Probes to that object.





### ref
https://docs.unity3d.com/Manual/LightProbes.html


