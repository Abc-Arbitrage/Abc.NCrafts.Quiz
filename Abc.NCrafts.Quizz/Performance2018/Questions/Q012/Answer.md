The compiler can optimize a pattern matching `switch` statement against the same type with different constraints in the `when` clause by performing a single type check.

The other answer performs a type check followed by a cast, which is redundant.
