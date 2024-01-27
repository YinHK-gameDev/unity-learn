## UXML elements reference

### Base elements
| **Element** | **Namespace** | **Permitted child elements** | **C# class** |
| --- | --- | --- | --- |
| `BindableElement` | `UnityEngine.UIElements` | Any number of `VisualElement` | `UnityEngine.UIElements.BindableElement` |
| `VisualElement` | `UnityEngine.UIElements` | Any number of `VisualElement` | `UnityEngine.UIElements.VisualElement`|

### Built-in controls

The following table is a reference of all built-in controls available for UI Toolkit.

| Element | Bindable | Data type | Namespace | Permitted child elements | C# class |
| --- | --- | --- | --- | --- | --- |
| BoundsField | Yes | UnityEngine.Bounds | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.BoundsField |
| BoundsIntField | Yes | UnityEngine.BoundsInt | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.BoundsIntField |
| Box |  |  | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Box |
| Button | Yes | string | UnityEngine.UIElements | None | UnityEngine.UIElements.Button |
| ColorField | Yes | UnityEngine.Color | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ColorField |
| CurveField | Yes | UnityEngine.AnimationCurve | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.CurveField |
| DoubleField | Yes | double | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.DoubleField |
| DropdownField | Yes | string | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.DropdownField |
| EnumField | Yes | Enum | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.EnumField |
| EnumFlagsField | Yes | Enum | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.EnumFlagsField |
| FloatField | Yes | float | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.FloatField |
| Foldout | Yes | bool | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Foldout |
| GradientField | Yes | UnityEngine.Gradient | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.GradientField |
| GroupBox | Yes |  | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.GroupBox |
| Hash128Field | Yes | UnityEngine.Hash128 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Hash128Field |
| HelpBox |  |  | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.HelpBox |
| IMGUIContainer |  |  | UnityEngine.UIElements | None | UnityEngine.UIElements.IMGUIContainer |
| Image |  |  | UnityEngine.UIElements | None | UnityEngine.UIElements.Image |
| InspectorElement | Yes |  | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.InspectorElement |
| IntegerField | Yes | int | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.IntegerField |
| Label | Yes | string | UnityEngine.UIElements | None | UnityEngine.UIElements.Label |
| LayerField | Yes | int | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.LayerField |
| LayerMaskField | Yes | int | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.LayerMaskField |
| ListView | Yes | IList | UnityEngine.UIElements | None | UnityEngine.UIElements.ListView |
| LongField | Yes | long | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.LongField |
| MaskField | Yes | int | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.MaskField |
| MinMaxSlider | Yes | UnityEngine.Vector2 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.MinMaxSlider |
| MultiColumnListView | Yes |  | UnityEngine.UIElements | None | UnityEngine.UIElements.MultiColumnListView |
| MultiColumnTreeView | Yes |  | UnityEngine.UIElements | None | UnityEngine.UIElements.MultiColumnTreeView |
| ObjectField | Yes | UnityEngine.Object | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ObjectField |
| PopupWindow | Yes | string | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.PopupWindow |
| ProgressBar | Yes | float | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.ProgressBar |
| PropertyField |  |  | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.PropertyField |
| RadioButton | Yes | bool | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.RadioButton |
| RadioButtonGroup | Yes | int | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.RadioButtonGroup |
| RectField | Yes | UnityEngine.Rect | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.RectField |
| RectIntField | Yes | UnityEngine.RectInt | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.RectIntField |
| RepeatButton | Yes | string | UnityEngine.UIElements | None | UnityEngine.UIElements.RepeatButton |
| ScrollView |  |  | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.ScrollView |
| Scroller |  |  | UnityEngine.UIElements | None | UnityEngine.UIElements.Scroller |
| Slider | Yes | float | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Slider |
| SliderInt | Yes | int | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.SliderInt |
| TagField | Yes | string | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.TagField |
| TextElement | Yes | string | UnityEngine.UIElements | None | UnityEngine.UIElements.TextElement |
| TextField | Yes | string | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.TextField |
| TemplateContainer | Yes |  | UnityEngine.UIElements | UnityEngine.UIElements.TemplateContainer |  |
| Toggle | Yes | bool | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Toggle |
| Toolbar |  |  | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.Toolbar |
| ToolbarBreadcrumbs |  |  | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ToolbarBreadcrumbs |
| ToolbarButton | Yes |  | UnityEditor.UIElements | None | UnityEditor.UIElements.ToolbarButton |
| ToolbarMenu | Yes |  | UnityEditor.UIElements | None | UnityEditor.UIElements.ToolbarMenu |
| ToolbarPopupSearchField |  | string | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ToolbarPopupSearchField |
| ToolbarSearchField |  | string | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ToolbarSearchField |
| ToolbarSpacer |  |  | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ToolbarSpacer |
| ToolbarToggle | Yes | bool | UnityEditor.UIElements | Any number of VisualElement | UnityEditor.UIElements.ToolbarToggle |
| TreeView | Yes |  | UnityEngine.UIElements | None | UnityEngine.UIElements.TreeView |
| TwoPaneSplitView |  |  | UnityEngine.UIElements | None | UnityEngine.UIElements.TwoPaneSplitView |
| UnsignedIntegerField | Yes | System.UInt32 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.UnsignedIntegerField |
| UnsignedLongField | Yes | System.UInt64 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.UnsignedLongField |
| Vector2Field | Yes | UnityEngine.Vector2 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Vector2Field |
| Vector2IntField | Yes | UnityEngine.Vector2Int | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Vector2IntField |
| Vector3Field | Yes | UnityEngine.Vector3 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Vector3Field |
| Vector3IntField | Yes | UnityEngine.Vector3Int | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Vector3IntField |
| Vector4Field | Yes | UnityEngine.Vector4 | UnityEngine.UIElements | Any number of VisualElement | UnityEngine.UIElements.Vector4Field |


### Templates

| Element | Description | Namespace | Permitted child elements | Attributes |
| --- | --- | --- | --- | --- |
| `Template` | A reference to another **UXML template** that can be instantiated using the `Instance` element. | `UnityEngine.UIElements` | None | `name`: A unique string identifier for this element `path`: The path of the UXML file to load |
| `Instance` | Instance of a `Template` | `UnityEngine.UIElements` | None | `template`: The `name` of the `Template` to instantiate |

### ref 
https://docs.unity3d.com/Manual/UIE-ElementRef.html

