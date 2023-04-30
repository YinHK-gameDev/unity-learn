### Resuable UXML files / templates

You can create a UXML file as a template and **reuse it** in other **UXML** files.


When you design a large user interface, you can create template UXML files that define parts of the UI, and use the `<Template>` and `<Instance>` elements to import it into another UXML file.

For example, if you have a portrait UI element that has an **image, a name, and a label**, you can create a **UXML template** file as **`Assets/Portrait.uxml`** with the following content:

```xml
<ui:UXML ...>
    <ui:VisualElement class="portrait">
        <ui:Image name="portaitImage" style="--unity-image: url(\"a.png\")"/>
        <ui:Label name="nameLabel" text="Name"/>
        <ui:Label name="levelLabel" text="42"/>
    </ui:VisualElement>
</ui:UXML>

```
You can then reuse the Portrait template like this:

```xml
<ui:UXML ...>
    <ui:Template src="/Assets/Portrait.uxml" name="Portrait"/>
    <ui:VisualElement name="players">
        <ui:Instance template="Portrait" name="player1"/>
        <ui:Instance template="Portrait" name="player2"/>
    </ui:VisualElement>
</ui:UXML>
```

### Override UXML attributes




### ref 
https://docs.unity3d.com/Manual/UIE-reuse-uxml-files.html


