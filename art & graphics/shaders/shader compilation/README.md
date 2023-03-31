## Shader compilation

Every time you build your project, the Unity Editor compiles all the shaders that your build requires

Unity Editor does: 

- When it imports a shader asset, it performs some minimal processing (such as Surface Shader generation).
- When it needs to show a shader variant, it checks the Library/ShaderCache folder.
- If it finds a previously compiled shader variant that uses identicial source code, it uses that.
- If it does not find a match, it compiles the required shader variant and saves the result to the cache.

> **Note**: If you enable **Asynchronous shader compilation**, it does this in the background and shows a placeholder shader in the meantime.


### Different shader compilers
Different platforms use different shader compilers for [shader program](https://docs.unity3d.com/Manual/shader-compilation.htmlSL-ShaderPrograms.html) compilation as follows:

-   Platforms that use DirectX use Microsoft’s FXC HLSL compiler.
-   Platforms that use OpenGL (Core & ES) use Microsoft’s FXC HLSL compiler, followed by bytecode translation into GLSL using [HLSLcc](https://github.com/Unity-Technologies/HLSLcc).
-   Platforms that use Metal use Microsoft’s FXC HLSL compiler, followed by bytecode translation into Metal, using [HLSLcc](https://github.com/Unity-Technologies/HLSLcc).
-   Platforms that use Vulkan use Microsoft’s FXC HLSL compiler, followed by bytecode translation into SPIR-V, using [HLSLcc](https://github.com/Unity-Technologies/HLSLcc).
-   Other platforms, such as console platforms, use their respective compilers.
-   [Surface Shaders](https://docs.unity3d.com/Manual/shader-compilation.htmlSL-SurfaceShaders.html)A streamlined way of writing shaders for the Built-in Render Pipeline. [More info](https://docs.unity3d.com/Manual/shader-compilation.htmlSL-SurfaceShaders.html)  
    See in [Glossary](https://docs.unity3d.com/Manual/shader-compilation.htmlGlossary.html#SurfaceShader) use HLSL and [MojoShader](https://icculus.org/mojoshader/) for code generation analysis step.

You can configure various shader compiler settings using [pragma directives](https://docs.unity3d.com/Manual/shader-compilation.htmlSL-PragmaDirectives.html).


### ref
https://docs.unity3d.com/Manual/shader-compilation.html
