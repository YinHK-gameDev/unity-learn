## Control behavior with events

**UI Toolkit** provides events that communicate **user actions or notifications to visual elements**. 
The **UI Toolkit event** system shares the **same terminology** and event naming as **HTML events**.
 
 
The UI Toolkit event system listens to events, coming from the operating system or scripts
, and dispatches these events to visual elements using the **EventDispatcher**. The event dispatcher determines an appropriate dispatching strategy for each event it sends. Once determined, the dispatcher executes the strategy.
 

**Visual elements** implement default behaviors for several events. 
This can involve the creation and execution of additional events. 
For example, a **MouseMoveEvent** could generate an additional **MouseEnterEvent** and a **MouseLeaveEvent**. These events enter a queue and process after the current event. 
For example, the **MouseMoveEvent** finishes processing before the **MouseEnterEvent** and **MouseLeaveEvent** events.
 
### Dispatch behavior of event types

Each event type has its own dispatch behavior. The behavior of each event type breaks down into three stages:

-   **Trickles down**: Events sent to elements during the trickle down phase.
-   **Bubbles up**: Events sent to elements during the bubble-up phase.
-   **Cancellable**: Events that can have their default action execution cancelled, stopped, or prevented.


### Handle events
Events in **UI Toolkit** are similar to **HTML events**. When an event occurs, it’s sent to the target visual element
and to all elements within the propagation path in the **visual element tree**.
 
The event handling sequence is as follows:

1.  Execute event callbacks on elements from the root element down to the parent of the event target. This is the **trickle-down phase** of the dispatch process.
2.  Execute event callbacks on the event target. This is the **target phase** of the dispatch process.
3.  Call `ExecuteDefaultActionAtTarget()` on the event target.
4.  Execute event callbacks on elements from the event target parent up to the root. This is the **bubble-up phase** of the dispatch process.
5.  Call `ExecuteDefaultAction()` on the event target.

As an event moves along the propagation path, the `Event.currentTarget` property updates to the element currently handling the event. Within an event callback function:

-   `Event.currentTarget` is the visual element that the callback registers on.
-   `Event.target` is the visual element where the original event occurs.

 


### ref
https://docs.unity3d.com/Manual/UIE-Events.html


https://docs.unity3d.com/Manual/UIE-Events-Handling.html



