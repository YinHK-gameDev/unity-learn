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


### ref 
https://docs.unity3d.com/Manual/UIE-UQuery.html


