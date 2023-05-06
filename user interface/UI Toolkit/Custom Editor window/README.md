## Custom Editor window

Custom Editor windows allow you to extend Unity by implementing your own editors and workflows. This guide covers creating an Editor window through code, reacting to user input, making the UI resizable and handling hot-reloading.

You can create Editor windows through **C#** scripts in your project. A custom Editor window is a class that derives from the **`EditorWindow`** class.

Create a new script file **`MyCustomEditor.cs`** under the **Assets/Editor** folder. Paste the following code into the script:

```cs
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MyCustomEditor : EditorWindow
{
   ...
}
```

> This is an **Editor-only** window that includes the **UnityEditor** namespace, so the file must be placed under the **Editor folder**, or inside an **Editor-only** Assembly Definition.



### 



### ref 
https://docs.unity3d.com/Manual/UIE-HowTo-CreateEditorWindow.html
