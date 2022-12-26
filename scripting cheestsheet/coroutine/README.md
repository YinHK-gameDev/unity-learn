## Coroutine

A **coroutin**e allows you to spread tasks across several frames. It is like a function that has the ability **to pause execution** and **return control to Unity but then to continue** where it left off on the following frame.

In most situations, when you call a method, it runs to completion and then returns control to the calling method, plus any optional return values. This means that any action that takes place within a method must happen within a single frame update.


In situations where you would like to use a method call to contain a procedural animation or a sequence of events over time, you can use a coroutine.

![](./coroutine1.png)
![](./coroutine2.png)

However, it’s important to remember that coroutines aren’t threads. Synchronous operations that run within a coroutine still execute on the main thread. If you want to reduce the amount of CPU time spent on the main thread, it’s just as important to avoid blocking operations in coroutines as in any other script code. If you want to use multi-threaded code within Unity, consider the **C# Job System**.


You can stop a Coroutine with `StopCoroutine` and `StopAllCoroutines`. A **coroutine**s also stops when the GameObject it is attached to is disabled with `SetActive(false)`.

A **coroutine** is a function that can suspend its execution (yield) until the given YieldInstruction finishes. `IEnumerator` function 中 `yield return`, `yield` execution of the function，return a value to `IEnumerator`, and the execution of code will resume at this point. 必須有condition(eg: if/while) 讓 `IEnumerator` function loop. 大部分的 Coroutine 會在 Update() 結束後的 B 時間點執行，那要如何切割 Coroutine 呢？在 Coroutine 函式的每一個區段間，可以用 `yield return null` 中斷執行。Coroutine 用 yield return null 中斷執行後要等到下一幀同樣的 B 時間點才會接續執行


### **Yieldinstruction:**

- **`yield return null` (**-The coroutine will continue after all Update functions have been called on the next frame.**)**
- **`yield return new WaitForSeconds( )` (**-Continue after a specified time delay, after all Update functions have been called for the frame,**)**
- **`yield return new WaitForFixedUpdate( )` (**-Continue after all FixedUpdate has been called on all scripts**)**
- **`yield return new WaitForEndOfFrame( )` (**-Continue after the end of frame. **)**
