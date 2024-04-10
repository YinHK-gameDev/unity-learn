## Properties

Properties are **editable fields** that you can **connect to graph elements using Property workflow**. \
They can be found on graph elements such as **Contexts, Blocks and Operators**.


**Properties are displayed on graph elements and will change their value accordingly to their actual value in the graph** : Connecting another property to a property slot will display the computed value of the connected property.

After disconnecting a connected property, the field reverts to the previously set property value.

Properties are editable fields that connect to graph elements using the property workflow. Properties can be:

- Any Type, including integers, floats, and booleans
- Made from Compound components, such as Vectors and Colors
- Cast and converted (e.g., an integer to a float)
- Local or World space; click the L or W to switch between them

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


![](./img/PropertyNodes.png)


-   Property Nodes display a Green dot left to the Property name if the property is exposed.
-   To create a Property Node:
    -   Drag the Node from the Blackboard Panel into the Workspace.
    -   Open the Right Click context menu, open the **Create Node** menu and select the desired property from the Property category.
-   To convert a Property Node to an Inline Node of the same type, right-click the property Node and select **Convert to Inline**
-   When you delete a property from the Blackboard, Unity also deletes its property Node instances from the graph.


### The Blackboard

A utility panel called the Blackboard manages Global properties, which can appear multiple times throughout the graph as Property Nodes.



Properties in the Blackboard are either:

-   **Exposed**: The green dot to the left of any Exposed Property indicates that you can see and edit it outside of the graph. Access an Exposed Property in the Inspector via script using the Exposed Property class.
-   **Constant**: A Blackboard property without a green dot is a Constant. It is reusable within the graph but does not appear in the Inspector.

New properties are Exposed by default, and as such, appear in the Inspector. You must uncheck the **Exposed** option if you want to hide your property outside of the graph, and create **Categories** to keep your properties organized.




### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Properties.html


