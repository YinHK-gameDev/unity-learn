## The Shader class & its instance
In Unity, when you work with shaders that are part of the graphics pipeline, you usually work with instances of the **Shader** class. An instance of the **Shader** class is called a **Shader object**.
 
A **Shader object** is a Unity-specific way of working with shader programs; it is a **wrapper** for **shader programs** and other information. It lets you define multiple shader programs in the same file, and tell Unity how to use them. 


### Shader object fundamentals

A Shader object contains shader programs, instructions for changing settings on the GPU (collectively called the render state), and information that tells Unity how to use them.

> You use **Shader objects with materials** to determine the **appearance** of your scene.

You can create Shader objects in two ways. Each has its own type of asset:
- You can **write code** to create a **shader asset**, which is a text file with the **`.shader`** extension.
- You can use **Shader Graph** to create a Shader Graph asset.




### ref
https://docs.unity3d.com/Manual/shader-objects.html


