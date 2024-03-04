## ContextMenu

The ContextMenu attribute allows you to add commands to the context menu.

In the inspector of the attached script. When the user selects the context menu, the function will be executed.

This is most useful for automatically setting up Scene data from the script. The function has to be non-static.

```cs
using UnityEngine;

public class ContextTesting : MonoBehaviour
{
    /// Add a context menu named "Do Something" in the inspector
    /// of the attached script.
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }
}
```


### ref 
https://docs.unity3d.com/ScriptReference/ContextMenu.html

