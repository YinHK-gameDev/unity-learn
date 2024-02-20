## Toggle

**UIBeahviour -> Selectable -> Toggle**
```cs
public bool isOn { get; set; }
```

```cs
public Toggle.ToggleEvent onValueChanged
```

```cs
m_Toggle.onValueChanged.AddListener(delegate {
                ToggleValueChanged(m_Toggle);
            });

//Output the new state of the Toggle into Text
void ToggleValueChanged(Toggle change)
{
    m_Text.text =  "New Value : " + m_Toggle.isOn;
}
```

### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.Toggle.html

https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.ToggleGroup.html#fields

