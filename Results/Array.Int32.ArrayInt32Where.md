## Array.Int32.ArrayInt32Where

### Source
[ArrayInt32Where.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Where.cs)

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
|              ForLoop |   100 | 104.7 ns | 0.15 ns | 0.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 | 104.7 ns | 0.23 ns | 0.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 | 611.3 ns | 1.84 ns | 1.72 ns |  5.84 |    0.02 | 0.0153 |     - |     - |      48 B |
|           LinqFaster |   100 | 389.1 ns | 1.87 ns | 1.66 ns |  3.72 |    0.02 | 0.2065 |     - |     - |     648 B |
|               LinqAF |   100 | 492.4 ns | 1.10 ns | 0.97 ns |  4.70 |    0.01 |      - |     - |     - |         - |
|           StructLinq |   100 | 376.7 ns | 0.83 ns | 0.78 ns |  3.60 |    0.01 | 0.0100 |     - |     - |      32 B |
| StructLinq_IFunction |   100 | 237.3 ns | 0.37 ns | 0.35 ns |  2.27 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 | 355.5 ns | 1.09 ns | 1.02 ns |  3.40 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 | 258.1 ns | 0.59 ns | 0.53 ns |  2.47 |    0.01 |      - |     - |     - |         - |
|             Tinyield |   100 | 633.9 ns | 2.68 ns | 2.51 ns |  6.06 |    0.02 | 0.0992 |     - |     - |     312 B |
