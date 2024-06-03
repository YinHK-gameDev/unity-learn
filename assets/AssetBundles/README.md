## AssetBundles
An **AssetBundle** is an **archive file** that contains platform-specific **non-code Assets** (such as **Models, Textures, Prefabs, Audio clips, and even entire Scenes**) that Unity can **load at run time**.


**AssetBundles** can be useful for **downloadable content (DLC)**, **reducing initial install size**, **loading assets optimized** for the end-user’s platform, and **reduce runtime memory pressure**.

Split your project into asset bundles and have each asset bundle as a separate project. 

An **AssetBundle is content** that is **stored separately from a main game or application and loaded (or downloaded, in the case of mobile and online apps) at runtime**. \
This helps minimize the impact on network and system resources by allowing customers to download and install only the parts they need. AssetBundles can also be used to update or add to content post-release.

**AssetBundle system**

The AssetBundle system organizes assets into containers called AssetBundles. Like the Resources folder, the AssetBundle system creates sets of assets into separate files. Unlike Resources folders, AssetBundles can be stored locally with the Player or remotely in the cloud.

The AssetBundles system, through its API, minimizes the impact on network and system resources. It does this by allowing you to download the bundles on an as-needed basis, so that you can add DLC and post-release content updates. For example, you can deliver new content for your players to view, earn, or purchase, without requiring them to download a new version of your game. Once bundles are downloaded, AssetBundles API provides a way to load and unload assets from bundles.

Although it is a fully bespoke system, AssetBundles has limitations that have required developers to implement their own solutions:

-   The AssetBundles system is an API that can only be used in scripts. There is a limited user interface for defining AssetBundles in the Unity Editor, but building AssetBundles requires scripting.
    

-   The AssetBundles API by itself does not keep track of asset dependencies between AssetBundles. For example, if you want to load a prefab from AssetBundle A, you will need to locate any of its dependencies such as meshes, materials, and textures that may be located in other AssetBundles, and ensure those dependent AssetBundles are loaded at runtime before you attempt to load the prefab.
    

-   Memory allocation and deallocation is direct and manual, so it's possible to unload an asset from an AssetBundle while other code still depends on that asset, potentially resulting in missing content issues or memory leakage. This can become problematic in code that creates race conditions, and requires fortifying your code against these problems.
    

-   AssetBundles runtime API is not aware whether you put your built bundles locally or remotely. This requires you to keep track of the location of that AssetBundle, whether it's on a web server or on disk.


> **Note**: An AssetBundle can contain the **serialized data of an instance of a code object**, such as a **ScriptableObject**. \
However, the class definition itself is compiled into one of the Project assemblies. When you load a serialized object in an AssetBundle, Unity finds the matching class definition, creates an instance of it, and sets that instance’s fields using the serialized values. This means that you can introduce new items to your game in an AssetBundle as long as those items do not require any changes to your class definitions.

In a large project, use AssetBundles and DLLs. Make one or more code projects that compile to DLL(s) in your main project. Similarly, make any number of art projects that generate AssetBundles in your main project.

This way you can make your main project as small as a single "boot" scene with some DLLs and AssetBundles.

> A recommended, and more user friendly, alternative is to use the Addressables package.



### What’s in an AssetBundle?
​
**"AssetBundle"** can refer to two different, but related things.
​
First is the actual file on disk. This is called the AssetBundle archive. The AssetBundle archive is a container, like a folder, that holds additional files inside it. These additional files consist of two types:
​
-   A **serialized file**, which contains your Assets broken out into their individual objects and written out to this single file.
-   **Resource files**, which are **chunks of binary data** stored separately for certain Assets (**Textures and audio**) to allow Unity to efficiently **load them from disk on another thread**.

​

**"AssetBundle"** can also refer to the actual AssetBundle object you interact with via code to load Assets from a specific AssetBundle archive. This object contains a map of all the file paths of the Assets you added to this archive.

### Assigning Assets to AssetBundles

To assign a given Asset to an AssetBundle, follow these steps:

1.  Select the Asset you want to assign to a bundle from your Project View.
2.  Examine the object in the **Inspector**.
3.  At the bottom of the Inspector, there is a section to **assign AssetBundles and Variants**. Use the **left-hand drop down to assign the AssetBundle**, and the **right-hand drop down to assign the variant**.
4.  Click **None** on the left-hand drop to reveal the currently registered AssetBundle names.
5.  Click **New** to create a new AssetBundle
6.  Type in the desired AssetBundle name. **Note:** AssetBundle names support a type of folder structure depending on what you type. To add sub-folders, separate folder names by a `/`. For example, use the AssetBundle name `environment/forest` to create a bundle named `forest` under an `environment` sub-folder
7.  Once you’ve selected or created an AssetBundle name, you can repeat this process for the right hand drop down to assign or create a Variant name, if you desire. Variant names are not required to build the AssetBundles

> **Note:** In the Inspector you can assign an AssetBundle to a folder in your Project. By default, all Assets in that folder are assigned to the same AssetBundle as the folder. The AssetBundle assignments for individual Assets takes precedence, however.

### Unity Asset Bundle Browser tool

You can use the **Asset Bundle Browser** to **view and edit the configuration of asset bundles** in your Unity project.

For more information, see the Unity Asset Bundle Browser documentation.

Note: This tool is an unsupported utility. Viewing extremely large asset bundles can lead to slow performance and memory issues. The Github repository linked from this page contains the latest source code and supersedes any other sources.

To install the Asset Bundle Browser:

1.  Open the Unity **Package Manager**.
2.  Click the **+** (Add) button at the top, left corner of the window.
3.  Choose **Add package from git URL…**
4.  Enter **`https://github.com/Unity-Technologies/AssetBundles-Browser.git`** as the URL
5.  Click **Add**.


https://docs.unity3d.com/Packages/com.unity.assetbundlebrowser@1.7/manual/index.html

https://www.youtube.com/watch?v=OSx4GouFFCE

### ref 
https://docs.unity3d.com/Manual/AssetBundlesIntro.html \
https://docs.unity3d.com/Manual/AssetBundles-Workflow.html \
https://learn.unity.com/tutorial/introduction-to-asset-bundles-1#


