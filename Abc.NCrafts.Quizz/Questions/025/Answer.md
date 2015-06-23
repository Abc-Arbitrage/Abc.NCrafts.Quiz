The `ReadAsync` method of `NetworkStream` causes heap allocations; it must at least allocates the task it returns.

The `Read` method that accepts a byte array can work without allocating any new instances on the heap: it only fills the provided buffer with the read bytes.

The virtual method 'ReadByte' is naively implemented in the `Stream` base class. Internally, it allocates a new byte array of one element, call the `Read` method providing that array, and then returns the only element of the array. All inheritors of the `Stream` class are strongly encouraged to override this method to provide a more efficient implementation. Surprisingly enough, the `NetworkStream` class doesn't override this method, and thus allocates a new byte array on the heap each time it's called.