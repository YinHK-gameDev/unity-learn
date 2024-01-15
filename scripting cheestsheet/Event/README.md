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
- in **`void TriggerEvent`** , **`Invoke()`** to invoke the event.
- other game object, in its script subscribe and unscribe to the event listener.
- **`void OnEnable()`** or other **`OnEventName`** method to subcribe the event.
- **`void OnDisable()`** or other **`OnEventName`** method to unsubscribe the event. 

#### Using event in Unity
There are 3 ways to use event in Unity
- C# event
- C# delegate
- `UnityEvent`


#### Using C# event

> using **`event`** keyword with **`Func`** delegate or **`Action`** delegate. If any return type, use **`Func`** delegate, otherwise use **`Action`** delegate.

> Or using built-in delegate types **`EventHandler`** or **`EventHandler<TEventArgs>`** 

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
// Door.cs
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


eg:

```cs
public class TestingEvents : MonoBehaviour {

    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;
    public event EventHandler OnSpacePressedTwo;

    public class OnSpacePressedEventArgs : EventArgs {
        public int spaceCount;
    }

    public event TestEventDelegate OnFloatEvent;
    public delegate void TestEventDelegate(float f);

    public event Action<bool, int> OnActionEvent;

    private int spaceCount;

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            spaceCount++;

            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { spaceCount = spaceCount });

            OnSpacePressedTwo?.Invoke(this. EventArgs.Empty);

            OnFloatEvent?.Invoke(1.0f);
        }
    }
}

public class TestingEventSubscriber : MonoBehaviour {

    private void Start() {
        TetsingEvents testingEvents = GetComponent<TetsingEvents>();
        testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;
        testingEvents.OnSpacePressedTwo += TestingEvents_OnSpacePressedTwo;
        testingEvents.OnFlostEvent += TestingEvents_OnFloatEvent;
    }

    private void TestingEvents_OnFloatEvent(float f) {
        Debug.Log("Float: " + f);
    }

    private void TestingEvents_OnSpacePressed(object sender, TestingEvents.OnspacePressedEventArgs e) {
        Debug.Log("Space! " + e.spaceCount);
    }

    private void TestingEvents_OnSpacePressedTwo(object sender, EventArgs e) {
        Debug.Log("Space!");
        TetsingEvents testingEvents = GetComponent<TetsingEvents>();
        testingEvents.OnSpacePressedTwo -= TestingEvents_OnSpacePressedTwo; // unscribe an event
    }

}

```

#### Events & Delegates in C#
https://gamedevbeginner.com/events-and-delegates-in-unity/ 

https://learn.unity.com/tutorial/delegates

### ref 
https://www.youtube.com/watch?v=OuZrhykVytg

https://www.youtube.com/watch?v=k4JlFxPcqlg
