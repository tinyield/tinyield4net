## Array.ValueType.ArrayValueTypeWhereSelectToList

### Source
[ArrayValueTypeWhereSelectToList.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToList.cs)

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
|                                Method | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard |   100 | 1.973 μs | 0.0274 μs | 0.0256 μs |  1.79 |    0.03 | 1.6251 |     - |     - |   4.99 KB |
|                       ValueLinq_Stack |   100 | 1.702 μs | 0.0059 μs | 0.0055 μs |  1.55 |    0.02 | 0.6542 |     - |     - |   2.01 KB |
|             ValueLinq_SharedPool_Push |   100 | 2.359 μs | 0.0372 μs | 0.0348 μs |  2.14 |    0.03 | 0.6523 |     - |     - |   2.01 KB |
|             ValueLinq_SharedPool_Pull |   100 | 1.942 μs | 0.0148 μs | 0.0139 μs |  1.76 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|                ValueLinq_Ref_Standard |   100 | 2.381 μs | 0.0132 μs | 0.0124 μs |  2.16 |    0.03 | 1.6270 |     - |     - |   4.99 KB |
|                   ValueLinq_Ref_Stack |   100 | 1.493 μs | 0.0069 μs | 0.0064 μs |  1.36 |    0.02 | 0.6542 |     - |     - |   2.01 KB |
|         ValueLinq_Ref_SharedPool_Push |   100 | 2.158 μs | 0.0189 μs | 0.0177 μs |  1.96 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|         ValueLinq_Ref_SharedPool_Pull |   100 | 1.892 μs | 0.0152 μs | 0.0143 μs |  1.72 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
|        ValueLinq_ValueLambda_Standard |   100 | 1.495 μs | 0.0128 μs | 0.0120 μs |  1.36 |    0.02 | 1.6270 |     - |     - |   4.99 KB |
|           ValueLinq_ValueLambda_Stack |   100 | 1.526 μs | 0.0120 μs | 0.0112 μs |  1.39 |    0.02 | 0.6542 |     - |     - |   2.01 KB |
| ValueLinq_ValueLambda_SharedPool_Push |   100 | 1.895 μs | 0.0132 μs | 0.0123 μs |  1.72 |    0.02 | 0.6523 |     - |     - |   2.01 KB |
| ValueLinq_ValueLambda_SharedPool_Pull |   100 | 1.881 μs | 0.0072 μs | 0.0060 μs |  1.71 |    0.02 | 0.6542 |     - |     - |   2.01 KB |
|                               ForLoop |   100 | 1.101 μs | 0.0119 μs | 0.0112 μs |  1.00 |    0.00 | 1.6270 |     - |     - |   4.99 KB |
|                           ForeachLoop |   100 | 1.169 μs | 0.0114 μs | 0.0107 μs |  1.06 |    0.02 | 1.6270 |     - |     - |   4.99 KB |
|                                  Linq |   100 | 1.678 μs | 0.0208 μs | 0.0194 μs |  1.52 |    0.03 | 1.6823 |     - |     - |   5.16 KB |
|                            LinqFaster |   100 | 1.630 μs | 0.0144 μs | 0.0134 μs |  1.48 |    0.02 | 2.5806 |     - |     - |   7.91 KB |
|                                LinqAF |   100 | 2.897 μs | 0.0572 μs | 0.0535 μs |  2.63 |    0.06 | 1.6251 |     - |     - |   4.99 KB |
|                            StructLinq |   100 | 1.667 μs | 0.0066 μs | 0.0062 μs |  1.51 |    0.01 | 0.6847 |     - |     - |    2.1 KB |
|                  StructLinq_IFunction |   100 | 1.184 μs | 0.0073 μs | 0.0068 μs |  1.08 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                             Hyperlinq |   100 | 1.491 μs | 0.0065 μs | 0.0058 μs |  1.36 |    0.02 | 0.6542 |     - |     - |   2.01 KB |
|                   Hyperlinq_IFunction |   100 | 1.136 μs | 0.0051 μs | 0.0048 μs |  1.03 |    0.01 | 0.6542 |     - |     - |   2.01 KB |
|                              Tinyield |   100 | 2.117 μs | 0.0204 μs | 0.0190 μs |  1.92 |    0.01 | 1.7700 |     - |     - |   5.43 KB |
