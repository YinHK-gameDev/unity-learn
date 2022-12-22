### Namespace

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
