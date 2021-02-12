## Array.ValueType.ArrayValueTypeSkipTakeWhere

### Source
[ArrayValueTypeSkipTakeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeWhere.cs)

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
|               Method | Skip | Count |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | 1000 |   100 |   594.2 ns |   4.47 ns |   4.18 ns |   594.7 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | 1000 |   100 | 3,358.3 ns |  12.62 ns |  11.80 ns | 3,356.1 ns |  5.65 |    0.05 | 0.0076 |     - |     - |      32 B |
|                 Linq | 1000 |   100 | 2,218.9 ns |  10.27 ns |   9.61 ns | 2,220.7 ns |  3.73 |    0.03 | 0.0763 |     - |     - |     248 B |
|           LinqFaster | 1000 |   100 | 1,971.3 ns |  14.42 ns |  13.49 ns | 1,969.1 ns |  3.32 |    0.04 | 4.4899 |     - |     - |   14096 B |
|               LinqAF | 1000 |   100 | 7,166.9 ns | 139.12 ns | 175.94 ns | 7,294.2 ns | 12.02 |    0.25 |      - |     - |     - |         - |
|           StructLinq | 1000 |   100 |   855.2 ns |   1.29 ns |   1.20 ns |   855.8 ns |  1.44 |    0.01 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |   100 |   687.1 ns |   1.36 ns |   1.20 ns |   687.3 ns |  1.16 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |   100 |   723.3 ns |   1.27 ns |   1.18 ns |   723.2 ns |  1.22 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |   100 |   659.0 ns |   1.39 ns |   1.30 ns |   659.4 ns |  1.11 |    0.01 |      - |     - |     - |         - |
|             Tinyield | 1000 |   100 | 9,587.0 ns |  62.20 ns |  55.14 ns | 9,569.6 ns | 16.14 |    0.18 | 0.1373 |     - |     - |     472 B |
