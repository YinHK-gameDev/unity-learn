## The Shader class & its instance
In Unity, when you work with shaders that are part of the graphics pipeline, you usually work with instances of the **Shader** class. An instance of the **Shader** class is called a **Shader object**.
 
A **Shader object** is a Unity-specific way of working with shader programs; it is a **wrapper** for **shader programs** and other information. It lets you define multiple shader programs in the same file, and tell Unity how to use them. 


### Shader object fundamentals

A Shader object contains shader programs, instructions for changing settings on the GPU (collectively called the render state), and information that tells Unity how to use them.

> You use **Shader objects with materials** to determine the **appearance** of your scene.

You can create Shader objects in two ways. Each has its own type of asset:
- You can **write code** to create a **shader asset**, which is a text file with the **`.shader`** extension.
- You can use **Shader Graph** to create a Shader Graph asset.

> Whichever way you create your Shader object, Unity represents the results in the same way internally.

A **Shader objec**t has a **nested structure**. It organizes information into structures called **SubShaders** and **Passes**. It organises shader programs into **shader variants**.


A **Shader object** contains: 
- Information about itself, such as its **name**
- An optional **fallback Shader object**, which Unity uses if it can’t use this one
- One or more **SubShaders**

### SubShaders
SubShaders let you **separate your Shader object into parts** that are compatible with different **hardware, render pipelines**, and **runtime settings**.

A **SubShader** contains: 
- Information about which **hardware, render pipelines, and runtime settings this SubShader is compatible with**
- **SubShader tags**, which are **key-value pairs** that provide information about the **SubShader**.
- One or more **Passes**.

### ref
https://docs.unity3d.com/Manual/shader-objects.html


