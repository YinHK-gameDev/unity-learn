## Extension method

In C#, the extension method concept allows you to **add new methods in the existing class or in the structure without modifying the source code of the original type** and you do not require any kind of special permission from the original type and there is no need to re-compile the original type. It is introduced in C# 3.0.

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.


Extension methods are **`static` methods**, but they're called as if they were instance methods on the **extended type**.

Extension methods, as the name suggests, are additional methods. Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.


-   Extension methods allow existing classes to be extended without relying on inheritance or changing the class's source code.
-   If the class is **`sealed`**, there is no concept of extending its functionality. For this, a new concept is introduced, in other words, extension methods.
-   This feature is important for all developers, especially if you would like to use the dynamism of the C# enhancements in your class's design.
-   Extension methods are additional custom methods which were originally not included with the class.
-   Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
-   The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the **`this`** keyword.
-   Extension methods can be used anywhere in the application by including the **namespace of the extension method**.
-   An extension method is actually a special kind of **`static`** method defined in a **`static`** class.
-   The only difference between a regular static method and an extension method is that the **first parameter** of the extension method specifies the type that it is going to operator on, preceded by the **`this`** keyword.


#### Steps
1. Create a **`static`** Class for Extension Methods
2. Define an Extension Method(**`static` method**)
3. use **`public`** as accesss modifier for the extension method
4. The first parameter use **`this`** modifier specify the class or struct to bind.



Eg:

ExtensionMethods


```cs
using UnityEngine;
using System.Collections;

//It is common to create a class to contain all of your
//extension methods. This class must be static.
public static class ExtensionMethods
{
    //Even though they are used like normal methods, extension
    //methods must be declared static. Notice that the first
    //parameter has the 'this' keyword followed by a Transform
    //variable. This variable denotes which class the extension
    //method becomes a part of.
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}
```

  

SomeClass

```cs
using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour 
{
    void Start () {
        //Notice how you pass no parameter into this
        //extension method even though you had one in the
        //method declaration. The transform object that
        //this method is called from automatically gets
        //passed in as the first parameter.
        transform.ResetTransformation();
    }
}
```


### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods

https://learn.unity.com/tutorial/extension-methods#

