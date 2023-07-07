## Event
A common way to compose a game scene in Unity is attaching one GameObject to another to share methods and properties. This practice causes a highly coupled architecture that is **hard to maintain**.

Using **Event** is a good way to trigger something happen in game without declaring public gameobject field and dragging and dropping in inspector for detecting the trigger happen.


> To use event, you can choose using **UnityEvents** or **C# delegate & event**


### Create Event Manager
In order to overcome these problems, just created a pure C# Event Manager to implement an event-driven architecture.
allow items in our projects to subscribe to events, and have events trigger actions in our games. This will reduce dependencies and allow easier maintenance of our projects.


### How to set up
- create an empty Unity GameObject named **`XXXManager`**(Event Manager) and attach the **`XXXManager.cs`** script to it.
- include **`void StartListening`**, **`void StopListening`**, **`void TriggerEvent`** methods. 
- in **`void TriggerEvent`** , `Invoke()` to invoke the event.
- other game object, in its script subscribe and unscribe to the event listener.
- **`void OnEnable()`** to subcribe the event.
- **`void OnDisable()`** to unsubscribethe event. 

https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events#

### Using UnityEvents

To configure a callback in the editor there are a few steps to take:

1.  Make sure your script imports/uses **`UnityEngine.Events`**.
    
2.  Select the **"+"** icon to add a slot for a **callback**
    
3.  Select the **`UnityEngine.Object`** you wish to receive the callback (You can use the **object selector** for this)
    
4.  Select the **function** you wish to be called
    
5.  You can add more than one callback for the event


#### Generic UnityEvents
**Create your custom UnityEvents**:


By default a `UnityEvent` in a `Monobehaviour` binds dynamically to a void function. This does not have to be the case as dynamic invocation of **`UnityEvents`** supports binding to functions with up to **4 arguments**. To do this you need to define a **custom** **`UnityEvent`** class that supports multiple arguments. This is quite easy to do:

```cs
[Serializable]
public class StringEvent : UnityEvent <string> {}
```

```cs
public class MyIntEvent : UnityEvent<T0>
{
}
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


### Events & Delegates
https://gamedevbeginner.com/events-and-delegates-in-unity/

### Using C# event

> using **`even`**t keyword with **`Func`** delegate or **`Action`** delegate. If any return type, use **`Func`** delegate, otherwise use **`Action`** delegate.

Eg:

```cs
// EventManager.cs
public class EventManager : MonoBehaviour
{
    public static event Action OpenDoorEvent;

    public static void StartDoorEvent()
    {
        OpenDoorEvent?.Invoke();
    }
}

```

```cs
// Door triger.cs

public class DoorTrigger : Monobehavior
{
    private void onTriggerEnter2D(Collider2D collision)
    {
        EventManager.StartDoorEvent();
    }
}
```

```cs
public class Door : Monobehavior
{
    private void start()
    {
        EventManager.OpenDoorEvent += OpenDoor;
    }

    void Updaye()
    {
        if (open == true)
            transform.positiion = vector2.MoveTowards(transform.position, movePoint.position, 5 * time.deltaTime);
    }


    private void OnDisable()
    {
        EventManager.OpenDoorEvent -= OpenDoor;
    }

}

```


> You can also subcribe the event in `OnEable()` and unscribe the event in `OnDisable()`




