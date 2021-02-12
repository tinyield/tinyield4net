## List.Int32.ListInt32Select

### Source
[ListInt32Select.cs](../LinqBenchmarks/List/Int32/ListInt32Select.cs)

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
|                      Method | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop |   100 |   145.5 ns | 0.16 ns | 0.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop |   100 |   272.6 ns | 0.50 ns | 0.39 ns |  1.87 |    0.00 |      - |     - |     - |         - |
|                        Linq |   100 | 1,085.5 ns | 2.24 ns | 2.09 ns |  7.46 |    0.02 | 0.0229 |     - |     - |      72 B |
|                  LinqFaster |   100 |   482.6 ns | 3.30 ns | 3.09 ns |  3.32 |    0.02 | 0.1450 |     - |     - |     456 B |
|                      LinqAF |   100 |   856.7 ns | 1.12 ns | 0.94 ns |  5.89 |    0.01 |      - |     - |     - |         - |
|                  StructLinq |   100 |   321.3 ns | 0.59 ns | 0.55 ns |  2.21 |    0.01 | 0.0100 |     - |     - |      32 B |
|        StructLinq_IFunction |   100 |   233.2 ns | 0.28 ns | 0.26 ns |  1.60 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |   100 |   239.3 ns | 0.42 ns | 0.37 ns |  1.65 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |   100 |   223.9 ns | 0.28 ns | 0.26 ns |  1.54 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For |   100 |   264.6 ns | 0.47 ns | 0.42 ns |  1.82 |    0.00 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction |   100 |   125.7 ns | 0.18 ns | 0.17 ns |  0.86 |    0.00 |      - |     - |     - |         - |
|                    Tinyield |   100 | 1,402.9 ns | 3.07 ns | 2.87 ns |  9.64 |    0.03 | 0.1087 |     - |     - |     344 B |
