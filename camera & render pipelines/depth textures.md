## Depth Textures

A Camera can generate a depth, depth+normals, or motion vector texture. This is a minimalistic G-buffer texture that can be used for post-processing effects or to implement custom lighting models (e.g. light pre-pass).
 
If you imagine a Camera at the same location as the Light, the areas of the Scene that the Camera cannot see are the same areas of the Scene that rays from the Light cannot reach; therefore, they are in shadow.
 

Unity **populates the shadow map with information about how far rays from the Light travel before they hit a surface**, and then **samples the shadow map to calculate real-time shadows for GameObjects that the Light hits**.


