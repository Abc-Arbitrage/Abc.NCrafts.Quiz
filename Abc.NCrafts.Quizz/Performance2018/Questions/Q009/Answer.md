A delegate call is necessarily a virtual call, which adds an indirection. Additionally, the delegate target is a reference type, so captured locals need to be hoisted to a class.

By using a local function, no virtual calls need to be made, which enables JIT optimizations such as inlining. Locals are hoisted to a value type.
