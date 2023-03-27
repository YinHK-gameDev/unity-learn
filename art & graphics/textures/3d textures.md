## 3D textures

A 3D texture is a bitmap image that contains information in three dimensions rather than the standard two. 3D textures are commonly used to simulate volumetric effects such as **fog** or **smoke**, to approximate **a volumetric 3D mesh**
, or to store animated textures and blend between them smoothly.

The maximum resolution of a 3D texture is **2048 x 2048 x 204**8.

> Be aware that the size of a 3D texture in memory and on disk increases quickly as its resolution increases. An **RGBA32** 3D texture with no **mipmaps** and a resolution of **16 x 16 x 16** has a size of **128KB**, but with a resolution of **256 x 256 x 256** it has a size of **512MB**.


### Importing 3D textures

You can import 3D textures from source texture files that are divided into cells. These are called flipbook textures. To do this:

1. Import the source texture into your Unity Project.
2. In your Project view, select the resulting Texture Asset. Unity displays the Texture import settings in the **Inspector**.
3. In the Inspector, set **Texture Shape** to **3D**. Unity displays the Columns and Rows properties.
4. Set **Columns** and **Rows** to the appropriate values for your flipbook texture.
5. Click **Apply**.



### Creating a 3D texture from a script
Unity uses the Texture3D class to represent 3D textures. Use this class to interact with 3D textures in C# scripts.

The following example is an Editor script that creates an instance of the Texture3D class, populates it with color data, and then saves it to your Project as a serialized asset file.


```cs

using UnityEditor;
using UnityEngine;

public class ExampleEditorScript : MonoBehaviour
{
    [MenuItem("CreateExamples/3DTexture")]
    static void CreateTexture3D()
    {
        // Configure the texture
        int size = 32;
        TextureFormat format = TextureFormat.RGBA32;
        TextureWrapMode wrapMode =  TextureWrapMode.Clamp;

        // Create the texture and apply the configuration
        Texture3D texture = new Texture3D(size, size, size, format, false);
        texture.wrapMode = wrapMode;

        // Create a 3-dimensional array to store color data
        Color[] colors = new Color[size * size * size];

        // Populate the array so that the x, y, and z values of the texture will map to red, blue, and green colors
        float inverseResolution = 1.0f / (size - 1.0f);
        for (int z = 0; z < size; z++)
        {
            int zOffset = z * size * size;
            for (int y = 0; y < size; y++)
            {
                int yOffset = y * size;
                for (int x = 0; x < size; x++)
                {
                    colors[x + yOffset + zOffset] = new Color(x * inverseResolution,
                        y * inverseResolution, z * inverseResolution, 1.0f);
                }
            }
        }

        // Copy the color values to the texture
        texture.SetPixels(colors);

        // Apply the changes to the texture and upload the updated texture to the GPU
        texture.Apply();        

        // Save the texture to your Unity Project
        AssetDatabase.CreateAsset(texture, "Assets/Example3DTexture.asset");
    }
}
```

### ref
https://docs.unity3d.com/Manual/class-Texture3D.html
