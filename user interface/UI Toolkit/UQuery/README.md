## UQuery
You can use **UQuery** to find elements from a **visual tree**.

You can use UQuery through the following extension methods:

-   [`Q`](https://docs.unity3d.com/Manual/UIE-UQuery.html../ScriptReference/UIElements.UQueryExtensions.Q.html)
-   [`Query`](https://docs.unity3d.com/Manual/UIE-UQuery.html../ScriptReference/UIElements.UQueryExtensions.Query.html)


> The **`Q`** and **`Query`** methods use **`UQueryBuilder`** to construct a query. 

To use **UQuery** to find elements, you **must load and instantiate** the **UXML** first, and then use **Query or Q** to **construct selections rules** on a root visual element.


#### Query 
Returns a list of elements that match the selection rules. You can filter the return results of **Query** with the public methods of **`UQueryBuilder`**, such as **First, Last, AtIndex, Children, and Where**.





### ref 
https://docs.unity3d.com/Manual/UIE-UQuery.html


