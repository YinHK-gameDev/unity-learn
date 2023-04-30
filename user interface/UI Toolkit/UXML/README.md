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

You can also define a default namespace by excluding a prefix. For example, **`xmlns="UnityEngine.UIElements"`** defines **`UnityEngine.UIElements`** as the default namespace. This means that specifying, for example, **`<Button /`**


> **Note**: If you define your own elements, don’t define the custom control class in the **`UnityEngine.UIElements`** or **`UnityEditor.UIElements`** namespace. Otherwise, UI Builder will hide your custom controls.

### ref 
https://docs.unity3d.com/Manual/UIE-WritingUXMLTemplate.html
