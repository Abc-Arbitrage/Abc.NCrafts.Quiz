`fixed (int* ptrInt = &_buffer[0])` and `fixed (int* ptrInt = _buffer)` have slightly different semantics.

The difference arises when `_buffer` is `null` or when it's a zero-length array.

 - When using `&_buffer[0]` you'll get an exception (either a `NullReferenceException` or an `IndexOutOfRangeException`).
 - When using `_buffer` you'll get a null pointer.

The compiler needs to emit additional checks when using `fixed (int* ptrInt = _buffer)` to handle this case, therefore the code will be slower.
