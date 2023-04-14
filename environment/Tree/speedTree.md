## SpeedTree
**SpeedTree**, a suite of products by IDV Inc., provides prebuilt tree Assets and modeling software focused specifically on trees.

Unity recognizes and imports SpeedTree Assets in the same way that it handles other Assets. If you’re using **SpeedTree Modeler 7**, make sure to resave your `.spm` files using the Unity version of the Modeler. If you’re using **SpeedTree Modeler 8**, save your `.st` files directly into the Unity Project folder.

The SpeedTree importer generates a Prefab with the LODGroup component configured. You can instantiate the **Prefab** in a Scene as a common Prefab instance, or select the Prefab as a tree prototype and paint it across the TerrainThe landscape in your scene. A Terrain GameObject adds a large flat plane to your scene and you can use the **Terrain’s Inspector** window to create a detailed landscape. 


Additionally, the Terrain accepts any GameObject with an LODGroup component as a tree prototype, and does not place limitations on the Mesh size, or number of Materials used. This is different from **Tree Editor trees**.

However, be aware that SpeedTree trees usually use three to four different Materials, which as a result, issues a number of draw calls every frame. Thus, we recommend that you avoid heavy use of **LOD trees** on platforms, such as the mobile platforms, where additional draw calls are relatively costly in terms of rendering performance. 



### ref 
https://docs.unity3d.com/Manual/SpeedTree.html


