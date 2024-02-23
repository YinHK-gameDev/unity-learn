## Addressables
Mainly used in assets.

The **Addressable Asset System** allows the developer to ask for an **asset** **via its address**. Once an asset (e.g. a prefab) is marked **"addressable"**, it **generates an address which can be called from anywhere**. 

Wherever the asset resides (**local or remote**), the system will **locate it and its dependencies**, then **return it**.

Use **Window > Asset Management > Addressables** to begin working with the system.




> **Addressable Assets** are assets that have a **unique address** which you can use to **load them from local or remote AssetBundles**.


### Install Addressables
To install the Addressables package in your project, use the Package Manager:

1.  Open the Package Manager (menu: **Window > Package Manager**).
2.  Set the package list to display packages from the **Unity Registry**.
3.  Select the Addressables package in the list.
4.  Click **Install** (at the bottom, right-hand side of the Package Manager window).

To set up the Addressables system in your Project after installation, open the **Addressables Groups** window and click **Create Addressables Settings**.


### Make an asset Addressable

You can make an asset Addressable in the following ways:

-   Enable the **Addressable** property in the asset's **Inspector** window.
-   Assign the asset to an AssetReference field in the **Inspector** window.
-   Drag the asset into a group on the Addressables Groups window.
-   In the Project window, move the asset into a folder that's marked as **Addressable**.

> Once you make an asset **Addressable**, the **Addressables system** adds it to a **default gr**oup, unless you place it in a specific group. **Addressables packs assets in a group into AssetBundles** according to your group settings when you make a content build. You can **load these assets** using the **`Addressables` API**.


https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/get-started-make-addressable.html

### ref

https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/index.html

**`Addressable` API** \
https://docs.unity3d.com/Packages/com.unity.addressables@1.21/api/index.html
