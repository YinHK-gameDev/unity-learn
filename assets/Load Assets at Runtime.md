## Load Assets at Runtime
You can use **Resource Folders** in your project to include content in your player build, which will make it available to load when needed, independently of the scenes that you build.

### Resource Folders
Resource Folders contain collections of assets that are included in the built Unity player even when they are not directly referenced from any Scene included the Build.


> **Note**: All assets found in the **Resources** folders and their dependencies are stored in a file in the build output called resources.assets. If a scene in the build references an asset then that asset is serialized into a sharedAssets*.assets file instead.

> Only assets that are in the Resources folder can be accessed through **`Resources.Load()`**. \
> However many more assets might end up in the **resources.assets** file since they are dependencies. \
> For example a Material in the Resources folder might reference a Texture outside of the Resources folder. In that case the Texture is also included in the resources.assets file, \
> but it is not available to load directly.

### Resource Unloading
If you want to destroy scene objects that were loaded using **`Resources.Load()`** prior to loading another scene, call **`Object.Destroy()`** on them. 
To release assets and reclaim memory, use **`Resources.UnloadUnusedAssets()`**.


### Limitations and Alternatives
The Resources system is convenient to use, especially for **rapid prototyping and small projects**. \
But it **does not scale well and overall use** of this feature is discouraged. \
For this reason **`AssetBundles`** and the **`Addressables`** package are the **recommended alternative**.

Some downsides of using Resources:

-   Placing a lot of content in this folder will **slow down application startup** and the **length of builds**.
-   The Resource folder is **not appropriate for delivering custom content** for specific platforms.
-   **Making changes** to Assets in the Resource folder **requires a player rebuild** and **redeployment**, whereas **`AssetBundles`** are better suited for **incremental content updates**.


The resources folder can be appropriate for small Assets that are required throughout the project’s lifetime, that do not require updates, and do not vary across platforms or devices. Resource assets might be part of the minimal bootstrapping for a game, with the main content downloaded on-demand with AssetBundles. But local AssetBundles located in the **StreamingAssets** folder could also serve that bootstrapping need.


### ref
https://docs.unity3d.com/Manual/LoadingResourcesatRuntime.html

