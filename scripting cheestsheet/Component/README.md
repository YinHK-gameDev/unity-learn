## Component
Base class for everything attached to a GameObject.

Note that your code will never directly create a Component. Instead, you write script code, and attach the

### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent-gameObject.html">gameObject</a></td><td class="desc">The game object this component is attached to. A component is always attached to a game object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent-tag.html">tag</a></td><td class="desc">The tag of this game object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent-transform.html">transform</a></td><td class="desc">The Transform attached to this GameObject.</td></tr></tbody></table>

### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.BroadcastMessage.html">BroadcastMessage</a></td><td class="desc">Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.CompareTag.html">CompareTag</a></td><td class="desc">Checks the GameObject's tag against the defined tag.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.GetComponent.html">GetComponent</a></td><td class="desc">Gets a reference to a component of type T on the same GameObject as the component specified.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.GetComponentInChildren.html">GetComponentInChildren</a></td><td class="desc">Gets a reference to a component of type T on the same GameObject as the component specified, or any child of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.GetComponentInParent.html">GetComponentInParent</a></td><td class="desc">Gets a reference to a component of type T on the same GameObject as the component specified, or any parent of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.GetComponents.html">GetComponents</a></td><td class="desc">Gets references to all components of type T on the same GameObject as the component specified.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.GetComponentsInChildren.html">GetComponentsInChildren</a></td><td class="desc">Gets references to all components of type T on the same GameObject as the component specified, and any child of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.GetComponentsInParent.html">GetComponentsInParent</a></td><td class="desc">Gets references to all components of type T on the same GameObject as the component specified, and any parent of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.SendMessage.html">SendMessage</a></td><td class="desc">Calls the method named methodName on every MonoBehaviour in this game object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.SendMessageUpwards.html">SendMessageUpwards</a></td><td class="desc">Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Component.htmlComponent.TryGetComponent.html">TryGetComponent</a></td><td class="desc">Gets the component of the specified type, if it exists.</td></tr></tbody></table>


### ref 
https://docs.unity3d.com/ScriptReference/Component.html
