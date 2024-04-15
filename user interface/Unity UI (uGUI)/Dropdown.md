## Dropdown

```cs
public Dropdown.DropdownEvent onValueChanged { get; set; }

public int value { get; set; }

public virtual void OnSubmit(BaseEventData eventData)

//Hide the dropdown list. I.e. close it.
public void Hide()

//Clear the list of options in the Dropdown.
public void ClearOptions()
```

**UIBeahviour -> Selectable -> Dropdown**

Eg:

```cs
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    Dropdown m_Dropdown;
    public Text m_Text;

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
                DropdownValueChanged(m_Dropdown);
            });

        //Initialise the Text to say the first value of the Dropdown
        m_Text.text = "First Value : " + m_Dropdown.value;
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        m_Text.text =  "New Value : " + change.value;
    }
}
```
### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.Dropdown.html#properties


