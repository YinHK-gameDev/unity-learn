## Video
Use **Unity’s video system** to integrate video into your game. 
Video footage can **add realism**, **save on rendering complexity**, or help you integrate content available externally.

To use video in Unity, import **Video Clips** and configure them using the **Video Player component**. 

> The system also allows you to feed **video footage** directly into the **Texture parameter** of a**ny component that has one**.

> Unity then **plays the Video** on that **Texture** at **run time**.





### Video Player component

> Use the **Video Player component** to **attach video files to GameObjects**, and **play them on the GameObject’s Texture t run time**.

By default, the **Material Property** of a **Video Player component** is **set to a GameObject’s main texture**, which means that when the **Video Player component is attached to a GameObject** that has a **Renderer**, it **automatically assigns itself to the Texture on that Renderer** (because this is the main Texture for the GameObject). 

Here, the GameObject has a **Mesh Renderer component**, so the **Video Player automatically assigns it to the Renderer field**, which means the **Video Clip plays on the Mesh Renderer’s Texture**.

The screenshot below shows a Video Player component attached to a spherical GameObject.

![](./img/Video-1.png)

A Video Player component attached to a spherical GameObject, playing the Video Clip on the GameObject’s main Texture (in this case, the Texture of the Mesh Renderer)

You can also set a specific target for the video to play on, including:

- A Camera plane
- A Render Texture
- A Material Texture parameter
- Any Texture field in a component

https://docs.unity3d.com/Manual/class-VideoPlayer.html



### ref
https://docs.unity3d.com/Manual/VideoPlayer.html

https://www.youtube.com/watch?v=3gtGPLELKBs

https://www.youtube.com/watch?v=1903h0KI7tE

https://www.youtube.com/watch?v=j08xnfqorJM

https://www.youtube.com/watch?v=nADTdV8wsXQ

