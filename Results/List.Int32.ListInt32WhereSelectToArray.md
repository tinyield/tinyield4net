## List.Int32.ListInt32WhereSelectToArray

### Source
[ListInt32WhereSelectToArray.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToArray.cs)

### References:
- Cistern.ValueLinq: [0.1.14](https://www.nuget.org/packages/Cistern.ValueLinq/0.1.14)
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta31](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta31)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]        : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|                                        Method | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|                            ValueLinq_Standard |   100 | 1,036.7 ns | 4.30 ns | 4.02 ns |  3.06 |    0.02 | 0.0706 |     - |     - |     224 B |
|                               ValueLinq_Stack |   100 |   950.6 ns | 3.21 ns | 2.84 ns |  2.81 |    0.02 | 0.0706 |     - |     - |     224 B |
|                     ValueLinq_SharedPool_Push |   100 | 1,048.7 ns | 3.90 ns | 3.65 ns |  3.10 |    0.02 | 0.0706 |     - |     - |     224 B |
|                     ValueLinq_SharedPool_Pull |   100 | 1,191.6 ns | 4.60 ns | 4.30 ns |  3.52 |    0.02 | 0.0706 |     - |     - |     224 B |
|                ValueLinq_ValueLambda_Standard |   100 |   658.7 ns | 1.78 ns | 1.67 ns |  1.95 |    0.01 | 0.0706 |     - |     - |     224 B |
|                   ValueLinq_ValueLambda_Stack |   100 |   621.6 ns | 2.03 ns | 1.80 ns |  1.84 |    0.01 | 0.0706 |     - |     - |     224 B |
|         ValueLinq_ValueLambda_SharedPool_Push |   100 |   703.4 ns | 1.46 ns | 1.37 ns |  2.08 |    0.01 | 0.0706 |     - |     - |     224 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |   100 |   913.4 ns | 1.17 ns | 0.92 ns |  2.70 |    0.01 | 0.0706 |     - |     - |     224 B |
|                    ValueLinq_Standard_ByIndex |   100 |   770.2 ns | 1.72 ns | 1.52 ns |  2.28 |    0.02 | 0.0706 |     - |     - |     224 B |
|                       ValueLinq_Stack_ByIndex |   100 |   759.5 ns | 1.41 ns | 1.25 ns |  2.24 |    0.01 | 0.0706 |     - |     - |     224 B |
|             ValueLinq_SharedPool_Push_ByIndex |   100 | 1,178.8 ns | 3.04 ns | 2.70 ns |  3.48 |    0.02 | 0.0706 |     - |     - |     224 B |
|             ValueLinq_SharedPool_Pull_ByIndex |   100 | 1,010.4 ns | 4.78 ns | 4.47 ns |  2.99 |    0.02 | 0.0706 |     - |     - |     224 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |   100 |   476.2 ns | 2.39 ns | 2.24 ns |  1.41 |    0.01 | 0.0706 |     - |     - |     224 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |   100 |   417.9 ns | 0.77 ns | 0.68 ns |  1.24 |    0.01 | 0.0710 |     - |     - |     224 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |   100 |   709.4 ns | 1.43 ns | 1.12 ns |  2.10 |    0.01 | 0.0706 |     - |     - |     224 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |   100 |   730.9 ns | 2.10 ns | 1.86 ns |  2.16 |    0.01 | 0.0706 |     - |     - |     224 B |
|                                       ForLoop |   100 |   338.4 ns | 1.90 ns | 1.78 ns |  1.00 |    0.00 | 0.2780 |     - |     - |     872 B |
|                                   ForeachLoop |   100 |   613.2 ns | 1.79 ns | 1.68 ns |  1.81 |    0.01 | 0.2775 |     - |     - |     872 B |
|                                          Linq |   100 |   804.5 ns | 3.00 ns | 2.80 ns |  2.38 |    0.01 | 0.2623 |     - |     - |     824 B |
|                                    LinqFaster |   100 |   625.3 ns | 3.14 ns | 2.79 ns |  1.85 |    0.01 | 0.2775 |     - |     - |     872 B |
|                                        LinqAF |   100 | 1,419.8 ns | 4.54 ns | 4.25 ns |  4.20 |    0.03 | 0.2670 |     - |     - |     840 B |
|                                    StructLinq |   100 |   675.2 ns | 1.58 ns | 1.40 ns |  2.00 |    0.01 | 0.1011 |     - |     - |     320 B |
|                          StructLinq_IFunction |   100 |   354.4 ns | 1.12 ns | 1.04 ns |  1.05 |    0.01 | 0.0710 |     - |     - |     224 B |
|                                     Hyperlinq |   100 |   830.2 ns | 1.74 ns | 1.54 ns |  2.45 |    0.01 | 0.0706 |     - |     - |     224 B |
|                           Hyperlinq_IFunction |   100 |   459.1 ns | 0.58 ns | 0.49 ns |  1.36 |    0.01 | 0.0710 |     - |     - |     224 B |
|                                Hyperlinq_Pool |   100 |   944.5 ns | 1.51 ns | 1.34 ns |  2.79 |    0.01 | 0.0172 |     - |     - |      56 B |
|                      Hyperlinq_Pool_IFunction |   100 |   591.4 ns | 3.15 ns | 2.94 ns |  1.75 |    0.01 | 0.0172 |     - |     - |      56 B |
|                                      Tinyield |   100 | 1,971.5 ns | 6.56 ns | 6.14 ns |  5.83 |    0.04 | 0.4272 |     - |     - |    1352 B |
