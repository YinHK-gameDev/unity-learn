## Events

Events **define the inputs** for a **Visual Effect Graph's processing workflow**. 

The **Spawn and Initialize Contexts use Events as their inputs**. 


Through Events, a Visual Effect Graph can :

- **Start** and **stop spawning particles**.
- **Read Event Attribute payloads sent from C# scripts**.

![](./img/EventContexts.png)

In general, an Event is just a string that represents the Event's name. To receive an Event in the Visual Effect Graph, create an Event Context and type the name of the Event you want to receive in the Event Name property. 


> **Note**: Event Contexts have **no input flow slots** and can **only connect their output flow slot** to **Spawn** or **Initialize Contexts**.



To **create an Event Context**:

- In the Visual Effect Graph window, **right-click in an empty space**.
From the menu, click Create Node.
- In the Node Creation menu, click **Contexts > Event (Context**).
- In the Event Name input field, **type the name of your Event**.

### Default Events

The Visual Effect Graph provide two default Events:

-   **OnPlay**: To enable the spawning of particles. If you do not assign an Event to a Spawn Context's **Start** input flow slot, the Visual Effect Graph implicitly binds this Event to that input flow slot instead.
-   **OnStop**: To disable the spawning of particles. If you do not assign an Event to a Spawn Context's **Stop** input flow slot, the Visual Effect Graph implicitly binds this Event to that input flow slot instead.

If you connect an Event Context to a Spawn Context's **Start** or **Stop** input flow slot, this removes the implicit binding to the **OnPlay** and **OnStop** Events respectively.

### Custom Events
If you do not want to use the default Events, you can **use an Event Context to create your own custom Event**.

To do this, first **create an Event Context**, then **type the name of your custom Event** in the **Event Name property**.

### Event Attribute Payloads

**Event Attribute payloads** are **attributes** that you **can attach to an Event**. \
To **set these attributes** in a **Visual Effect Graph**, you can use the **Set [Attribute]** **Blocks** in **Spawn Contexts**, \
![](./img/event_attribute.png). \
but you can also **attach them to Events you send from C# scripts**. For information on how to do that latter, see **Component API** .

**Event Attribute Payloads are attributes that implicitly travel through the graph from Events**, through **Spawn Contexts**, and **eventually to** an **Initialize Context**. 

> To **catch a payload** in an **Initialize Context**, use **`Get Source Attribute`** Operators or **`Inherit [Attribute]`** Blocks.



### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Events.html


