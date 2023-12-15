## UnityEvents
**UnityEvents** are a way of allowing user driven callback to be persisted from edit time to run time without the need for additional programming and script configuration.


不管是UnityEvent、Event，基本上都是基於Delegate所產生變體，而一旦使用了Event後，便可以極大幅的減少腳本之間的依賴，也不用在苦惱要在start還是update中getcomponet了，因為幾乎都可以用註冊的方式直接完成這些操作。
而其中UnityEvent更是將其完全盡可能極簡化，特別是如果不需要有額外參數傳入的UnityEvevt更是可以直接在Editor中進行操作

為什麼要用事件機制，主要是為了降低程式之間的耦合度(Coupling)，日後維護起來就方便許多。

### Using UnityEvents
To configure a callback in the editor there are a few steps to take:

- Create `XXXManager` and attach `XXXManager.cs`.
- Make sure your script **`imports/uses UnityEngine.Events`**.
- Declare UnityEvent variable: **`[SerializeField] private UnityEvent trigger_name`**.
- Inside trigger menthod, use **`invode()`** method(eg: **`trigger_name.invoke()`**) to trigger callback.
- Select the **`+`** icon to add a slot for a callback
- Select the `UnityEngine.Object` you wish to receive the callback (You can use the object selector for this)
- Select the function(inside that object) you wish to be called
- You can add more than one callback for the event.

When configuring a UnityEvent in the Inspector there are two types of function calls that are supported:

- **Static**. Static calls are preconfigured calls, with preconfigured values that are set in the UI
. This means that when the callback is invoked, the target function is invoked with the argument that has been entered into the UI.
- **Dynamic**. Dynamic calls are invoked using an argument that is sent from code, and this is bound to the type of UnityEvent that is being invoked. The UI filters the callbacks and only shows the dynamic calls that are valid for the UnityEvent.
  

### Steps for Using UnityEvents

To configure a callback in the editor there are a few steps to take:

1. Set up event manager script for using **`UnityEvent`** 

2. Inside the script make sure your script imports/uses **`UnityEngine.Events`**

3. Declare **`UnityEvent`** & **`Invoke()`** function to invoke the event

4. Create a callback function/event handler for this event some where.
    
5. In inspecter, the Event section you declared UnityEvent in the script, select the **"+"** icon to add a slot for a **callback**.
    
6. Select the **`UnityEngine.Object`** you wish to **receive the callback** (You can use the **object selector** for this)
    
7. Select the **function** you wish to be called (a method that subscribe to the event - event handler)
    
8. You can add more than one callback for the event


### Event vs UnityEvents
- In c#  declare an event **must** use script to add event listener.
- Using `UnityEvent`, you can use editor to add event listener manually in inspector.


### Declare UnityEvent
```cs
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    UnityEvent m_MyEvent;

    void Start()
    {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        m_MyEvent.AddListener(Ping);
    }

    void Update()
    {
        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}
```


### Add Listener
```cs
void Start()
{
   //Add a listener to the new Event. Calls MyAction method when invoked
   m_MyEvent.AddListener(MyAction);
}
```

### Remove listener
```cs
m_MyEvent.RemoveListener(MyAction);
```


### ref 
https://docs.unity3d.com/Manual/UnityEvents.html \
https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html \
https://www.youtube.com/watch?v=oc3sQamIh-Q \
https://www.youtube.com/watch?v=TWxXD-UpvSg

