## List.Int32.ListInt32SkipTakeWhere

### Source
[ListInt32SkipTakeWhere.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeWhere.cs)

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
|               Method | Skip | Count |        Mean |    Error |   StdDev |  Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |------------:|---------:|---------:|-------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | 1000 |   100 |    115.1 ns |  0.11 ns |  0.10 ns |   1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | 1000 |   100 |  4,830.6 ns | 10.00 ns |  9.36 ns |  41.96 |    0.09 | 0.0076 |     - |     - |      40 B |
|                 Linq | 1000 |   100 |  1,722.8 ns |  2.68 ns |  2.37 ns |  14.96 |    0.02 | 0.0477 |     - |     - |     152 B |
|           LinqFaster | 1000 |   100 |  1,126.9 ns |  8.16 ns |  7.63 ns |   9.79 |    0.07 | 0.4959 |     - |     - |    1560 B |
|               LinqAF | 1000 |   100 |  7,443.7 ns |  8.61 ns |  7.63 ns |  64.65 |    0.11 |      - |     - |     - |         - |
|           StructLinq | 1000 |   100 |    432.8 ns |  0.69 ns |  0.65 ns |   3.76 |    0.01 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |   100 |    238.5 ns |  0.44 ns |  0.39 ns |   2.07 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |   100 |    344.1 ns |  0.46 ns |  0.43 ns |   2.99 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |   100 |    260.6 ns |  0.35 ns |  0.31 ns |   2.26 |    0.00 |      - |     - |     - |         - |
|             Tinyield | 1000 |   100 | 17,141.6 ns | 56.03 ns | 52.41 ns | 148.88 |    0.46 | 0.1221 |     - |     - |     472 B |
