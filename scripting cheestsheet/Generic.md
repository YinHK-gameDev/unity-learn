### Generic

https://learn.unity.com/tutorial/generics?projectId=5c88f2c1edbc2a001f873ea5#


### Generic functions

A generic method is a method that is **declared with type parameters** The Unity Scripting API Reference documentation lists some functions (for example, the various GetComponent functions) with a variant that has a letter **T** or a **type name** in angle brackets after the function name:

```csharp
//generic function
void FuncName<T>()
//return type = T/void , parameter type = T
```

[Generic Methods - C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods)


### Generic class
```cs
class  GenericClassName<T>  { .... }
```
[Generic Classes - C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes)


### Multiple generic types

You can specify more than one parameter type. To do this, in the <> operator, after the first generic type, enter a comma and another generic type.


```cs
public class Exercise<T, V>
{

}
```

```cs
public class Exercise<T, V>
{
    private T t;
    private V v;

    public void SetTValue(T value)
    {
        t = value;
    }

    public T GetTValue()
    {
        return t;
    }

    public void SetVValue(V value)
    {
        v = value;
    }
    public V GetVValue()
    {
        return v;
    }

    public  void Show(T tValue, V vValue)
    {
        Console.WriteLine(L"First:  {0}\nSecond: {1}", tValue, vValue);
    }
}

```
