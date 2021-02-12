## Array.Int32.ArrayInt32WhereCount

### Source
[ArrayInt32WhereCount.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereCount.cs)

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
|              ForLoop |   100 | 109.1 ns | 0.19 ns | 0.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 | 109.1 ns | 0.15 ns | 0.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 | 853.7 ns | 1.22 ns | 1.02 ns |  7.82 |    0.02 | 0.0095 |     - |     - |      32 B |
|           LinqFaster |   100 | 300.7 ns | 0.76 ns | 0.71 ns |  2.76 |    0.01 |      - |     - |     - |         - |
|               LinqAF |   100 | 355.2 ns | 1.29 ns | 1.21 ns |  3.25 |    0.01 |      - |     - |     - |         - |
|           StructLinq |   100 | 366.8 ns | 1.06 ns | 0.99 ns |  3.36 |    0.01 | 0.0200 |     - |     - |      64 B |
| StructLinq_IFunction |   100 | 115.1 ns | 0.27 ns | 0.25 ns |  1.05 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 | 266.5 ns | 0.83 ns | 0.77 ns |  2.44 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 | 109.3 ns | 0.36 ns | 0.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 | 570.5 ns | 2.58 ns | 2.42 ns |  5.23 |    0.03 | 0.0992 |     - |     - |     312 B |
