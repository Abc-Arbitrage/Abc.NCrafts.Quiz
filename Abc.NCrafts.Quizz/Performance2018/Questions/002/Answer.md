`String.Substring` needs to create a second string instance and copy the substring contents to the new instance.

By using a `ReadOnlySpan<char>` instead, a slice of the original string can be passed to `int.Parse`, without the need to allocate new objects and copy any memory.
