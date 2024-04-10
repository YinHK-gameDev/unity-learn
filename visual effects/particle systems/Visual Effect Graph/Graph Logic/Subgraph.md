## Subgraph
A Visual Effect Subgraph is an Asset that contains a part of a Visual Effect Graph that can be used in another Visual Effect Graph or Subgraph. Subgraphs appear as a single Node.


Subgraphs can be used in graphs as three main usages:

- **System Subgraph**: One, or many Systems contained into one Graph.
- **Block Subgraph**: A set of Blocks and Operators packaged together and used as a Block.
- **Operator Subgraph**: A set of Operators packaged together and used as an Operator.


> Subgraphs allow you to factorize commonly used sets of Nodes in a graph into reusable Assets and adds them to the Library.

A Subgraph appears as a single node, which can help declutter your graph logic. Use it to save part of your VFX Graph as a separate asset that you can drop into another VFX Graph for reorganization and reuse.

To create a Subgraph, select a set of nodes and then pick **Convert To Subgraph Operator** from the right mouse menu. Save the asset to disk and convert the nodes into a single **Subgraph Node**. You can package Systems, Blocks, and Operators into different types of Subgraphs.

Creating a Subgraph is analogous to refactoring code. Just as you would organize logic into reusable methods or functions, a Subgraph makes elements of your VFX Graph more modular.


### Creating System Subgraphs

To create a System Subgraph:

1.  Create a Visual Effect Graph in the Project Window.
2.  Select one or many Systems in a Visual Effect Graph.
3.  Navigate to the the Right-Click context menu and select **Convert to Subgraph**.
4.  Save the Graph Asset in the Save File dialog.

Creating a subgraph using this method replaces all converted content with a System Subgraph Node.

### Editing System Subgraphs

To edit a System Subgraph that is open in the Visual Effect Graph window:

1.  Double-click the Visual Effect Graph Asset in the Project view.
2.  Right-click the System Subgraph Context.
3.  Select Enter Subgraph in the context menu.

### Creating Block Subgraphs

To create a Block Subgraph:

1.  Create a Visual Effect Subgraph Block in the Project Window using **Asset/Create/Visual Effects/Visual Effect Subgraph Block**.
2.  Select one or more Blocks and optionally Operators in a Visual Effect Graph
3.  Navigate to the the Right-Click context menu and select **Convert to Subgraph Block**
4.  Save the Sub Graph Asset in the Save File Dialog.

When you create a subgraph using this method, Unity replaces all converted content with a Block Subgraph Node.

### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Subgraph.html


