## Graph Logic

### Default VFX Graph Templates window
Use the template window to **create a VFX Graph asset with a predefined effect**. You can use these templates as a starting point for your own effects. Each template has a description and an image to describe its behavior.

#### Create a custom VFX Graph template

VFX Graph includes an API that you can use to create and manage your own VFX Graph templates.

To create a new VFX Graph template, use the **`VFXTemplateHelper.TrySetTemplate`** method.  
Include the following in your script:

-   The path to the VFX asset.
-   A **`VFXTemplateDescriptor`** structure with following information:
    -   Name: Name of the template.
    -   Category: The category this template appears in.
    -   Description: A description for the template to display in the template window details panel.
    -   Icon: (optional) An image icon to show in the template window list of templates.
    -   Thumbnail: (optional) An image to display in the template window details panel.

The method returns **`true`** when the script creates a new template, otherwise it returns `false`. Custom templates appear in the templates window in the Category you defined.

#### Use an existing VFX Graph template in script

To get an existing template descriptor:

1.  Use the method **`VFXTemplateHelper.TryGetTemplate`**.  
2.  Provide the path to the asset and a **`VFXTemplateDescriptor`** structure that will be filled if the asset is found and is a template.

The method returns **`true`** when the script finds the template, otherwise it returns `false`.


### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/GraphLogicAndPhilosophy.html

**Sticky Notes** \
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/StickyNotes.html

**Templates window** \
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Templates-window.html
