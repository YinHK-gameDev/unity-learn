## Properties

Properties are **editable fields** that you can **connect to graph elements using Property workflow**. \
They can be found on graph elements such as **Contexts, Blocks and Operators**.


**Properties are displayed on graph elements and will change their value accordingly to their actual value in the graph** : Connecting another property to a property slot will display the computed value of the connected property.

After disconnecting a connected property, the field reverts to the previously set property value.


### Property Types

Properties in Visual Effect Graph can be of any Type, including the following:

-   boolean
-   integer
-   float
-   Vectors
-   Textures
-   AnimationCurve
-   Gradient

> After adding the property in the blackboard, you can modify the value in the property field. And the Property will be **showed in the properties field of the Visual Effect component** if the **Exposed checkbox was enabl**e in that property. You can modify the value to ovveride it.


### Property Nodes

Property Nodes are Operators that give access to Graph-Wide Properties defined in the Blackboard. These properties allow you to reuse the same value throughout the graph at different places.

> To create property node, you can drag the property from Blackboard to workspace

> You may use these property nodes to connect any **contexts/blocks** in the workspace.


-   Property Nodes display a Green dot left to the Property name if the property is exposed.
-   To create a Property Node:
    -   Drag the Node from the Blackboard Panel into the Workspace.
    -   Open the Right Click context menu, open the **Create Node** menu and select the desired property from the Property category.
-   To convert a Property Node to an Inline Node of the same type, right-click the property Node and select **Convert to Inline**
-   When you delete a property from the Blackboard, Unity also deletes its property Node instances from the graph.

### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Properties.html


