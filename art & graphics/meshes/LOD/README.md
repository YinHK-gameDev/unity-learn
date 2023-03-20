## LOD 
**Level of detail (LOD)** is a technique **reduces the number of GPU operations** that 
Unity requires to render distant meshes.


When a GameObjectThe fundamental object in Unity scenes, 
which can represent characters, props, scenery, cameras, waypoints, and more.
A GameObject’s functionality is defined by the Components attached to it. More info
See in Glossary in the Scene is far away from the Camera , you **see less detail compared to when the GameObject is close** to the Camera. 
However, **by default, Unity uses the same number of triangles to render it at both distances**. 
This can result in wasted GPU operations, which can impact performance in your Scene.


The **LOD technique** allows Unity to **reduce the number of triangles it renders** for a GameObject 
**based on its distance** from the Camera.

These meshes are called **LOD levels**. The farther a GameObject is from the Camera, 
the **lower-detail LOD level** Unity renders. 
This technique reduces the load on the hardware for these distant GameObjects, and can therefore improve rendering performance.


### LOD Levels
A **LOD level** is a mesh that defines the level of detail Unity renders for a GameObject’s geometry.

When a GameObject uses LOD, Unity displays the **appropriate LOD level** for that GameObject based on the **GameObject’s distance** from the Camera.

Each LOD level exists in a separate GameObject, each of which has a Mesh Renderer component that displays that **LOD level**. For the very lowest level of detail, you can use a **Billboard Asset**, which Unity displays instead of a 3D mesh.
 
> Unity shows and hides these GameObjects as required. **LOD levels** **must be child GameObjects** to the GameObject they relate to.


![](../img/LOD0Image.png)

At LOD 0, the Camera shows a mesh with a large number of small triangles. At LOD 1, the Camera shows the mesh with far fewer triangles, which are much larger in size.


### Set up LOD in Unity
**To use LOD, you must have a GameObject with a **LOD Group** component**. The **LOD Group component provides controls to define how LOD behaves on this GameObject, and references the GameObjects that Unity shows or hides for each LOD level**.

You can set up LOD in Unity two ways:

-  You can **configure** **LOD levels** in your **external 3D modeling application**, and Unity can automatically **create** and **configure the required GameObjects and components** for you. See [Importing LOD Meshes](https://docs.unity3d.com/Manual/LevelOfDetail.htmlimporting-lod-meshes.html) for details on the correct configuration.
-  You can **manually** create a GameObject with a **LOD Group** component, and **configure** the **LOD levels** manually.


### Configuring LOD levels
To manually configure the distance from the camera at which Unity displays each LOD level, use the **LOD Group component’s selection bar**.

> The **LOD Group component** accepts a maximum of **8 LOD levels**. **LOD 0** is the closest to the Camera, and therefore the **most detailed LOD level**.

In the [Quality settings](https://docs.unity3d.com/Manual/LevelOfDetail.htmlclass-QualitySettings.html) window, you can **configure LOD settings** that affect all GameObjects in your Project.

There are **two LOD settings** you can configure:

-   **Maximum LOD Level**: Exclude meshes above a specified LOD level from your build.
-   **LOD Bias**: Determine whether to favor higher or lower LOD levels at threshold distances.



### Importing LOD Meshes

You can create meshes with different levels of detail in an external 3D application for use with Unity’s [LOD system](https://docs.unity3d.com/Manual/LevelOfDetail.html). If you name these meshes correctly, Unity automatically creates and configures a **GameObject**The fundamental object in Unity scenes, which can represent characters, props, scenery, cameras, waypoints, and more. A GameObject’s functionality is defined by the Components attached to it. [More info](https://docs.unity3d.com/Manual/importing-lod-meshes.htmlclass-GameObject.html)  
See in [Glossary](https://docs.unity3d.com/Manual/importing-lod-meshes.htmlGlossary.html#GameObject) with [LOD group](https://docs.unity3d.com/Manual/class-LODGroup.html)A component to manage level of detail (LOD) for GameObjects. [More info](https://docs.unity3d.com/Manual/importing-lod-meshes.htmlclass-LODGroup.html)  
See in [Glossary](https://docs.unity3d.com/Manual/importing-lod-meshes.htmlGlossary.html#LODGroup) component for them when it imports the Model.

To import a Model with **LOD** level into Unity, you must do the following:

1.  In your external 3D application, follow the application’s process to create as many LOD meshes as you need.
    
2.  Name the meshes according to the following naming convention:
    -   ExampleMeshName\_LOD0 for the first LOD level (i.e., the **most detailed version**)
    -   ExampleMeshName\_LOD1
    -   ExampleMeshName\_LOD2
3.  Export your Model as an FBX file. Alternatively, if you are using Maya, export the mesh group directly into Unity; to do this, go to **File > Send to Unity > Selection.**
    
4.  Import the FBX into Unity. Unity recognizes the grouped Meshes and naming convention, and automatically creates an [LOD Group](https://docs.unity3d.com/Manual/class-LODGroup.html) component with the appropriate settings.



### ref
https://docs.unity3d.com/Manual/LevelOfDetail.html

Creating LODs in Maya for Unity \
https://learn.unity.com/tutorial/creating-lods-in-maya-for-unity#


