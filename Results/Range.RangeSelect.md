## Range.RangeSelect

### Source
[RangeSelect.cs](../LinqBenchmarks/Range/RangeSelect.cs)

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
|               Method | Start | Count |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------ |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |     0 |   100 |    54.27 ns | 0.091 ns | 0.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |     0 |   100 |   618.46 ns | 0.954 ns | 0.846 ns | 11.40 |    0.02 | 0.0172 |     - |     - |      56 B |
|                 Linq |     0 |   100 |   793.93 ns | 0.950 ns | 0.842 ns | 14.63 |    0.03 | 0.0277 |     - |     - |      88 B |
|           LinqFaster |     0 |   100 |   437.33 ns | 2.002 ns | 1.873 ns |  8.06 |    0.04 | 0.2699 |     - |     - |     848 B |
|               LinqAF |     0 |   100 |   590.51 ns | 1.119 ns | 1.047 ns | 10.88 |    0.02 |      - |     - |     - |         - |
|           StructLinq |     0 |   100 |   283.65 ns | 0.520 ns | 0.487 ns |  5.23 |    0.01 | 0.0076 |     - |     - |      24 B |
| StructLinq_IFunction |     0 |   100 |   230.27 ns | 0.193 ns | 0.181 ns |  4.24 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |     0 |   100 |   263.36 ns | 0.483 ns | 0.428 ns |  4.85 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |     0 |   100 |   235.50 ns | 0.305 ns | 0.286 ns |  4.34 |    0.01 |      - |     - |     - |         - |
|             Tinyield |     0 |   100 | 1,069.35 ns | 3.708 ns | 3.468 ns | 19.70 |    0.07 | 0.1183 |     - |     - |     376 B |
