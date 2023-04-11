When the struct is not `readonly`, the compiler makes a defensive copy to call `GetC` in order to make sure it won't mutate the original struct, as the `Guids` field is marked `readonly`.

Marking the struct as `readonly` changes the `this` type in `GetC` from `ref SomeGuids` to `readonly ref SomeGuids`, preventing any changes from being made.
