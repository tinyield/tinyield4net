## List.Int32.ListInt32WhereSelect

### Source
[ListInt32WhereSelect.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelect.cs)

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
|               Method | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 |   171.3 ns | 0.25 ns | 0.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 |   290.0 ns | 0.84 ns | 0.75 ns |  1.69 |    0.01 |      - |     - |     - |         - |
|                 Linq |   100 | 1,089.0 ns | 2.18 ns | 2.04 ns |  6.36 |    0.01 | 0.0477 |     - |     - |     152 B |
|           LinqFaster |   100 |   641.8 ns | 2.55 ns | 2.38 ns |  3.75 |    0.02 | 0.2060 |     - |     - |     648 B |
|               LinqAF |   100 | 1,020.6 ns | 3.02 ns | 2.83 ns |  5.96 |    0.02 |      - |     - |     - |         - |
|           StructLinq |   100 |   505.1 ns | 1.10 ns | 0.98 ns |  2.95 |    0.01 | 0.0200 |     - |     - |      64 B |
| StructLinq_IFunction |   100 |   259.8 ns | 0.32 ns | 0.27 ns |  1.52 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 |   537.3 ns | 1.10 ns | 1.03 ns |  3.14 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 |   269.4 ns | 0.48 ns | 0.43 ns |  1.57 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 | 1,683.6 ns | 4.10 ns | 3.84 ns |  9.83 |    0.03 | 0.1602 |     - |     - |     504 B |
