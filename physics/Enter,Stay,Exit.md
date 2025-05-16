### Enter/Stay/Exit analysis

以Trigger為例，就是**OnTriggerEnter**、**OnTriggerStay**、**OnTriggerExit**

(Collision依此類推）。

> 📎 Enter函式是當兩個物件接觸的瞬間，會執行一次這個函式；

> 📎 Stay函式是當兩個物件持續接觸時，會不斷執行這個函式；

> 📎 Exit函式是當兩個物件分開的瞬間，會執行一次這個函式。


### unity collider & Trigger function
使用 Unity 開發遊戲時，往往需要檢測物件之間的碰撞。**`MonoBehaviour`** 提供了 **`OnCollisionXXX`** 和 **`OnTriggerXXX`** 系列函數用來反映 **rigidbody / collider / trigger** 的碰撞，若有偵測到符合對應表中的碰撞條件，就會呼叫函數並傳入相關參數.

**貞測 collider 和 rigidbody collider 的觸碰**: 
```cs
// 開始碰撞瞬間會呼叫一次
void OnCollisionEnter(Collision collision){ ... }　

// 碰撞期間會持續呼叫
void OnCollisionStay(Collision collisionInfo){ ... }

// 停止碰撞瞬間會呼叫一次
void OnCollisionExit(Collision other){ ... }
```

**貞測 trigger 和 rigidbody collider 的觸碰**: 
```cs
// 開始接觸瞬間會呼叫一次
void OnTriggerEnter(Collider other){ ... }

// 接觸期間會持續呼叫
void OnTriggerStay(Collider other){ ... }

// 停止接觸瞬間會呼叫一次
void OnTriggerExit(Collider other){ ... }
```

> Game object **must** have **trigger**

> **`OnTriggerEnter`** happens on the **FixedUpdate** function when two GameObjects collide. The Colliders involved are not always at the point of initial contact.

> **Note**: Both GameObjects **must** contain a **Collider component**. **One must** have **`Collider.isTrigger`** enabled, and contain a **Rigidbody**. If both GameObjects have **`Collider.isTrigger`** enabled, no collision happens. The same applies when **both** GameObjects **do not have a Rigidbody component**.

#### Trigger
A collider configured as a **Trigger** (using the **Is Trigge**r property) **does not behave as a solid object** and **will simply allow other colliders to pass through**. When a collider enters its space, a **trigger will call the `OnTriggerEnter` function** on the trigger object’s scripts

#### Is trigger or not?
If one of collider is trigger, both collider will **pass through each other** whereas **non trigger do not**. So, if both collider without **at least one of these is trigger**, they will **not pass through each other**.

#### Requirement for collision generating trigger messages:
- Both objects **must** have a collider.
- At least one of them **contain a rigidbody**.
- At least one of them has **`Collider.isTrigger` enabled**(one of collider is **trigger** or both).

> **Note**:
> - If none of **Rigidbody** exist, no trigger detection.
> - If **none of them** have **`Collider.isTrigger`** enabled, no trigger detection.

> To generate trigger message: Both have **collider** + At least one contain a **rigidbody** + **At least one trigger** exists

#### Requirement for collision generating collision detection messages:
- Both objects **must** have a collider.
- There is **at least one dynamic collider**(**Rigidbody** & **Isn't kinematic**), the other collider is either a **static collider**, or a **kinematic rigidbody collider**, or another **dynamic collider**.
- **Must not have trigger** in any of collider

> **Note**:
> - If none of **dynamic colliders**, no collision detection.
> - If **at least one of them** have **`Collider.isTrigger`** enabled, no collision detection.
> - If **both** do not have a **rigidbody**, no collision detection.
> - If **both** are **kinematic rigidbody collider**, no collision detection.

> To generate collision detection message: Both have **collider** + At least one have **dynamic collider** + **No any trigger** exists

> Unity **only applies physics forces to collider GameObjects that have a physics body** (a **Rigidbody or ArticulationBody**). When a **physics body collider** collides with a **static collider**, **only** the **physics body collider** behavior changes as a result of the collision (for example, it might bounce or slow down as a result of the collision).

![](./img/trigger&collider.png)

#### Trigger event detect - `OnTriggerXXX`
- **`OnTriggerXXX`** methods do not detect all trigger events happening in the scene — **only the ones involving the GameObject that the script is attached to**.
- **`OnTriggerXXX`** will **not detect trigger events between colliders** that are on the **same GameObject or its children**, if they all belong to the same Rigidbody or are part of the same hierarchy. Unity's physics system ignores self-collisions, **including trigger events**, between colliders that are: 1. Part of the **same object (same Rigidbody or no Rigidbody)**, 2. Parent and child under the **same Rigidbody**.

| Parent/Child Setup | Will OnTriggerXXX fire? |
|-|-|
| Same hierarchy, no Rigidbody | ❌ No |
| Same hierarchy, same Rigidbody	| ❌ No |
| Different Rigidbodies	| ✅ Yes |
| Trigger with external object	| ✅ Yes |

### gameObject vs collision.gameObject
When a collision occurs, `gameObject` and `collision.gameObject` both refer to the GameObject involved in the collision, but they have different contexts depending on where they're used:

-   **`gameObject`**: Refers to the **GameObject** that the script is attached to (the object from which the collision is happening).
-   **`collision.gameObject`**: Refers to the **GameObject** that the script is **colliding with** (the other object involved in the collision).


### Temporarily ignore collision?

https://gamedev.stackexchange.com/questions/164544/temporarily-ignore-collision


### ref
https://docs.unity3d.com/Manual/collider-types-interaction.html

