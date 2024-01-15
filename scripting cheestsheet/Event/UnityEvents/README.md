## UnityEvents
**UnityEvents** are a way of allowing user driven callback to be persisted from edit time to run time without the need for additional programming and script configuration.


不管是UnityEvent、Event，基本上都是基於Delegate所產生變體，而一旦使用了Event後，便可以極大幅的減少腳本之間的依賴，也不用在苦惱要在start還是update中**getComponet**了，因為幾乎都可以用註冊的方式直接完成這些操作。
而其中UnityEvent更是將其完全盡可能極簡化，特別是如果不需要有額外參數傳入的UnityEvevt更是可以直接在Editor中進行操作

為什麼要用事件機制，主要是為了降低程式之間的耦合度(Coupling)，日後維護起來就方便許多。

UnityEvents are useful for a number of things:
-   Content driven callbacks
-   Decoupling systems
-   Persistent callbacks
-   Preconfigured call events

  
`UnityEvent`s can be added to any **`MonoBehaviour`** and are executed from code like a standard **`.NET`** delegate. When a **`UnityEvent`** is added to a **`MonoBehaviour`** it appears in the Inspector and persistent callbacks can be added.

`UnityEvent`s have similar limitations to standard delegates. That is, they hold references to the element that is the target and this stops the target being garbage collected. If you have a **`UnityEngine.Object`** as the target and the native representation disappears the callback will not be invoked.


### Using UnityEvents
To configure a callback in the editor there are a few steps to take:

- Create `XXXManager` and attach `XXXManager.cs`.
- Make sure your script **`imports/uses UnityEngine.Events`**.
- Declare UnityEvent variable: **`[SerializeField] private UnityEvent trigger_name`**.
- Inside trigger menthod, use **`invoke()`** method(eg: **`trigger_name.invoke()`**) to trigger callback.
- Select the **`+`** icon to add a slot for a callback
- Select the `UnityEngine.Object` you wish to receive the callback (You can use the object selector for this)
- Select the function(inside that object) you wish to be called
- You can add more than one callback for the event.
- other game object, in its script subscribe and unscribe to the event listener.
- **`void OnEnable()`** or other **`OnEventName`** method to subcribe the event.
- **`void OnDisable()`** or other **`OnEventName`** method to unsubscribe the event.

When configuring a UnityEvent in the Inspector there are two types of function calls that are supported:

- **Static**: Static calls are **preconfigured** calls, with **preconfigured values** that are set in the UI. This means that when the callback is invoked, the target function is invoked with the argument that has been entered into the UI.
  
- **Dynamic**: Dynamic calls are invoked using an **argument** that is sent from code, and this is bound to the type of **`UnityEvent`** that is being invoked. The **UI filters the callbacks** and only shows the **dynamic calls** that are valid for the **`UnityEvent`**.
  

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
- In c#  declare an event **must** use script to **add event listener**.
- Using **`UnityEvent`**, you can use editor to **add event listener manually** in inspector.


### Declare UnityEvent

```cs
public class TestingEvents : MonoBehaviour {

    public UnityEvent OnUnityEvent;
    private void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            OnUnityEvent?.Invoke();
        }
    }
}
```
In inspecter, the Event section you declared UnityEvent in the script, select the **"+"** icon to add a slot for a **callback**, select the **`UnityEngine.Object`** you wish to **receive the callback** (You can use the **object selector** for this), select the **function** you wish to be called (a method that subscribe to the event - event handler).

```cs
public class TestingEventSubscriber : MonoBehaviour {

    private void TestingUnityEvent() {
        Debug.Log("TestingUnityEvent");
    }

}
```

```cs
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public UnityEvent m_MyEvent;

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


### Generic UnityEvents
**Create your custom UnityEvents**:


By default a `UnityEvent` in a `Monobehaviour` binds dynamically to a void function. This does not have to be the case as dynamic invocation of **`UnityEvents`** supports binding to functions with up to **4 arguments**. To do this you need to define a **custom** **`UnityEvent`** class that supports multiple arguments. This is quite easy to do:



```cs
public class MyIntEvent : UnityEvent<T0>
{
}
```
If you wish to use a generic UnityEvent type you must override the class type.

Eg:
```cs
[Serializable]
public class StringEvent : UnityEvent <string> {}
```


```cs
public class MyIntEvent : UnityEvent<T0,T1>
{
}
```
```cs
public class MyIntEvent : UnityEvent<T0,T1,T2>
{
}
```
```cs
public class MyIntEvent : UnityEvent<T0,T1,T2,T3>
{
}
```

Eg:
```cs
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class MyIntEvent : UnityEvent<int, int, int, int>
{
}

public class ExampleClass : MonoBehaviour
{
    public MyIntEvent m_MyEvent;

    void Start()
    {
        if (m_MyEvent == null)
            m_MyEvent = new MyIntEvent();

        m_MyEvent.AddListener(Ping);
    }

    void Update()
    {
        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke(5, 6, 7, 8);
        }
    }

    void Ping(int i, int j, int k, int l)
    {
        Debug.Log("Ping" + i + j + k + l);
    }
}
```

By adding an instance of this to your class instead of the base **`UnityEvent`** it will allow the callback to bind dynamically to  functions.

This can then be invoked by calling the **`Invoke()`** function with a `string` as argument.

UnityEvents can be defined with up to **4 arguments** in their generic definition.


### ref 
https://docs.unity3d.com/Manual/UnityEvents.html \
https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html \
https://www.youtube.com/watch?v=oc3sQamIh-Q \
https://www.youtube.com/watch?v=TWxXD-UpvSg \
https://www.youtube.com/watch?v=J01z1F-du-E 

**`UnityEvent`** \
https://www.youtube.com/watch?v=djW7g6Bnyrc
