## ScrollRect

```cs
public ScrollRect.ScrollRectEvent onValueChanged { get; set; }

public virtual float minHeight { get; }

public virtual float minWidth { get; }

```
```cs
using UnityEngine;
using UnityEngine.UI;

public class ExampleScript : MonoBehaviour
{
    static ScrollRect scrollRect;

    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        scrollRect.onValueChanged.AddListener(ListenerMethod);
    }

    public void ListenerMethod(Vector2 value)
    {
        Debug.Log("ListenerMethod: " + value);
    }
}
```

### ref
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.ScrollRect.html
