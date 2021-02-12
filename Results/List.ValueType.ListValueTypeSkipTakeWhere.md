## List.ValueType.ListValueTypeSkipTakeWhere

### Source
[ListValueTypeSkipTakeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeWhere.cs)

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
|               Method | Skip | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | 1000 |   100 |    809.6 ns |   1.74 ns |   1.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | 1000 |   100 |  5,653.8 ns |   6.36 ns |   5.31 ns |  6.98 |    0.02 | 0.0229 |     - |     - |      72 B |
|                 Linq | 1000 |   100 |  2,120.0 ns |   6.96 ns |   6.51 ns |  2.62 |    0.01 | 0.0763 |     - |     - |     248 B |
|           LinqFaster | 1000 |   100 |  3,186.3 ns |  41.80 ns |  39.10 ns |  3.93 |    0.05 | 4.2114 |     - |     - |   13224 B |
|               LinqAF | 1000 |   100 | 12,089.6 ns | 207.43 ns | 194.03 ns | 14.92 |    0.24 |      - |     - |     - |         - |
|           StructLinq | 1000 |   100 |    895.3 ns |   1.15 ns |   1.08 ns |  1.11 |    0.00 | 0.0381 |     - |     - |     120 B |
| StructLinq_IFunction | 1000 |   100 |  1,213.0 ns |   0.71 ns |   0.66 ns |  1.50 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |   100 |    724.2 ns |   1.05 ns |   0.88 ns |  0.89 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |   100 |    677.0 ns |   0.72 ns |   0.63 ns |  0.84 |    0.00 |      - |     - |     - |         - |
|             Tinyield | 1000 |   100 | 18,483.4 ns |  34.96 ns |  30.99 ns | 22.83 |    0.07 | 0.1526 |     - |     - |     536 B |
