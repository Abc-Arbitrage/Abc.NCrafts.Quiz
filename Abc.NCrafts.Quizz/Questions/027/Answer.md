Quite a few things to process here. Some facts:

- Calling `GetHashCode` on an `int` will not allocate anything on the heap.
- Calling `RuntimeHelpers.GetHashCode` invokes a generic hashcode algorithm that will allocate intermediary reference type instances on the heap.
- Given a list of structs, accessing an element and trying to mutate it will only mutate a copy of it, so the actual element stored in the list remains unchanged.
- `IsByRef` property on `typeof(string)` will return `false` even if strings are reference types in C#. This member doesn't indicate that the type is a reference type or a value type.
- `int` is a simple alias in the C# language for the `System.Int32` type.

Now it's just basic logic...