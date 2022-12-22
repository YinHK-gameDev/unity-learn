### Namespace

As projects become larger and the number of scripts
increases, the likelihood of having clashes between script class names grows ever greater. This is especially true when several programmers are working on different aspects of the game separately and will eventually combine their efforts in one project. For example, one programmer may be writing the code to control the main player character while another writes the equivalent code for the enemy. Both programmers may choose to call their main script class "Controller", but this will **cause a clash when their projects are combined**.
 
 
> The C# language offers a feature called namespaces that is simply **a collection of classes** that are referred to using a chosen prefix on the class name.

After importing `UnityEngin`` on the top,  can use the class inside unity engine, if using other classes/interfaces/Enumerations 
for example, `UnityEngine.UI.image`, should import `UnityEngine.UI` first or specify `UnityEngine.UI.imag`, while using it. 
Specify the library used specifically.

```cs
namespace Enemy {
    public class Controller1 : MonoBehaviour {
        ...
    }
    
    public class Controller2 : MonoBehaviour {
        ...
    }
}

```
