### assets for model or environment


### unity asset store
https://assetstore.unity.com/

### 3D model - sketchfab
https://sketchfab.com/3d-models/animations-sonic-sonic-runners-adventure-model-fda871314b2642c6b5fdcab05b0275c1#download

### Asset processing
Unity reads and processes any files that you add to the Assets folder, and converts the contents of the file to **internal game-ready data**. The asset files themselves remain unchanged, and the internal data is stored in the project’s **Library folder**. This data is part of the **Unity Editor’s Asset Database**.

Unity stores the internal representation of your assets in the Library folder, which behaves like a cache folder. As a user, you should never need to alter the Library folder manually; if you do, you might negatively affect your project in the Unity Editor. This also means that you should not include the Library folder under version control.

> **Note**: If your project is not open in Unity, you can safely delete the Library folder, because Unity can regenerate all of its data from the Assets and ProjectSettings folders the next time you launch your project.


### Asset packages
Asset packages are collections of files and data from Unity projects, or elements of projects, which Unity compresses and stores in one file with the .unitypackage extension. Like a zip file, an asset package maintains its original directory structure when it is unpacked, as well as metadata about assets (such as import settings and links to other assets).

To create your own (custom) asset package, use the 
`Assets`>`Export Pckage menu option to compress a collection of assets in your current Unity project. For more information, see Creating your own Asset packages.

To import a local custom asset package into your project, use the `Assets`>`import package option to unpack the collection into your currently open Unity project. For more information, see Importing Asset packages.




