## Unity assets

### assets for model or environment

#### Unity's asset store
The Unity Asset Store contains a library of free and commercial assets that Unity Technologies and members of the community create. A wide variety of assets are available, including textures, models, animations, entire project examples, tutorials, and Editor extensions

Starting from Unity 2020.1, the dedicated Asset Store window is no longer hosted inside the Unity Editor. However, you can still access the Asset Store website at **https://assetstore.unity.com/** and you can still search for your purchased and downloaded Asset Store packages, and import and download them directly in the **Package Manager window**.

**https://assetstore.unity.com/**

#### 3D model - sketchfab
**https://sketchfab.com/3d-models/animations-sonic-sonic-runners-adventure-model-fda871314b2642c6b5fdcab05b0275c1#download**

#### 3D Avatar creator for game
**https://readyplayer.me/developers**

**https://docs.readyplayer.me/ready-player-me/integration-guides/unity-sdk**

**https://youtu.be/qtHEBDOaCPE**

### Asset processing
Unity reads and processes any files that you add to the Assets folder, and converts the contents of the file to **internal game-ready data**. The asset files themselves remain unchanged, and the internal data is stored in the project’s **Library folder**. This data is part of the **Unity Editor’s Asset Database**.

Unity stores the internal representation of your assets in the Library folder, which behaves like a cache folder. As a user, you should never need to alter the Library folder manually; if you do, you might negatively affect your project in the Unity Editor. This also means that you should not include the Library folder under version control.

> **Note**: If your project is not open in Unity, you can safely delete the Library folder, because Unity can regenerate all of its data from the Assets and ProjectSettings folders the next time you launch your project.


### Assets workflow
https://docs.unity3d.com/Manual/AssetWorkflow.html

### Asset packages
**Asset packages are collections of files and data from Unity projects, or elements of projects, which Unity compresses and stores in one file with the `.unitypackage` extension.** Like a zip file, an asset package maintains its original directory structure when it is unpacked, as well as metadata about assets (such as import settings and links to other assets).

To create your own (custom) asset package, use the 
`Assets`>`Export Package` menu option to compress a collection of assets in your current Unity project. For more information, see Creating your own Asset packages.

To import a local custom asset package into your project, use the `Assets`>`import package` option to unpack the collection into your currently open Unity project. For more information, see Importing Asset packages.


### Publishing your asset to asset store
https://docs.unity3d.com/Manual/AssetStorePublishing.html



### Reduce project complexity and size
- Only store assets/code in your repository
- Split your assets/code into smaller units, and put them in multiple Git or Nuget packages
- Export the terrain and maps, along with the necessary textures, to your final project.
- You have a huge library of textures and vegetation models and materials. 
-  you only export those to your level builder project (which may be separated from your prototype mechanics project, and so on).

https://forum.unity.com/threads/how-do-you-organize-your-project-to-reduce-its-complexity-and-size.526687/


