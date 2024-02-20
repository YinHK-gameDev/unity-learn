## Input Field

The Input Field script can be added to any existing Text control object from the menu (**Component > UI > Input Field**). Having done this, you should also drag the object to the Input Field's _Text_ property to enable editing.

The _Text_ property of the Text control itself will change as the user types and the value can be retrieved from a script after editing. Note that Rich Text is intentionally not supported for editable Text controls; the field will apply any Rich Text markup instantly when typed but the markup essentially "disappears" and there is no subsequent way to change or remove the styling.

**UIBeahviour -> Selectable -> InputField**

```cs
//Whether the InputField has focus and whether it is able to process events.
public bool isFocused { get; }

//They type of mobile keyboard that will be used.
public TouchScreenKeyboardType keyboardType { get; set; }

//The type of input expected. 
public InputField.InputType inputType { get; set; }

public virtual float minHeight { get; }

public virtual float minWidth { get; }

public bool multiLine { get; }

public InputField.EndEditEvent onEndEdit { get; set; }

public InputField.SubmitEvent onSubmit { get; set; }

public InputField.OnChangeEvent onValueChanged { get; set; }

public InputField.OnValidateInput onValidateInput { get; set; }

```

```cs
using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class Example : MonoBehaviour
{
    public InputField mainInputField;

    public void Start()
    {
        // Sets the MyValidate method to invoke after the input field's default input validation invoke (default validation happens every time a character is entered into the text field.)
        mainInputField.onValidateInput += delegate(string input, int charIndex, char addedChar) { return MyValidate(addedChar); };
    }

    private char MyValidate(char charToValidate)
    {
        //Checks if a dollar sign is entered....
        if (charToValidate == '$')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        return charToValidate;
    }
}
```

### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-InputField.html \
**InputField Scripting API** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.InputField.html
