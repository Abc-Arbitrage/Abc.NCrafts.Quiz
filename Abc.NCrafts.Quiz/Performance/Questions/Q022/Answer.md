Looping over a list by using foreach is slower than for as it adds an extra indirection (the Enumerator) which is not optimised away, inlined, by the JIT compiler.
