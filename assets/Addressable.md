## Addressables
Mainly used in assets.

The **Addressable Asset System** allows the developer to **ask for** an **asset** **via its address**. Once an asset (e.g. a prefab) is marked **"addressable"**, it **generates an address which can be called from anywhere**. 

Wherever the asset resides (**local or remote**), the system will **locate it and its dependencies**, then **return it**.

Use **Window > Asset Management > Addressables** to begin working with the system.




> **Addressable Assets** are assets that have a **unique address** which you can use to **load them from local or remote AssetBundles**.

Unity's Addressables system is a dynamic asset management solution that provides your users with only the assets they need, when they need them. It allows you to organize your on-demand assets from inside the Unity Editor while you're developing your game, and its runtime API lets you load and unload assets dynamically while users are playing your game.



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
    ![](./img/inspectorcheckbox.png)
-   Assign the asset to an **AssetReference field** in the **Inspector** window.
-   Drag the asset into a group on the **Addressables Groups window**.
-   In the Project window, **move the asset into a folder** that's marked as **Addressable**.

> Once you make an asset **Addressable**, the **Addressables system** adds it to a **default gr**oup, unless you place it in a specific group. **Addressables packs assets in a group into AssetBundles** according to your group settings when you make a content build. \
> You can **load these assets** using the **`Addressables` API**.


https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/get-started-make-addressable.html


###  Addressables Groups window
To manage your groups and Addressables assets, open the Addressables Groups window by going to **Window >Asset Management > Addressables > Groups**. Refer to **Addressables Groups window** for details about the features of this window.

To create a group:

1.  Go to **Window** > **Asset Management** > **Addressables** and select **Groups** to open the Addressables Groups window.
2.  Select **New** > **Packed Asset** to create a new group. If you've created your own group templates, they are also displayed in the menu.
3. Context click the new group and select Rename to rename the group.
4. Open the context menu again and select Inspect Group Settings.
5. Adjust the group settings as desired.

#### Add assets to a group

Use one of the following methods to add an asset to a group:

-   Drag the assets from the Project window into the Group window and drop them into the desired group.
-   Drag the assets from one group into another.
-   Select the asset to open it in the Inspector window and enable the **Addressables** option. This adds the asset to the default group. Use the group context menu to change which group is the default group.
-   Add the folder containing the assets to a group. All assets added to the folder are included in the group.

#### Remove assets from a group
Select one or more assets in the Groups window and right-click to open the context menu, then select Remove Addressables. You can also select the assets and press the Delete key to remove the assets from the group.

#### Label

You can tag your Addressable assets with one or more labels in the Addressables Groups window. Labels have a few uses in the Addressables system, including:

-   You can use one or more labels as keys to identify which assets to load at runtime.
-   You can pack assets in a group into AssetBundles based on their assigned labels.
-   You can use labels in the filter box of the Groups window to help find labeled assets

When you load assets using a list of labels, you can specify whether you want to load all assets that have any label in the list or only assets that have every label in the list.

For example, if you used the labels, **`characters`** and **`animals`** to load assets, you could choose to load the union of those two sets of assets, which includes all characters and all animals, or the intersection of those two sets, which includes only characters that are animals. Refer to Loading multiple assets for more information.

When you choose to pack assets in a group based on their assigned labels using the group **Bundle Mode setting**, the Addressables build script creates a bundle for each unique combination of labels in the group.

For example, if you have assets in a group that you have labeled as either **`cat`** or **`dog`** and either **`small`** or **`large`**, the build produces four bundles: one for small cats, one for small dogs, one for large cats, and another for large dogs.


https://docs.unity3d.com/Packages/com.unity.addressables@2.1/manual/Labels.html

#### Add or remove labels
Select one or more assets in the Groups window, then select the label field for one of the selected assets.

To assign labels, enable or disable the checkboxes for the desired labels.

To add, remove or rename your labels, select the + button, then select Manage Labels. To only add a new label, select the + button and then select New Label. Refer to Labels for more information on how to use labels.


#### Building your game

Addressables needs to build your content into files that can be consumed by the running game before you build the player. This step is not done automatically. You can build this content via the UI or API.

1.  UI a. Open the **Addressables** window. b. Select **Build->Build Player Content**
2.  API a. **`AddressableAssetSettings.BuildPlayerContent()`**

### Loading or instantiating by address

You can load or instantiate an Asset at run-time. Loading an Asset loads all dependencies into memory (including Asset bundle data if relevant). This allows you to use the Asset when you need to. Instantiating loads the Asset, and then immediately adds it to the scene.

To access an Asset in script using a string address:

`Addressables.LoadAssetAsync<GameObject>("AssetAddress");`

