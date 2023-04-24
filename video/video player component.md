## Video Player component

Use the **Video Player component** to **attach video files** to GameObjects, and play them on the GameObject’s **Texture** at run time.

By default, the Material Property of a **Video Player component** is set to a GameObject’s **main texture**, which means that when the Video Player component is attached to a GameObject that has a **Renderer**, it **automatically assigns itself to the Texture on that Renderer** (because this is the main Texture for the GameObject).

For the GameObject has a **Mesh Renderer component**, the Video Player automatically assigns it to the Renderer field, which means the **Video Clip plays** on the **Mesh Renderer’s** Texture.

You can also set a specific target for the video to play on, including:
- A Camera plane
- A Render Texture
- A Material Texture parameter
- Any Texture field in a component


### ref 
https://docs.unity3d.com/Manual/class-VideoPlayer.html
