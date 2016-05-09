The `DateWrapper` struct instance will be boxed as soon as we try to set it to an interface typed local variable. The boxing will cause a heap allocation.

`Nullable<T>` is a struct, and the implicit conversion from `DateTime` to `Nullable<DateTime>` won't cause any boxing.