or

`Addressables.InstantiateAsync("AssetAddress");`

`LoadAssetAsync` and `InstantiateAsync` are asynch operations. You may provide a callback to work with the asset once it is loaded. 

Eg:

```cs
  GameObject myGameObject;


        ...
        Addressables.LoadAssetAsync<GameObject>("AssetAddress").Completed += OnLoadDone;
    }

    private void OnLoadDone(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        // In a production environment, you should add exception handling to catch scenarios such as a null result;
        myGameObject = obj.Result;
    }

```

```cs
void Update()
{
    if(Input.GetKeyDown(KeyCode.T))
    {
      AsyncOperationHandle<GameObject> asyncOperationHandle =
          Addressables.LoadAssetAsync<GameObject>("AssetAddress");

      asyncOperationHandle.Completed += AsyncOperationHandle_Completed;
    }
}


void AsyncOperationHandle_Completed(AsyncOperationHandle<GameObject> asyncOperationHandle)
{
  if(asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
  {
    Instantiate(asyncOperationHandle.Result);
  } else
    {
       Debug.Log("failed to load");
    }

}

```
```cs
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

internal class LoadAddress : MonoBehaviour
{
    public string key;
    AsyncOperationHandle<GameObject> opHandle;

    public IEnumerator Start()
    {
        opHandle = Addressables.LoadAssetAsync<GameObject>(key);
        yield return opHandle;

        if (opHandle.Status == AsyncOperationStatus.Succeeded)
        {
            GameObject obj = opHandle.Result;
            Instantiate(obj, transform);
        }
    }

    void OnDestroy()
    {
        Addressables.Release(opHandle);
    }
}

```

### Using the AssetReference Class

The **`AssetReference`** class provides a mechanism to access Assets without the need to know string (or other) addresses.

To access an Addressable Asset using the \*AssetReference \*class:

1.  Select an Asset.
2.  In the Inspector, click the **Add Component** button and then select the component type.
3.  Add a public `AssetReference` object in the component. For example: `public AssetReference explosion;`
4.  In the Inspector, set which Asset the object is linked to by either dragging an Asset from the Project window onto the entry or clicking the entry to choose from previously defined addressable Assets

   
#### Loading an Addressable Asset by object reference

To load an `AssetReference`, call one of the methods defined on it. For example:

`AssetRefMember.LoadAssetAsync<GameObject>();`

or

`AssetRefMember.InstantiateAsync(pos, rot);`

`LoadAssetAsync` and `InstantiateAsync` are asynch operations. You may provide a callback to work with the asset once it is loaded.

### Load content from multiple projects
https://docs.unity3d.com/Packages/com.unity.addressables@2.0/manual/MultiProject.html

### Remote content
https://docs.unity3d.com/Packages/com.unity.addressables@2.1/manual/RemoteContentDistribution.html


#### Cloud Content Delivery + Addressable Workthrough
https://www.youtube.com/watch?v=5IvPPI7YnwU



### ref
https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/index.html \
https://docs.unity3d.com/Packages/com.unity.addressables@0.8/manual/index.html


**`Addressable` API** \
https://docs.unity3d.com/Packages/com.unity.addressables@1.21/api/index.html \

**`AsyncOperationHandle`** \
https://docs.unity3d.com/Packages/com.unity.addressables@0.8/manual/AddressableAssetsAsyncOperationHandle.html


**Tutorial** \
https://learn.unity.com/course/get-started-with-addressables \
https://www.youtube.com/watch?v=5IvPPI7YnwU \
https://www.youtube.com/watch?v=0USXRC9f4Iw \
https://www.youtube.com/watch?v=cl_2icxKCyQ \
https://www.youtube.com/watch?v=dKYuyKoKU14 \
https://www.youtube.com/watch?v=C6i_JiRoIfk \
https://www.youtube.com/watch?v=wEuFAA-Ktwc

**Example how to use Addressable:** \
https://www.youtube.com/watch?v=bCObS3teFGM \
NodeJS + Addressable
https://www.youtube.com/watch?v=dfSws1QQmKo \
https://z0935323866.medium.com/unity-%E5%B0%8B%E5%9D%80%E5%BC%8F%E8%B3%87%E6%BA%90%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1addressable-assets-system-%E4%B8%80-bb1e99014a88 \
https://z0935323866.medium.com/unity-%E5%B0%8B%E5%9D%80%E5%BC%8F%E8%B3%87%E6%BA%90%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1addressable-assets-system-%E4%BA%8C-eb0e302fd4db \
https://azzipstar.pixnet.net/blog/post/120149247-unity-addressable-%E6%95%99%E5%AD%B8 

