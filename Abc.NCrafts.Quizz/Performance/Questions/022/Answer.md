Looping over a list by using foreach is slower than for as it adds an extra indirection (the Enumerator) which is not optimised away, inlined, by the JIT compiler.

Answer 1 IL:

    IL_0005: br.s         IL_001a
    // start of loop, entry point: IL_001a

      // [23 17 - 23 35]
      IL_0007: ldloc.0      // sum
      IL_0008: ldsfld       class [mscorlib]System.Collections.Generic.List`1<int32> Abc.NCrafts.Quizz.Performance.Questions._022.Answer1::_values
      IL_000d: ldloc.1      // i
      IL_000e: callvirt     instance !0/*int32*/ class [mscorlib]System.Collections.Generic.List`1<int32>::get_Item(int32)
      IL_0013: conv.i8      
      IL_0014: add          
      IL_0015: stloc.0      // sum

      // [21 48 - 21 51]
      IL_0016: ldloc.1      // i
      IL_0017: ldc.i4.1     
      IL_0018: add          
      IL_0019: stloc.1      // i

      // [21 29 - 21 46]
      IL_001a: ldloc.1      // i
      IL_001b: ldsfld       class [mscorlib]System.Collections.Generic.List`1<int32> Abc.NCrafts.Quizz.Performance.Questions._022.Answer1::_values
      IL_0020: callvirt     instance int32 class [mscorlib]System.Collections.Generic.List`1<int32>::get_Count()
      IL_0025: blt.s        IL_0007
    // end of loop


Answer 2 IL:

    IL_000e: br.s         IL_001d
      // start of loop, entry point: IL_001d

        // [20 22 - 20 31]
        IL_0010: ldloca.s     V_1
        IL_0012: call         instance !0/*int32*/ valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<int32>::get_Current()
        IL_0017: stloc.2      // 'value'

        // [22 17 - 22 30]
        IL_0018: ldloc.0      // sum
        IL_0019: ldloc.2      // 'value'
        IL_001a: conv.i8      
        IL_001b: add          
        IL_001c: stloc.0      // sum

        // [20 32 - 20 34]
        IL_001d: ldloca.s     V_1
        IL_001f: call         instance bool valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<int32>::MoveNext()
        IL_0024: brtrue.s     IL_0010
      // end of loop
      IL_0026: leave.s      IL_0036

