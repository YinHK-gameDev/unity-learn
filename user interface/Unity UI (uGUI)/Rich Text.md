## Rich Text
The text for UI elements and text meshes can incorporate multiple font styles and sizes. Rich text is supported both for the UI System and the legacy GUI system. 

The **Text, GUIStyle, GUIText and TextMesh classes** have a **Rich Text** setting which instructs Unity to look for **markup tags** within the text. 

The **`Debug.Log`** function can also use these **markup tags** to enhance error reports from code. The tags are not displayed but indicate style changes to be applied to the text.


| Tag | Description | Example | Notes |
| --- | --- | --- | --- |
| `b` | Renders the text in boldface. | We are `<b>not</b>` amused. |  |
| `i` | Renders the text in italics. | We are `<i>usually</i>` not amused. |  |
| `size` | Sets the size of the text according to the parameter value, given in pixels. | We are `<size=50>largely</size` unaffected. | Although this tag is available for Debug.Log, you will find that the line spacing in the window bar and Console looks strange if the size is set too large. |
| `color` | Sets the color of the text according to the parameter value. The color can be specified in the traditional HTML format. #rrggbbaa ...where the letters correspond to pairs of hexadecimal digits denoting the red, green, blue and alpha (transparency) values for the color. For example, cyan at full opacity would be specified by `color=#00ffffff`...You can specify hexadecimal values in uppercase or lowercase; `#FF0000` is equivalent to `#ff0000`. | We are `<color=#ff0000ff>colorfully</color>` amused | Another option is to use the name of the color. This is easier to understand but naturally, the range of colors is limited and full opacity is always assumed. <color=cyan>some text</color> The available color names are given in the table below. |
| `material` | This is only useful for text meshes and renders a section of text with a material specified by the parameter. The value is an index into the text mesh's array of materials as shown by the inspector. | We are `<material=2>texturally</material>` amused |  |
| `quad` | This is only useful for text meshes and renders an image inline with the text. It takes parameters that specify the material to use for the image, the image height in pixels, and a further four that denote a rectangular area of the image to display. Unlike the other tags, quad does not surround a piece of text and so there is no ending tag - the slash character is placed at the end of the initial tag to indicate that it is "self-closing". | `<quad material=1 size=20 x=0.1 y=0.1 width=0.5 height=0.5>` | This selects the material at position in the renderer's material array and sets the height of the image to 20 pixels. The rectangular area of image starts at given by the x, y, width and height values, which are all given as a fraction of the unscaled width and height of the texture. |

### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html
