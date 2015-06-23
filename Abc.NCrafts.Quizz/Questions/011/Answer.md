Most LINQ extensions method take an `IEnumerable<T>` parameter, and enumerating this parameter will generate an allocation.
However the implementation is smart enough and avoid enumerating the collection:

- The `Count` method has a special case for `ICollection<T>`
- The `First` method has a special case for `IList<T>`

But the `First` method has no special case for `Queue<T>`.