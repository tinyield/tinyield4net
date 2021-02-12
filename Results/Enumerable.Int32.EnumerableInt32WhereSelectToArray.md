## Enumerable.Int32.EnumerableInt32WhereSelectToArray

### Source
[EnumerableInt32WhereSelectToArray.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToArray.cs)

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
|                                Method | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard |   100 | 1,399.9 ns | 2.60 ns | 2.31 ns |  1.49 | 0.0839 |     - |     - |     264 B |
|                       ValueLinq_Stack |   100 | 1,350.4 ns | 2.79 ns | 2.47 ns |  1.44 | 0.0839 |     - |     - |     264 B |
|             ValueLinq_SharedPool_Push |   100 | 1,736.1 ns | 3.64 ns | 3.40 ns |  1.85 | 0.0839 |     - |     - |     264 B |
|             ValueLinq_SharedPool_Pull |   100 | 1,600.2 ns | 2.85 ns | 2.52 ns |  1.70 | 0.0839 |     - |     - |     264 B |
|        ValueLinq_ValueLambda_Standard |   100 | 1,077.8 ns | 6.17 ns | 5.77 ns |  1.15 | 0.0839 |     - |     - |     264 B |
|           ValueLinq_ValueLambda_Stack |   100 | 1,017.2 ns | 3.88 ns | 3.63 ns |  1.08 | 0.0839 |     - |     - |     264 B |
| ValueLinq_ValueLambda_SharedPool_Push |   100 | 1,368.0 ns | 3.10 ns | 2.75 ns |  1.46 | 0.0839 |     - |     - |     264 B |
| ValueLinq_ValueLambda_SharedPool_Pull |   100 | 1,259.3 ns | 3.58 ns | 3.17 ns |  1.34 | 0.0839 |     - |     - |     264 B |
|                           ForeachLoop |   100 |   939.3 ns | 1.95 ns | 1.82 ns |  1.00 | 0.2899 |     - |     - |     912 B |
|                                  Linq |   100 | 1,451.1 ns | 3.78 ns | 3.53 ns |  1.54 | 0.2651 |     - |     - |     832 B |
|                                LinqAF |   100 | 1,519.0 ns | 4.92 ns | 4.36 ns |  1.62 | 0.2785 |     - |     - |     880 B |
|                            StructLinq |   100 | 1,284.9 ns | 4.50 ns | 3.98 ns |  1.37 | 0.1106 |     - |     - |     352 B |
|                  StructLinq_IFunction |   100 | 1,049.9 ns | 3.28 ns | 2.90 ns |  1.12 | 0.0839 |     - |     - |     264 B |
|                             Hyperlinq |   100 | 1,407.9 ns | 4.85 ns | 4.54 ns |  1.50 | 0.0839 |     - |     - |     264 B |
|                   Hyperlinq_IFunction |   100 | 1,083.1 ns | 4.23 ns | 3.53 ns |  1.15 | 0.0839 |     - |     - |     264 B |
|                        Hyperlinq_Pool |   100 | 1,506.6 ns | 6.67 ns | 6.24 ns |  1.60 | 0.0305 |     - |     - |      96 B |
|              Hyperlinq_Pool_IFunction |   100 | 1,167.2 ns | 2.93 ns | 2.60 ns |  1.24 | 0.0305 |     - |     - |      96 B |
|                              Tinyield |   100 | 1,727.3 ns | 5.85 ns | 5.47 ns |  1.84 | 0.4292 |     - |     - |    1352 B |
