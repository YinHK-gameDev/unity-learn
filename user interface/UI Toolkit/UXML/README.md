## UXML
The **UXML** format is inspired by **HTML, XAML, and XML**.

**Unity Extensible Markup Language (UXML)** files are text files that define the structure of the UI
. UXML along with USS makes it easier for less technical users to define the layout and the style of the UI. 
This leaves developers with technical tasks, such as importing assets, defining logic, and processing data.

```xml
<?xml version="1.0" encoding="utf-8"?>
<UXML
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
    xmlns="UnityEngine.UIElements"
    xsi:noNamespaceSchemaLocation="../UIElementsSchema/UIElements.xsd"
    xsi:schemaLocation="UnityEngine.UIElements ../UIElementsSchema/UnityEngine.UIElements.xsd">
    <Label text="Select something to remove from your suitcase:"/>
    <Box>
        <Toggle name="boots" label="Boots" value="false" />
        <Toggle name="helmet" label="Helmet" value="false" />
        <Toggle name="cloak" label="Cloak of invisibility" value="false"/>
    </Box>
    <Box>
        <Button name="cancel" text="Cancel" />
        <Button name="ok" text="OK" />
    </Box>
</UXML>
```


### Namespace
In **UI Toolkit**, each element is defined in either the **`UnityEngine.UIElements`** or the **`UnityEditor.UIElements`** namespace:

-   The **`UnityEngine.UIElements`** namespace contains elements that are defined as part of the Unity runtime.
-   The **`UnityEditor.UIElements`** namespace contains elements that are available in the Unity Editor. To fully specify an element, you must prefix it with its namespace.

To make specifying namespaces easier, you can define a namespace prefix. For example, **`xmlns:engine="UnityEngine.UIElements"`** defines the `engine` prefix as **`UnityEngine.UIElements`**. Once you define a namespace prefix, you can use it to specify namespaces. For example, **`<engine:Button />`** is equivalent to **`<UnityEngine.UIElements:Button />`**

You can also define a default namespace by excluding a prefix. For example, **`xmlns="UnityEngine.UIElements"`** defines **`UnityEngine.UIElements`** as the default namespace. This means that specifying, for example, **`<Button />`** is equivalent to **`<UnityEngine.UIElements:Button />`**.


> **Note**: If you define your own elements, don’t define the custom control class in the **`UnityEngine.UIElements`** or **`UnityEditor.UIElements`** namespace. Otherwise, UI Builder will hide your custom controls.


### Schema

The schema definition validates your UXML files. It specifies which attributes and child elements each UXML element can contain.

In a UXML file, the `xsi:noNamespaceSchemaLocation` or the `xsi:schemaLocation` attributes of the `<UXML>` root element specify the location of the schema definition files.

To create a UXML file with the latest schema definition, select **Assets** > **Create** > **UI Toolkit** > **UI Document**. This creates a file with the `xsi:noNamespaceSchemaLocation` attribute for the root element.

**Note**: If your text editor doesn’t recognize the `xsi:noNamespaceSchemaLocation` attribute, use the `xsi:schemaLocation` attribute instead.

To force an update of the UXML schema definition, select **Assets** > **Update UXML Schema**.

### UXML elements
The definition of the UI is within the `<UXML>` root. The UI definition is a series of nested UXML elements, each representing a visual element.

The element name corresponds to the C# class name of the element to instantiate. Most elements have attributes and their values are mapped to the corresponding class properties in C#. Each element has its own set of attributes in addition to the inherited attributes of its parent class. `VisualElement` is the base class for all elements and it provides the following attributes for all elements:

-   `name`: An identifier for the element. The name should be unique.
-   `picking-mode`: Set to either `Position` to respond to mouse events or `Ignore` to ignore mouse events.
-   `focus-index`: (**OBSOLETE**) Use `tabIndex` and `focusable`.
-   `tabindex`: An integer that defines the tabbing position of the current element.
-   `focusable`: A Boolean that indicates whether the element is focusable.
-   `class`: A space-separated list of identifiers that characterize the element. Use classes to assign visual styles to elements. You can also use classes to select a set of elements in UQuery.
-   `tooltip`: A string that displays as a tooltip when the mouse hovers over the element.
-   `view-data-key` : A string that defines the key used for serialization of the element.

### Add styles to UXML
In **UI Toolkit**, you can use USS to customize the appearance of visual elements
. The suggested workflow for USS is that you visually style an element in UI Builder, extract the style to a USS file, and then reference it in **UXML**.

If you style an element in UI Builder, the style is added as an inline style to the style attribute of UXML elements:

```xml
<ui:UXML ...>
    <ui:VisualElement style="width: 200px; height: 200px; background-color: red;" />
</ui:UXML>
```

To reference a stylesheet file, add the **`<Style>`** element under the root element of a UXML file.

For example, if you have a **USS** file named styles.uss in the same folder of the **UXML** file with the following content:

```xml
<ui:UXML ...>
    <ui:VisualElement style="width: 200px; height: 200px; background-color: red;" />
</ui:UXML>
```

To reference a stylesheet file, add the **`<Style>`** element under the root element of a **UXML** file.

For example, if you have a **USS** file named **`styles.uss`** in the **same folder** of the **UXML** file with the following content:

```css
#root {
    width: 200px;
    height: 200px;
    background-color: red;
}

```

You can reference it like this:

```xml
<ui:UXML ...>
    <Style src="styles.uss" />
    <ui:VisualElement name="root" />
</ui:UXML>
```



### ref 
https://docs.unity3d.com/Manual/UIE-WritingUXMLTemplate.html
