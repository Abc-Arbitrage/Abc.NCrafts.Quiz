Delegates are reference types. Every time we allocate an `Action` we allocate the instance on the heap.

Creating a delegate from an anonymous method will generate a heap allocation. Creating a delegate from a method group will also generate a heap allocation, since in both cases, the compiler will generate the call to the specific delegate constructor.

Creating a delegate from a lambda would also generate a heap allocation, but in one of the answers, this part is not in the highlighted section so it doesn't count!