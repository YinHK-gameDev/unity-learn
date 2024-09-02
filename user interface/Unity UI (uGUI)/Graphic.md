## Graphic
Base class for all UI components that should be derived from when creating new Graphic types.


**object(C#) -> Object(Unity) -> Component -> Behaviour -> MonoBehaviour -> UIBehaviour -> Graphic ->...**


#### color
Base color of the Graphic.
```cs
public virtual Color color { get; set; }
```


#### material
The Material set by the user
```cs
public virtual Material material { get; set; }
```

#### depth
Absolute depth of the graphic, used by rendering and events -- lowest to highest.
```cs
public int depth { get; }
```

#### canvas

A reference to the Canvas this Graphic is rendering to.

```cs
public Canvas canvas { get; }
```

#### canvasRenderer
A reference to the CanvasRenderer populated by this Graphic.

```cs
public CanvasRenderer canvasRenderer { get; }
```

#### defaultGraphicMaterial
Default material used to draw UI elements if no explicit material was specified.

```cs
public static Material defaultGraphicMaterial { get; }
```

#### defaultMaterial
Returns the default material for the graphic.

```cs
public virtual Material defaultMaterial { get; }
```

#### raycastTarget
Should this graphic be considered a target for raycasting?
```cs
public virtual bool raycastTarget { get; set; }
```

#### raycastPadding
Padding to be applied to the masking **X = Left Y = Bottom Z = Right W = Top**.

```cs
public Vector4 raycastPadding { get; set; }
```


### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.Graphic.html#properties


