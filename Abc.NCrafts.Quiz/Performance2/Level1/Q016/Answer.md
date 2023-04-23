﻿ - When calling `DoSomething(NCrafts s)`, a copy of the struct is made.
 - When calling `DoSomething(in NCrafts s)`, no copy of the struct will be made. Accessing `s.Sum` does not require a copy to be made either, as the struct itself is `readonly`, which guarantees the property getter won't mutate it.
