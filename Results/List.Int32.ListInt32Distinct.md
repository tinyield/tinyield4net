## List.Int32.ListInt32Distinct

### Source
[ListInt32Distinct.cs](../LinqBenchmarks/List/Int32/ListInt32Distinct.cs)

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
|               Method | Duplicates | Count |        Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------- |------ |------------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|              ForLoop |          4 |   100 |  4,369.9 ns | 23.26 ns | 20.62 ns |  1.00 | 1.9150 |     - |     - |    6008 B |
|          ForeachLoop |          4 |   100 |  5,014.0 ns | 23.96 ns | 21.24 ns |  1.15 | 1.9150 |     - |     - |    6008 B |
|                 Linq |          4 |   100 |  9,414.3 ns | 36.34 ns | 33.99 ns |  2.15 | 1.3733 |     - |     - |    4320 B |
|           LinqFaster |          4 |   100 |    888.4 ns |  3.70 ns |  3.46 ns |  0.20 |      - |     - |     - |         - |
|               LinqAF |          4 |   100 | 12,174.5 ns | 24.72 ns | 23.12 ns |  2.79 | 3.9520 |     - |     - |   12400 B |
|           StructLinq |          4 |   100 |  4,684.5 ns |  8.74 ns |  7.75 ns |  1.07 | 0.0076 |     - |     - |      32 B |
| StructLinq_IFunction |          4 |   100 |  4,807.2 ns | 12.12 ns | 11.33 ns |  1.10 |      - |     - |     - |         - |
|            Hyperlinq |          4 |   100 |  4,946.5 ns | 14.37 ns | 12.74 ns |  1.13 |      - |     - |     - |         - |
|             Tinyield |          4 |   100 |  8,006.4 ns | 54.32 ns | 50.81 ns |  1.83 | 2.0142 |     - |     - |    6352 B |
