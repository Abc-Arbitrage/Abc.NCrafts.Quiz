The higher-level `Vector<T>` API calls will compile to AVX2 instructions when AVX2 support is avaialble on the CPU, therefore the performance of both solutions will be the same. The generated machine code is very similar for both answers.

Using the lower-level AVX2 intrinsics API does not offer any advantage over the higher-level `Vector<T>` approach *for an algorithm which the latter can handle just fine*, which is the case here.

The lower-level intrinsics are interesting for leveraging features the higher-level API doesn't provide.
