## Materials
In Unity, you use materials and shaderstogether to define the appearance of your scene.

To draw something in Unity, you must provide information that describes its shape, and information that describes the appearance of its surface. You use **meshes to describe shapes**, and **materials to describe the appearance of surfaces**.

> **Materials** and **shaders** are closely linked; you always use materials with shaders.

A material contains a reference to a **Shader** object. If that Shader object defines material properties, then the material can also contain data such as **colors** or **references to textures**.

The **Material class** represents a material in C# code. 

A **material asset** is a file with the **`.mat`** extension. It represents a material in your Unity project. For information on viewing and editing a material asset using the **Inspector** window


### Creating a material asset
-   To create a new material asset in your project, from the main menu or the Project View context menu, select **Assets** > **Create** > **Material**.
-   To assign a **shader** to the material asset, in the Inspector window use the **Shader** drop-down menu.


### Assigning a material asset to a GameObject
To render a GameObject using a **material**:

1. Add a component that inherits from **Renderer**.**1MeshRenderer1** is the most common and is suitable for most use cases, but **`SkinnedMeshRenderer`**, **`LineRenderer`**, or **`TrailRenderer`** might be more suitable if your GameObject has **special requirements**.
2. Assign the **material asset** to the component’s **Material** property.



### ref
https://docs.unity3d.com/Manual/materials-introduction.html
