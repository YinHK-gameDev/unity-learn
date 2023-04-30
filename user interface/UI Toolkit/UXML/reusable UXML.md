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
When you create instances of a UXML template, you can override the default attribute values of its elements. Attribute overrides allow you to instantiate the same template many times with different values for each instance.

You can override attributes with the `UXML` tag. To override an attribute, specify the following:

-   The `element-name` attribute of the element whose attributes you want to override
-   The name of the attribute to override
-   The new attribute value

For example, if you want to display the same set of information for each player in your game, you can create a UXML template, and use attribute overrides to create player-specific instances.

First, create a template, such as `MyTemplate.uxml`, with the following content:

```xml
<UXML xmlns="Unityui.UIElements">
    <Label name="player-name-label" text="default name" />
    <Label name="player-score-label" text="default score" />
</UXML>
```

Then, instance it from another UXML file and override its attributes to display each player’s name and score:

```xml
<UXML xmlns="UnityEngine.UIElements" xmlns:uie="UnityEditor.UIElements">
    <Template src="MyTemplate.uxml" name="MyTemplate" />
    <Instance name="player1" template="MyTemplate">
        <!-- Alice is the new value of the text attribute for the player-name-label -->
        <AttributeOverrides element-name="player-name-label" text="Alice" /> 
        <!-- 2 is the new value of the text attribute for the player-score-label -->
        <AttributeOverrides element-name="player-score-label" text="2" />
    </Instance>
    <Instance name="player2" template="MyTemplate">
        <!-- Bob is the new value of the text attribute for the player-name-label -->
        <AttributeOverrides element-name="player-name-label" text="Bob" />
        <!-- 1 is the new value of the text attribute for the player-score-label -->
        <AttributeOverrides element-name="player-score-label" text="1" />
    </Instance>
</UXML>
```

#### Override multiple attributes

You can specify more than one attribute per override. For example, the following syntax finds any element in the instance named `player-name-label`, and

-   Overrides the default value of its `text` attribute with the new value, `Alice`.
-   Overrides the default value of its `tooltip` attribute with the new value, `Tooltip 1`.

```xml
<AttributeOverrides element-name="player-name-label" text="Alice" tooltip="Toolt
```

### ref 
https://docs.unity3d.com/Manual/UIE-reuse-uxml-files.html


