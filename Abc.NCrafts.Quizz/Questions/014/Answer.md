Of course `char.ToUpper()` does not allocate, it returns an upper-case `char` which is a value type.
Conversely both `string.ToUpper` and string concatenations will allocate strings on the heap.