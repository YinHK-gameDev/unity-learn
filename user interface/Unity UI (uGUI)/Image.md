## Image

Image is a textured element in the UI hierarchy. Every interaction component/ selectable component(eg: button, toggle etc.) has this component. 

**object(C#) -> Object(Unity) -> Component -> Behaviour -> MonoBehaviour -> UIBehaviour -> Graphic -> MaskableGraphic -> Image**




To change color of the interaction component:

Eg:
```cs
button.GetComponent<Image>().color = Color.red;

```


### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.Image.html

