## List.Int32.ListInt32WhereSelectToList

### Source
[ListInt32WhereSelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToList.cs)

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
|                                        Method | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                            ValueLinq_Standard |   100 |   752.9 ns |  3.11 ns |  2.91 ns |  2.37 |    0.01 | 0.2060 |     - |     - |     648 B |
|                               ValueLinq_Stack |   100 | 1,068.8 ns |  2.94 ns |  2.75 ns |  3.36 |    0.01 | 0.0801 |     - |     - |     256 B |
|                     ValueLinq_SharedPool_Push |   100 | 1,236.6 ns |  6.14 ns |  5.75 ns |  3.88 |    0.03 | 0.0801 |     - |     - |     256 B |
|                     ValueLinq_SharedPool_Pull |   100 | 1,436.2 ns |  9.54 ns |  8.92 ns |  4.52 |    0.03 | 0.0801 |     - |     - |     256 B |
|                ValueLinq_ValueLambda_Standard |   100 |   489.8 ns |  3.87 ns |  3.62 ns |  1.54 |    0.01 | 0.2060 |     - |     - |     648 B |
|                   ValueLinq_ValueLambda_Stack |   100 |   745.3 ns |  1.55 ns |  1.45 ns |  2.34 |    0.01 | 0.0811 |     - |     - |     256 B |
|         ValueLinq_ValueLambda_SharedPool_Push |   100 |   868.5 ns |  1.72 ns |  1.61 ns |  2.73 |    0.01 | 0.0811 |     - |     - |     256 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |   100 | 1,097.8 ns |  2.97 ns |  2.48 ns |  3.45 |    0.02 | 0.0801 |     - |     - |     256 B |
|                    ValueLinq_Standard_ByIndex |   100 |   788.4 ns |  1.49 ns |  1.24 ns |  2.48 |    0.01 | 0.2060 |     - |     - |     648 B |
|                       ValueLinq_Stack_ByIndex |   100 |   849.3 ns |  1.88 ns |  1.67 ns |  2.67 |    0.01 | 0.0811 |     - |     - |     256 B |
|             ValueLinq_SharedPool_Push_ByIndex |   100 | 1,301.7 ns |  2.39 ns |  2.00 ns |  4.09 |    0.02 | 0.0801 |     - |     - |     256 B |
|             ValueLinq_SharedPool_Pull_ByIndex |   100 | 1,167.2 ns |  8.45 ns |  7.90 ns |  3.67 |    0.02 | 0.0801 |     - |     - |     256 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |   100 |   507.0 ns |  2.59 ns |  2.30 ns |  1.59 |    0.01 | 0.2060 |     - |     - |     648 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |   100 |   519.5 ns |  2.52 ns |  2.36 ns |  1.63 |    0.01 | 0.0811 |     - |     - |     256 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |   100 |   860.7 ns |  1.94 ns |  1.51 ns |  2.70 |    0.01 | 0.0811 |     - |     - |     256 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |   100 |   881.1 ns |  1.33 ns |  1.04 ns |  2.77 |    0.01 | 0.0811 |     - |     - |     256 B |
|                                       ForLoop |   100 |   318.3 ns |  1.62 ns |  1.35 ns |  1.00 |    0.00 | 0.2065 |     - |     - |     648 B |
|                                   ForeachLoop |   100 |   587.3 ns |  2.10 ns |  1.97 ns |  1.85 |    0.01 | 0.2060 |     - |     - |     648 B |
|                                          Linq |   100 |   778.9 ns |  2.43 ns |  2.16 ns |  2.45 |    0.01 | 0.2546 |     - |     - |     800 B |
|                                    LinqFaster |   100 |   618.4 ns |  2.10 ns |  1.96 ns |  1.94 |    0.01 | 0.2880 |     - |     - |     904 B |
|                                        LinqAF |   100 | 1,402.6 ns |  2.91 ns |  2.58 ns |  4.41 |    0.02 | 0.2060 |     - |     - |     648 B |
|                                    StructLinq |   100 |   759.3 ns |  1.97 ns |  1.85 ns |  2.39 |    0.01 | 0.1116 |     - |     - |     352 B |
|                          StructLinq_IFunction |   100 |   382.2 ns |  1.04 ns |  0.97 ns |  1.20 |    0.01 | 0.0815 |     - |     - |     256 B |
|                                     Hyperlinq |   100 |   852.6 ns |  1.77 ns |  1.66 ns |  2.68 |    0.01 | 0.0811 |     - |     - |     256 B |
|                           Hyperlinq_IFunction |   100 |   478.4 ns |  2.04 ns |  1.81 ns |  1.50 |    0.01 | 0.0811 |     - |     - |     256 B |
|                                      Tinyield |   100 | 1,968.4 ns | 12.20 ns | 11.41 ns |  6.19 |    0.04 | 0.3586 |     - |     - |    1128 B |
