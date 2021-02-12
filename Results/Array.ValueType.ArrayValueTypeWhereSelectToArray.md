## Array.ValueType.ArrayValueTypeWhereSelectToArray

### Source
[ArrayValueTypeWhereSelectToArray.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToArray.cs)

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
|                    ValueLinq_Standard |   100 | 1.422 μs | 0.0091 μs | 0.0086 μs |  1.11 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                       ValueLinq_Stack |   100 | 1.365 μs | 0.0083 μs | 0.0078 μs |  1.06 |    0.01 | 0.6447 |     - |     - |    2024 B |
|             ValueLinq_SharedPool_Push |   100 | 2.215 μs | 0.0433 μs | 0.0405 μs |  1.73 |    0.03 | 0.6447 |     - |     - |    2024 B |
|             ValueLinq_SharedPool_Pull |   100 | 1.746 μs | 0.0061 μs | 0.0057 μs |  1.36 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                ValueLinq_Ref_Standard |   100 | 1.407 μs | 0.0066 μs | 0.0062 μs |  1.10 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                   ValueLinq_Ref_Stack |   100 | 1.365 μs | 0.0085 μs | 0.0080 μs |  1.06 |    0.01 | 0.6447 |     - |     - |    2024 B |
|         ValueLinq_Ref_SharedPool_Push |   100 | 1.976 μs | 0.0145 μs | 0.0136 μs |  1.54 |    0.01 | 0.6447 |     - |     - |    2024 B |
|         ValueLinq_Ref_SharedPool_Pull |   100 | 1.698 μs | 0.0071 μs | 0.0067 μs |  1.32 |    0.01 | 0.6447 |     - |     - |    2024 B |
|        ValueLinq_ValueLambda_Standard |   100 | 1.394 μs | 0.0084 μs | 0.0078 μs |  1.09 |    0.01 | 0.6447 |     - |     - |    2024 B |
|           ValueLinq_ValueLambda_Stack |   100 | 1.330 μs | 0.0074 μs | 0.0069 μs |  1.04 |    0.01 | 0.6447 |     - |     - |    2024 B |
| ValueLinq_ValueLambda_SharedPool_Push |   100 | 1.673 μs | 0.0069 μs | 0.0065 μs |  1.30 |    0.01 | 0.6447 |     - |     - |    2024 B |
| ValueLinq_ValueLambda_SharedPool_Pull |   100 | 1.672 μs | 0.0048 μs | 0.0045 μs |  1.30 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                               ForLoop |   100 | 1.282 μs | 0.0117 μs | 0.0110 μs |  1.00 |    0.00 | 2.2736 |     - |     - |    7136 B |
|                           ForeachLoop |   100 | 1.351 μs | 0.0113 μs | 0.0106 μs |  1.05 |    0.01 | 2.2736 |     - |     - |    7136 B |
|                                  Linq |   100 | 1.731 μs | 0.0184 μs | 0.0172 μs |  1.35 |    0.02 | 1.6212 |     - |     - |    5088 B |
|                            LinqFaster |   100 | 1.396 μs | 0.0089 μs | 0.0084 μs |  1.09 |    0.01 | 1.9264 |     - |     - |    6048 B |
|                                LinqAF |   100 | 2.967 μs | 0.0579 μs | 0.0542 μs |  2.31 |    0.05 | 2.2621 |     - |     - |    7104 B |
|                            StructLinq |   100 | 1.694 μs | 0.0049 μs | 0.0045 μs |  1.32 |    0.01 | 0.6752 |     - |     - |    2120 B |
|                  StructLinq_IFunction |   100 | 1.162 μs | 0.0080 μs | 0.0075 μs |  0.91 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                             Hyperlinq |   100 | 1.489 μs | 0.0058 μs | 0.0054 μs |  1.16 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                   Hyperlinq_IFunction |   100 | 1.135 μs | 0.0130 μs | 0.0122 μs |  0.89 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                        Hyperlinq_Pool |   100 | 1.432 μs | 0.0053 μs | 0.0049 μs |  1.12 |    0.01 | 0.0172 |     - |     - |      56 B |
|              Hyperlinq_Pool_IFunction |   100 | 1.118 μs | 0.0031 μs | 0.0029 μs |  0.87 |    0.01 | 0.0172 |     - |     - |      56 B |
|                              Tinyield |   100 | 2.323 μs | 0.0159 μs | 0.0149 μs |  1.81 |    0.02 | 2.4147 |     - |     - |    7584 B |
