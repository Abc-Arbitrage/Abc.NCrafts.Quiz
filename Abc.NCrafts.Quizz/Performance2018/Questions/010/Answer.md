An async method which returns a `ValueTask<T>` does not need to allocate when the call completes synchronously.

But awaiting a `Task<T>` performs better than a `ValueTask<T>`, since the latter requires additional casts and indirections, so there's a tradeoff.
