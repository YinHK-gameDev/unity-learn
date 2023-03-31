## Shader compilation

Every time you build your project, the Unity Editor compiles all the shaders that your build requires

Unity Editor does: 

- When it imports a shader asset, it performs some minimal processing (such as Surface Shader generation).
- When it needs to show a shader variant, it checks the Library/ShaderCache folder.
- If it finds a previously compiled shader variant that uses identicial source code, it uses that.
- If it does not find a match, it compiles the required shader variant and saves the result to the cache.

> **Note**: If you enable **Asynchronous shader compilation**, it does this in the background and shows a placeholder shader in the meantime.

### ref
https://docs.unity3d.com/Manual/shader-compilation.html
