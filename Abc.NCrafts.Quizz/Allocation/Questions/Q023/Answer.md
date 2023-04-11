Both implementations of `string.Concat` and `string.Trim` used here are optimized to avoid heap allocations in certain conditions.

When concatenating a string with an empty string, the `string.Concat` method can simply return the non-empty string.

When a trimming operation should leave the original string unchanged, the `string.Trim` method is able to return the original string.

However, actually retrieving a section of an existing string using `string.Substring` will allocate a new string containing only the desired characters.