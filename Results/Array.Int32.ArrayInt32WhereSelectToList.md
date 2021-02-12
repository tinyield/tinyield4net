## Array.Int32.ArrayInt32WhereSelectToList

### Source
[ArrayInt32WhereSelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToList.cs)

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
|                                Method | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard |   100 |   741.5 ns | 3.45 ns | 3.23 ns |  2.41 |    0.02 | 0.2060 |     - |     - |     648 B |
|                       ValueLinq_Stack |   100 |   793.7 ns | 2.91 ns | 2.72 ns |  2.58 |    0.02 | 0.0811 |     - |     - |     256 B |
|             ValueLinq_SharedPool_Push |   100 | 1,216.0 ns | 3.95 ns | 3.69 ns |  3.95 |    0.02 | 0.0801 |     - |     - |     256 B |
|             ValueLinq_SharedPool_Pull |   100 | 1,103.2 ns | 6.28 ns | 5.87 ns |  3.58 |    0.03 | 0.0801 |     - |     - |     256 B |
|        ValueLinq_ValueLambda_Standard |   100 |   473.4 ns | 2.47 ns | 2.31 ns |  1.54 |    0.01 | 0.2060 |     - |     - |     648 B |
|           ValueLinq_ValueLambda_Stack |   100 |   519.9 ns | 3.66 ns | 3.42 ns |  1.69 |    0.02 | 0.0811 |     - |     - |     256 B |
| ValueLinq_ValueLambda_SharedPool_Push |   100 |   855.1 ns | 4.17 ns | 3.90 ns |  2.78 |    0.02 | 0.0811 |     - |     - |     256 B |
| ValueLinq_ValueLambda_SharedPool_Pull |   100 |   908.8 ns | 3.74 ns | 3.50 ns |  2.95 |    0.02 | 0.0811 |     - |     - |     256 B |
|                               ForLoop |   100 |   308.1 ns | 1.95 ns | 1.83 ns |  1.00 |    0.00 | 0.2065 |     - |     - |     648 B |
|                           ForeachLoop |   100 |   292.5 ns | 2.49 ns | 2.33 ns |  0.95 |    0.01 | 0.2065 |     - |     - |     648 B |
|                                  Linq |   100 |   691.8 ns | 3.07 ns | 2.87 ns |  2.25 |    0.02 | 0.2394 |     - |     - |     752 B |
|                            LinqFaster |   100 |   561.1 ns | 2.75 ns | 2.57 ns |  1.82 |    0.01 | 0.2880 |     - |     - |     904 B |
|                                LinqAF |   100 |   865.3 ns | 2.39 ns | 2.12 ns |  2.81 |    0.02 | 0.2060 |     - |     - |     648 B |
|                            StructLinq |   100 |   732.7 ns | 2.43 ns | 2.27 ns |  2.38 |    0.02 | 0.1116 |     - |     - |     352 B |
|                  StructLinq_IFunction |   100 |   373.8 ns | 1.99 ns | 1.86 ns |  1.21 |    0.01 | 0.0815 |     - |     - |     256 B |
|                             Hyperlinq |   100 |   855.9 ns | 1.72 ns | 1.34 ns |  2.78 |    0.02 | 0.0811 |     - |     - |     256 B |
|                   Hyperlinq_IFunction |   100 |   500.3 ns | 5.20 ns | 4.61 ns |  1.62 |    0.02 | 0.0811 |     - |     - |     256 B |
|                              Tinyield |   100 | 1,109.9 ns | 6.07 ns | 5.68 ns |  3.60 |    0.03 | 0.3490 |     - |     - |    1096 B |
