## Asynchronous shader compilation

Asynchronous shader
 compilation is an Editor-only feature that can improve your workflow when you have complex Shader objects
 with lots of shader variants.
 
Shader objects can contain of hundreds or thousands of shader variants
. If the Editor compiled all variants when loading a Shader object, the import process would be very slow. Instead, the Editor compiles shader variants on-demand, the first time it encounters them.

Compiling these shader variants can cause the Editor to stall for milliseconds or even seconds, depending on the graphics API and the complexity of the Shader object. To avoid these stalls, you can use asynchronous shader compilation to compile the shader variants in the background, and use placeholder Shader objects in the meantime.


### ref

https://docs.unity3d.com/Manual/AsynchronousShaderCompilation.html


