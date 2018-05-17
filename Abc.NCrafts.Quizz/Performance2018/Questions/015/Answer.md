The same number of struct copies need to be made in both cases, therefore the performance will be the same.

 - When calling `DoSomething(NCrafts s)`, a copy will be made.
 - When calling `DoSomething(in NCrafts s)`, no copy will be made because of the call, but a copy will be made when accessing the `s.Sum` *property*, which is a method call in disguise, to ensure the getter does not mutate the instance.
