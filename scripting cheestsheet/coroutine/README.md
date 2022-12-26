### Coroutine

A **coroutin**e allows you to spread tasks across several frames. It is like a function that has the ability **to pause execution** and **return control to Unity but then to continue** where it left off on the following frame.

In most situations, when you call a method, it runs to completion and then returns control to the calling method, plus any optional return values. This means that any action that takes place within a method must happen within a single frame update.


In situations where you would like to use a method call to contain a procedural animation or a sequence of events over time, you can use a coroutine.

![](./coroutine1.png)
![](./coroutine2.png)

However, it’s important to remember that coroutines aren’t threads. Synchronous operations that run within a coroutine still execute on the main thread. If you want to reduce the amount of CPU time spent on the main thread, it’s just as important to avoid blocking operations in coroutines as in any other script code. If you want to use multi-threaded code within Unity, consider the **C# Job System**.


You can stop a Coroutine with `StopCoroutine` and `StopAllCoroutines`. A **coroutine**s also stops when the GameObject it is attached to is disabled with `SetActive(false)`.


