## Asset Database
With most types of asset, Unity needs to convert the data from the asset’s source file into a format that it can use in a game or real-time application. It stores these converted files, and the data associated with them, in the Asset Database.

The conversion process is required because most file formats are optimized to save storage space, whereas in a game or a real-time application, the asset data needs to be in a format that is ready for hardware, such as the CPU, graphics, or audio hardware, to use immediately. For example, when Unity imports a .png image file as a texture, it does not use the original .png-formatted data at runtime. Instead, when you import the texture, Unity creates a new representation of the image in a different format which is stored in the **Project’s Library folder**. The Texture class in the Unity engine uses this imported version, and Unity uploads it to the GPU for real-time display.

If you subsequently modify an asset’s source file that you have already imported (or if you change any of its dependencies) Unity reimports the file and updates the imported version of the data.

The Asset Database also provides an AssetDatabase API that you can use to access Assets, and control or customize the import process.

https://docs.unity3d.com/Manual/AssetDatabase.html
