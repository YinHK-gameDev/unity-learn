## SpeedTree
**SpeedTree**, a suite of products by **IDV Inc**., provides prebuilt tree Assets and modeling software focused specifically on trees.

Unity recognizes and imports SpeedTree Assets in the same way that it handles other Assets. If you’re using **SpeedTree Modeler 7**, make sure to resave your `.spm` files using the Unity version of the Modeler. If you’re using **SpeedTree Modeler 8**, save your `.st` files directly into the Unity Project folder.

The SpeedTree importer generates a Prefab with the LODGroup component configured. You can instantiate the **Prefab** in a Scene as a common Prefab instance, or select the Prefab as a tree prototype and paint it across the TerrainThe landscape in your scene. A Terrain GameObject adds a large flat plane to your scene and you can use the **Terrain’s Inspector** window to create a detailed landscape. 


Additionally, the Terrain accepts any GameObject with an LODGroup component as a tree prototype, and does not place limitations on the Mesh size, or number of Materials used. This is different from **Tree Editor trees**.

However, be aware that SpeedTree trees usually use three to four different Materials, which as a result, issues a number of draw calls every frame. Thus, we recommend that you avoid heavy use of **LOD trees** on platforms, such as the mobile platforms, where additional draw calls are relatively costly in terms of rendering performance. 

SpeedTree 是一款功能強大的工具包軟體，用於創建和渲染遊戲中的植物。

SpeedTree 是一款專門的3D樹木建模軟體，其支援大片的樹木的快速建立和渲染，而且它本身還帶有強大的樹木庫，軟件是由美國IDV公司研發制作的。 不僅可以通過插件將樹木導入到其他的3D建模軟體中使用，也可以為游戲引擎提供強大的樹庫支持，目前已經成為著名游戲引擎Unreal的御用樹木生成軟體。

SpeedTree技術最大的特徵就是可以在使用極少多邊形的情況下創造出高度逼真的樹木和植物，並且可以調整風速效果，使得這些植物隨著風的吹動而真實地搖動。遊戲開發者就可以直接在特定地形上生成整個森林，無需將樹一棵一棵地設置在相應地點上，大大提高了工作效率。

SpeedTree是由SpeedTree Modeler、SpeedTree Compiler和SpeedTree SDK三部分構成。Modeler是負責樹木的建模，Compiler是將材質和貼圖打包為程式所用，SDK是要結合程式繪製SpeedTree建模的樹木或者森林。

### ref 
https://docs.unity3d.com/Manual/SpeedTree.html

https://unity.com/products/speedtree

https://www.linksoft.com.tw/product/speedtree

SpeedTree \
https://en.wikipedia.org/wiki/SpeedTree


https://store.speedtree.com/

https://store.speedtree.com/unityannouncement/

https://store.speedtree.com/buy-try/#tab_games-subscription


Tutorial \
https://www.youtube.com/watch?v=NMaOBpVqJiM

