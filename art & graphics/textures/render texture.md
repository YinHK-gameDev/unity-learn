## Render Texture
Render Texture is a type of Texturethat Unity creates and updates at run time. 

To use a Render Texture, create a new Render Texture using **Assets > Create > Render Texture** and assign it to **Target Texture** in your Camera
 component. Then you can use the Render Texture in a **Material** just like a regular Texture.


To create a live arena camera in your game:

1.  Create a new Render Texture asset using **Assets >Create >Render Texture**.
2.  Create a new Camera using **GameObject > Camera**.
3.  Assign the Render Texture to the **Target Texture** of the new Camera.
4.  Create a new 3D cube using **GameObject > 3D Object > Cube**.
5.  Drag the **Render Texture** onto the **cube** to create a Material that uses the render texture.
6.  Enter **Play Mode**, and observe that the **cube’s texture is updated in real-time** based on the **new Camera’s output**.

### ref
https://docs.unity3d.com/Manual/class-RenderTexture.html
