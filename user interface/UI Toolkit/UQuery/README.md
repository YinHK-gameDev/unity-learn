## UQuery
You can use **UQuery** to find elements from a **visual tree**.

You can use UQuery through the following extension methods:

-   [`Q`](https://docs.unity3d.com/Manual/UIE-UQuery.html../ScriptReference/UIElements.UQueryExtensions.Q.html)
-   [`Query`](https://docs.unity3d.com/Manual/UIE-UQuery.html../ScriptReference/UIElements.UQueryExtensions.Query.html)


> The **`Q`** and **`Query`** methods use **`UQueryBuilder`** to construct a query. 

To use **UQuery** to find elements, you **must load and instantiate** the **UXML** first, and then use **Query or Q** to **construct selections rules** on a root visual element.


#### Query 
Returns a list of elements that match the selection rules. You can filter the return results of **Query** with the public methods of **`UQueryBuilder`**, such as **First, Last, AtIndex, Children, and Where**.


#### Q 
Is the **shorthan**d for **`Query<T>.First()`**. It **returns the first element that matches the selection rules**.



You can query elements by their **name**, their **USS class**, or their **element type**. You can also query with a **predicate** or make **complex hierarchical queries**.


Example:

```xml
<UXML xmlns="UnityEngine.UIElements">
    <VisualElement name="container1">
      <Button name="OK" text="OK" />
      <Button name="Cancel" text="Cancel" />
    </VisualElement>
     <VisualElement name="container2">
      <Button name="OK" class="yellow" text="OK" />
      <Button name="Cancel" text="Cancel" />
    </VisualElement>
    <VisualElement name="container3">
      <Button name="OK" class="yellow" text="OK" />
      <Button name="Cancel" class="yellow" text="Cancel" />
    </VisualElement>
</UXML>
```

#### Query by name

To find elements by their **name**, use `Query(name: "element-name")` or `Q(name: "element-name")`. You can omit `name` as it’s the first argument. For example:

The following example finds a list of elements named “Ok”:

```csharp
List<VisualElement> result = root.Query("OK").ToList();
```

The following example use `Query` to find the first element named “Ok”:

```csharp
VisualElement result = root.Query("OK").First(); //or VisualElement result = root.Q("OK");            
```

The following example use `Q` to find the first element named “Ok”:

```csharp
VisualElement result = root.Q("OK");            
```

The following example finds the second element named “Ok”:

```csharp
VisualElement result3 = root.Query("OK").AtIndex(1);
```

The following example finds the last element named “Ok”:

```csharp
VisualElement result4 = root.Query("OK").Last();
```

####  Query by USS class

To find elements by a **USS class**, use `Query(className: "class-name")` or `Q(className: "class-name")`.

The following example finds all the elements that have the class “yellow” and assigns them to a list:

```csharp
List<VisualElement> result = root.Query(className: "yellow").ToList();
```

The following example finds the first element that has the class “yellow”:

```csharp
VisualElement result = root.Q(className: "yellow");
```

#### Query by element type

To find elements by their **element type**, use `Query<Type>` or `Q<Type>`.

The following example finds the first button and add a tool tip for it:

```csharp
VisualElement result = root.Q<Button>();
result.tooltip = "This is a tooltip!";
```

The following example finds the third button:

```csharp
VisualElement result = root.Query<Button>().AtIndex(2);
```
#### Query with a predicate
Other than to query element by **name, class, and type**, you can also use the **`Where`** method to select all elements that satisfy a **predicate**. The **predicate** must be a **function callback** that takes a single **`VisualElement`** argument.

The following example finds the all the elements with the “yellow” USS class that have no tool tips:

```csharp
List<VisualElement> result = root.Query(className: "yellow").Where(elem => elem.tooltip == "").ToList();
```

#### Complex hierarchical queries
You can **combine name, class, and type to make complex hierarchical queries**.

The following example finds the first button named “OK” that has a class of “yellow”:

```csharp
VisualElement result = root.Query<Button>(className: "yellow", name: "OK").First();
```

The following example finds the child cancel button of the “container2”:

```csharp
VisualElement result = root.Query<VisualElement>("container2").Children<Button>("Cancel").First();
```

#### Use **`ForEach`**

You can use the **ForEach** method to operate directly on the **query results**.

The following example adds a tool tip for any elements that have no tool tips:

```csharp
root.Query().Where(elem => elem.tooltip == "").ForEach(elem => elem.tooltip="This is a tooltip!");
```

### Best practices
Consider the following when you use UQuery:

-   UQuery traverses through the hierarchy to find elements by name, class or type. Cache results from UQuery at initialization.
-   If you need to retrieve multiple elements, use the `QueryState` struct (returned by the `element.Query()` method) and enumerate it to avoid creating lists. You can also construct a query once and execute it on different elements.
-   UI Toolkit doesn’t destroy visual elements that are no longer needed, it uses C# garbage collector to collect them. Be mindful to not accidentally retain references to visual elements in a class that outlives the UIDocuments or Window where the elements came from.
-   Capture **`VisualElement`** variables inside closures.
-   When you create or release lots of elements, enable incremental garbage collection to avoid garbage collector spikes.





### ref 
https://docs.unity3d.com/Manual/UIE-UQuery.html \
**`UQueryBuilder`**: \
https://docs.unity3d.com/ScriptReference/UIElements.UQueryBuilder_1.html \






