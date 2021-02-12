## List.ValueType.ListValueTypeWhereSelectToList

### Source
[ListValueTypeWhereSelectToList.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToList.cs)

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
|                                        Method | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                            ValueLinq_Standard |   100 | 1.939 μs | 0.0370 μs | 0.0346 μs |  1.61 |    0.03 | 1.6251 |     - |     - |   4.99 KB |
|                               ValueLinq_Stack |   100 | 1.887 μs | 0.0259 μs | 0.0230 μs |  1.57 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|                     ValueLinq_SharedPool_Push |   100 | 2.413 μs | 0.0424 μs | 0.0397 μs |  2.00 |    0.03 | 0.6523 |     - |     - |   2.01 KB |
|                     ValueLinq_SharedPool_Pull |   100 | 2.252 μs | 0.0285 μs | 0.0267 μs |  1.87 |    0.03 | 0.6523 |     - |     - |   2.01 KB |
|                        ValueLinq_Ref_Standard |   100 | 1.749 μs | 0.0108 μs | 0.0101 μs |  1.45 |    0.01 | 1.6270 |     - |     - |   4.99 KB |
|                           ValueLinq_Ref_Stack |   100 | 1.780 μs | 0.0049 μs | 0.0046 μs |  1.48 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                 ValueLinq_Ref_SharedPool_Push |   100 | 2.151 μs | 0.0103 μs | 0.0096 μs |  1.79 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|                 ValueLinq_Ref_SharedPool_Pull |   100 | 2.113 μs | 0.0124 μs | 0.0116 μs |  1.76 |    0.01 | 0.6523 |     - |     - |   2.01 KB |
|                ValueLinq_ValueLambda_Standard |   100 | 1.515 μs | 0.0096 μs | 0.0089 μs |  1.26 |    0.01 | 1.6270 |     - |     - |   4.99 KB |
|                   ValueLinq_ValueLambda_Stack |   100 | 1.734 μs | 0.0193 μs | 0.0180 μs |  1.44 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|         ValueLinq_ValueLambda_SharedPool_Push |   100 | 1.831 μs | 0.0076 μs | 0.0067 μs |  1.52 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|         ValueLinq_ValueLambda_SharedPool_Pull |   100 | 2.107 μs | 0.0132 μs | 0.0123 μs |  1.75 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|                    ValueLinq_Standard_ByIndex |   100 | 1.964 μs | 0.0369 μs | 0.0346 μs |  1.63 |    0.03 | 1.6251 |     - |     - |   4.99 KB |
|                       ValueLinq_Stack_ByIndex |   100 | 1.623 μs | 0.0135 μs | 0.0126 μs |  1.35 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|             ValueLinq_SharedPool_Push_ByIndex |   100 | 2.427 μs | 0.0342 μs | 0.0320 μs |  2.02 |    0.03 | 0.6523 |     - |     - |   2.01 KB |
|             ValueLinq_SharedPool_Pull_ByIndex |   100 | 2.009 μs | 0.0187 μs | 0.0175 μs |  1.67 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|                ValueLinq_Ref_Standard_ByIndex |   100 | 1.808 μs | 0.0065 μs | 0.0057 μs |  1.50 |    0.01 | 1.6270 |     - |     - |   4.99 KB |
|                   ValueLinq_Ref_Stack_ByIndex |   100 | 1.496 μs | 0.0076 μs | 0.0071 μs |  1.24 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|         ValueLinq_Ref_SharedPool_Push_ByIndex |   100 | 2.162 μs | 0.0138 μs | 0.0130 μs |  1.80 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|         ValueLinq_Ref_SharedPool_Pull_ByIndex |   100 | 1.904 μs | 0.0137 μs | 0.0128 μs |  1.58 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|        ValueLinq_ValueLambda_Standard_ByIndex |   100 | 1.534 μs | 0.0070 μs | 0.0062 μs |  1.27 |    0.01 | 1.6270 |     - |     - |   4.99 KB |
|           ValueLinq_ValueLambda_Stack_ByIndex |   100 | 1.502 μs | 0.0068 μs | 0.0064 μs |  1.25 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |   100 | 1.903 μs | 0.0089 μs | 0.0083 μs |  1.58 |    0.01 | 0.6523 |     - |     - |   2.01 KB |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |   100 | 1.842 μs | 0.0039 μs | 0.0037 μs |  1.53 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                                       ForLoop |   100 | 1.204 μs | 0.0081 μs | 0.0076 μs |  1.00 |    0.00 | 1.6270 |     - |     - |   4.99 KB |
|                                   ForeachLoop |   100 | 1.495 μs | 0.0088 μs | 0.0082 μs |  1.24 |    0.01 | 1.6270 |     - |     - |   4.99 KB |
|                                          Linq |   100 | 1.737 μs | 0.0287 μs | 0.0268 μs |  1.44 |    0.02 | 1.7166 |     - |     - |   5.27 KB |
|                                    LinqFaster |   100 | 1.887 μs | 0.0367 μs | 0.0451 μs |  1.57 |    0.04 | 2.2812 |     - |     - |      7 KB |
|                                        LinqAF |   100 | 3.506 μs | 0.0384 μs | 0.0359 μs |  2.91 |    0.04 | 1.6251 |     - |     - |   4.99 KB |
|                                    StructLinq |   100 | 1.625 μs | 0.0044 μs | 0.0041 μs |  1.35 |    0.01 | 0.6866 |     - |     - |   2.11 KB |
|                          StructLinq_IFunction |   100 | 1.210 μs | 0.0081 μs | 0.0076 μs |  1.01 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                                     Hyperlinq |   100 | 1.492 μs | 0.0060 μs | 0.0056 μs |  1.24 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                           Hyperlinq_IFunction |   100 | 1.133 μs | 0.0050 μs | 0.0047 μs |  0.94 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                                      Tinyield |   100 | 2.950 μs | 0.0125 μs | 0.0117 μs |  2.45 |    0.02 | 1.7891 |     - |     - |   5.49 KB |
