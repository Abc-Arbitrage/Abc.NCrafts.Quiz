Using the lower-level AVX2 intrinsics API does not offer any advantage over the higher-level `Vector<T>` approach *for an algorithm which the latter can handle just fine*.

The lower-level intrinsics are interesting for leveraging features the higher-level API doesn't provide.
