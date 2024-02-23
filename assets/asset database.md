## Asset Database
With most types of asset, Unity needs to **convert the data from the asset’s source file into a format that it can use in a game or real-time application**. It stores these converted files, and the data associated with them, in the Asset Database.

The conversion process is required because most file formats are optimized to save storage space, whereas in a game or a real-time application, the asset data needs to be in a format that is ready for hardware, such as the CPU, graphics, or audio hardware, to use immediately. For example, when Unity imports a **.png image** file as a texture, it **does not use the original .png-formatted data at runtime**. Instead, when you import the texture, Unity **creates a new representation of the image in a different format** which is stored in the **Project’s Library folder**. The Texture class in the Unity engine uses this imported version, and Unity **uploads it to the GPU** for real-time display.

If you subsequently modify an asset’s source file that you have already imported (or if you change any of its dependencies) Unity reimports the file and updates the imported version of the data.

The Asset Database also provides an AssetDatabase API that you can use to access Assets, and control or customize the import process.


### Source Assets and Artifacts
**Unity maintains two database files in the Library folder**, which together are called the A**sset Database**. These two databases keep **track of information about your source asset files, and Artifacts**, which is information about the import results.

**The source Asset Database** \
The source Asset Database contains meta-information about your source asset files which Unity uses to determine whether the file has been modified, and therefore whether it should reimport the files. This includes information such as last modified date, a hash of the file’s contents, GUIDs and other meta-information.

**The Artifact database** \
Artifacts are the results of the import process. The Artifact database contains information about the import results of each source asset. Each Artifact contains the import dependency information, Artifact meta-information and a list of Artifact files.

> **Note**: The database files are located in your Project’s Library folder, and as such you should exclude them from version control systems. You can find them in the following locations:

- Source Asset Database: `Library\SourceAssetDB`
- Artifact Database: `Library\ArtifactDB`


### Importing an Asset
Unity **normally imports assets automatically when they are dragged into the project** but it is also possible to **import them under script control**. To do this you can use the **`AssetDatabase.ImportAsset`** method as in the example below.
```cs
using UnityEngine;
using UnityEditor;

public class ImportAsset {
    [MenuItem ("AssetDatabase/ImportExample")]
    static void ImportExample ()
    {
        AssetDatabase.ImportAsset("Assets/Textures/texture.jpg", ImportAssetOptions.Default);
    }
}
```

### Loading an Asset
The editor loads assets only as needed, say if they are **added to the scene
 or edited from the Inspector panel**. However, you can **load and access assets from a script** using **`AssetDatabase.LoadAssetAtPath`**, **`AssetDatabase.LoadMainAssetAtPath`**, **`AssetDatabase.LoadAllAssetRepresentationsAtPath`** and **`AssetDatabase.LoadAllAssetsAtPath`**.
 
```cs
using UnityEngine;
using UnityEditor;

public class ImportAsset {
    [MenuItem ("AssetDatabase/LoadAssetExample")]
    static void ImportExample ()
    {
        Texture2D t = AssetDatabase.LoadAssetAtPath("Assets/Textures/texture.jpg", typeof(Texture2D)) as Texture2D;
    }
}

```

### ref
https://docs.unity3d.com/Manual/AssetDatabase.html \
**AssetDatabase** \
https://docs.unity3d.com/ScriptReference/AssetDatabase.html
