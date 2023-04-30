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



### ref 
https://docs.unity3d.com/Manual/UIE-WritingUXMLTemplate.html
