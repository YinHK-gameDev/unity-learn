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


### ref
https://docs.unity3d.com/Manual/UIE-Events.html



