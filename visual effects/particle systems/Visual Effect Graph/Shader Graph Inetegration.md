## Shader Graph Inetegration


### Use a Shader Graph in a Visual Effect Graph


To make a visual effect with Shader Graph:

1.  Go to **Edit** > **Preferences** > **Visual Effects**.
2.  Enable **Experimental Operators/Blocks**. This reveals a Shader Graph slot in the output.
3.  Open your Visual Effect Graph in the Visual Effect Graph window. If you do not have a Visual Effect Graph, go to **Create** > **Visual Effects** > **Visual Effect Graph** to create a new one.
4.  In the interface for output contexts, assign your compatible Shader Graph to the **Shader Graph** property. To do this, either search for the Shader Graph directly in the Asset Picker, or drag the Shader Graph sub-asset to the **Shader Graph** slot:
    ![](./img/vfx-graph-shader-graph-output.gif)
5. Click on the output context to view it in the Inspector.

You can make changes to the Shader Graph's Surface Options in the output context.

> **Note**: Any edits you make to a Shader Graph in the VFX Graph are local to the VFX Graph and do not affect the Shader Graph asset.


### Visual Effect Target

The **Visual Effect Shader Graph Target** enables you to **create custom lit** and **unlit** Shader Graphs to use in visual effects.

To create a Shader Graph that uses the Visual Effect Target, select **Assets** > **Create** > **Shader Graph** > **VFX Shader Graph**.


![](./img/GraphSettings_Menu.png)

### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/sg-working-with.html

https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/sg-target-visual-effect.html


