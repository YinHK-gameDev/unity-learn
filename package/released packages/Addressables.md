## Addressables

The **Addressable Asset System** allows the developer to ask for an asset via its address. Once an asset (e.g. a prefab) is marked "addressable", it generates an address which can be called from anywhere. Wherever the asset resides (local or remote), the system will locate it and its dependencies, then return it.

Use **Window > Asset Management > Addressables** to begin working with the system.

Addressables use asynchronous loading to support loading from any location with any collection of dependencies. Whether you have been using direct references, traditional asset bundles, or Resource folders, addressables provide a simpler way to make your game more dynamic. Addressables simultaneously opens up the world of asset bundles while managing all the complexity.

For usage samples, see github.com/Unity-Technologies/Addressables-Sample

The Addressables system provides tools and scripts to organize and package content for your application and an API to load and release assets at runtime.

When you make an asset "Addressable," you can use that asset's address to load it from anywhere. Whether that asset resides in the local application or on a content delivery network, the Addressable system locates and returns it.

### ref 
https://docs.unity3d.com/Packages/com.unity.addressables@1.21/manual/index.html
