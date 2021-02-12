## Array.Int32.ArrayInt32WhereSelect

### Source
[ArrayInt32WhereSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelect.cs)

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
|               Method | Count |     Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |---------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 | 104.6 ns | 0.33 ns | 0.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 | 104.3 ns | 0.20 ns | 0.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 | 683.3 ns | 2.18 ns | 1.82 ns |  6.53 |    0.03 | 0.0324 |     - |     - |     104 B |
|           LinqFaster |   100 | 501.2 ns | 2.70 ns | 2.53 ns |  4.79 |    0.03 | 0.2060 |     - |     - |     648 B |
|               LinqAF |   100 | 608.8 ns | 2.05 ns | 1.92 ns |  5.82 |    0.02 |      - |     - |     - |         - |
|           StructLinq |   100 | 533.7 ns | 1.71 ns | 1.60 ns |  5.10 |    0.02 | 0.0200 |     - |     - |      64 B |
| StructLinq_IFunction |   100 | 255.5 ns | 0.58 ns | 0.51 ns |  2.44 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |   100 | 520.8 ns | 2.38 ns | 2.11 ns |  4.98 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 | 269.2 ns | 0.48 ns | 0.42 ns |  2.57 |    0.01 |      - |     - |     - |         - |
|             Tinyield |   100 | 862.8 ns | 2.29 ns | 1.92 ns |  8.24 |    0.03 | 0.1497 |     - |     - |     472 B |
