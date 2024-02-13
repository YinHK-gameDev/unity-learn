## Interactions

An Interaction represents a **specific input pattern**. \
For example, a hold is an Interaction that **requires a Control to be held for at least a minimum amount of time**.

Interactions drive responses on Actions. You can place them on individual Bindings or an Action as a whole, 
in which case they apply to every Binding on the Action. 
**At runtime**, when a **particular interaction completes**, this **triggers the Actio**n.

An Interaction has **a set of distinct phases** it can go through in response to receiving input.

| Phase | Description |
| --- | --- |
| Waiting | The Interaction is waiting for input. |
| Started | The Interaction has been started (that is, it received some of its expected input), but is not complete yet. |
| Performed | The Interaction is complete. |
| Canceled | The Interaction was interrupted and aborted. For example, the user pressed and then released a button before the minimum time required for a hold Interaction to complete. |



### ref 
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Interactions.html?q=Interactions
