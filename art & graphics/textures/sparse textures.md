## Sparse Textures
Sparse textures (also known as "tiled textures" or "mega-textures") are textures that are too large to fit in graphic memory in their entirety. 

To handle them, Unity breaks the main texture down into smaller rectangular sections known as **"tiles"**.

Individual tiles can then be loaded as necessary. For example, if the camera
 can only see a small area of a sparse texture, then only the tiles that are currently visible need to be in memory.
  
  
  
### ref 
https://docs.unity3d.com/Manual/SparseTextures.html
