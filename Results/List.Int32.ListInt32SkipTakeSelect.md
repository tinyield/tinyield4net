## List.Int32.ListInt32SkipTakeSelect

### Source
[ListInt32SkipTakeSelect.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeSelect.cs)

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
  [Host]        : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT  [AttachedDebugger]
  .NET Core 5.0 : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|                      Method | Skip | Count |        Mean |     Error |      StdDev |  Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |------------:|----------:|------------:|-------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | 1000 |   100 |    116.8 ns |   0.64 ns |     0.57 ns |   1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | 1000 |   100 |  4,868.8 ns |  15.02 ns |    12.54 ns |  41.69 |    0.26 | 0.0076 |     - |     - |      40 B |
|                        Linq | 1000 |   100 |  1,344.2 ns |  10.37 ns |     9.70 ns |  11.52 |    0.11 | 0.0477 |     - |     - |     152 B |
|                  LinqFaster | 1000 |   100 |  1,116.5 ns |   8.75 ns |     8.18 ns |   9.57 |    0.08 | 0.4349 |     - |     - |    1368 B |
|                      LinqAF | 1000 |   100 | 18,665.9 ns | 745.74 ns | 2,053.98 ns | 170.66 |   14.42 |      - |     - |     - |         - |
|                  StructLinq | 1000 |   100 |    391.4 ns |   1.69 ns |     1.50 ns |   3.35 |    0.02 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |   100 |    236.7 ns |   0.66 ns |     0.62 ns |   2.03 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |   100 |    312.2 ns |   1.98 ns |     1.85 ns |   2.67 |    0.02 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |   100 |    227.8 ns |   0.35 ns |     0.29 ns |   1.95 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |   100 |    309.5 ns |   1.31 ns |     1.16 ns |   2.65 |    0.02 |      - |     - |     - |         - |
|                    Tinyield | 1000 |   100 | 17,464.8 ns |  76.30 ns |    67.64 ns | 149.57 |    1.01 | 0.1221 |     - |     - |     472 B |
