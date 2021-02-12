## List.ValueType.ListValueTypeWhere

### Source
[ListValueTypeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhere.cs)

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
|               Method | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 |   667.3 ns |  0.52 ns |  0.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 |   936.4 ns |  1.08 ns |  1.01 ns |  1.40 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 | 1,562.7 ns | 26.69 ns | 24.97 ns |  2.35 |    0.03 | 0.0420 |     - |     - |     136 B |
|           LinqFaster |   100 | 1,491.1 ns |  9.09 ns |  8.50 ns |  2.23 |    0.01 | 1.6270 |     - |     - |    5112 B |
|               LinqAF |   100 | 1,906.1 ns | 37.68 ns | 38.70 ns |  2.87 |    0.06 |      - |     - |     - |         - |
|           StructLinq |   100 |   810.1 ns |  0.98 ns |  0.92 ns |  1.21 |    0.00 | 0.0124 |     - |     - |      40 B |
| StructLinq_IFunction |   100 |   694.4 ns |  0.91 ns |  0.85 ns |  1.04 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 |   738.6 ns |  0.66 ns |  0.58 ns |  1.11 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 |   675.9 ns |  0.80 ns |  0.71 ns |  1.01 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 | 2,094.7 ns | 13.43 ns | 11.90 ns |  3.14 |    0.02 | 0.1297 |     - |     - |     408 B |
