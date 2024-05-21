## Addressables
Mainly used in assets.

The **Addressable Asset System** allows the developer to **ask for** an **asset** **via its address**. Once an asset (e.g. a prefab) is marked **"addressable"**, it **generates an address which can be called from anywhere**. 

Wherever the asset resides (**local or remote**), the system will **locate it and its dependencies**, then **return it**.

Use **Window > Asset Management > Addressables** to begin working with the system.




> **Addressable Assets** are assets that have a **unique address** which you can use to **load them from local or remote AssetBundles**.

### Concepts

-   **Address** - Identifies an Asset for easy run-time retrieval.
-   **AddressableAssetData directory** - Stores your addressable Asset metadata in your Project’s Assets directory.
-   **Asset Group** - Denotes a set of addressable Assets available for build-time processing.
-   **Asset Group Schema** - Defines a set of data that can be assigned to a group and used during the build.
-   **AssetReference** - An object that operates like a direct reference, but with deferred initialization (for example, for lazy loading). The `AssetReference` stores the GUID as an addressable that you can load on-demand.
-   **Asynchronous Loading** - allows the location of the Asset and dependencies (for example, local, remote and generated) to change throughout the course of your development without changing the game code. Async Loading is foundational to the Addressable Asset System.
-   **Build Script** - runs Asset Group Processors to package Assets and provides the mapping between Addresses and Resource Locations for the Resource Manager.
-   **Label** - provides an additional addressable Asset identifier for run-time loading of similar items. For example: `Addressables.DownloadDependenciesAsync("spaceHazards");`


    
### Install Addressables
To install the Addressables package in your project, use the Package Manager:

1.  Open the Package Manager (menu: **Window > Package Manager**).
2.  Set the package list to display packages from the **Unity Registry**.
3.  Select the **Addressables package** in the list.
4.  Click **Install** (at the bottom, right-hand side of the Package Manager window).

To set up the Addressables system in your Project after installation, open the **Addressables Groups** window and click **Create Addressables Settings**.

![](./img/Addressable.png)


### Make an asset Addressable

You can make an asset Addressable in the following ways:

-   Enable the **Addressable** property in the asset's **Inspector** window.
-   Assign the asset to an **AssetReference field** in the **Inspector** window.
-   Drag the asset into a group on the **Addressables Groups window**.
-   In the Project window, move the asset into a folder that's marked as **Addressable**.

> Once you make an asset **Addressable**, the **Addressables system** adds it to a **default gr**oup, unless you place it in a specific group. **Addressables packs assets in a group into AssetBundles** according to your group settings when you make a content build. \
> You can **load these assets** using the **`Addressables` API**.


https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/get-started-make-addressable.html

### ref

https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/index.html

**`Addressable` API** \
https://docs.unity3d.com/Packages/com.unity.addressables@1.21/api/index.html

**Tutorial** \
https://learn.unity.com/course/get-started-with-addressables \
https://www.youtube.com/watch?v=5IvPPI7YnwU \
https://www.youtube.com/watch?v=0USXRC9f4Iw \
https://www.youtube.com/watch?v=cl_2icxKCyQ \
https://www.youtube.com/watch?v=dKYuyKoKU14



