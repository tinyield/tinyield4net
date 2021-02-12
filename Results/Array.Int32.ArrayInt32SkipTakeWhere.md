## Array.Int32.ArrayInt32SkipTakeWhere

### Source
[ArrayInt32SkipTakeWhere.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeWhere.cs)

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
|               Method | Skip | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | 1000 |   100 |   103.8 ns |  0.25 ns |  0.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | 1000 |   100 | 3,245.3 ns |  5.78 ns |  5.41 ns | 31.27 |    0.09 | 0.0076 |     - |     - |      32 B |
|                 Linq | 1000 |   100 | 1,785.6 ns |  3.79 ns |  3.55 ns | 17.20 |    0.05 | 0.0477 |     - |     - |     152 B |
|           LinqFaster | 1000 |   100 |   484.7 ns |  4.03 ns |  3.77 ns |  4.67 |    0.04 | 0.4768 |     - |     - |    1496 B |
|               LinqAF | 1000 |   100 | 3,814.4 ns |  5.56 ns |  5.20 ns | 36.75 |    0.11 |      - |     - |     - |         - |
|           StructLinq | 1000 |   100 |   457.6 ns |  0.98 ns |  0.92 ns |  4.41 |    0.01 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |   100 |   238.0 ns |  0.77 ns |  0.72 ns |  2.29 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |   100 |   363.6 ns |  0.75 ns |  0.70 ns |  3.50 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |   100 |   259.5 ns |  0.73 ns |  0.68 ns |  2.50 |    0.01 |      - |     - |     - |         - |
|             Tinyield | 1000 |   100 | 8,534.5 ns | 42.27 ns | 39.54 ns | 82.22 |    0.39 | 0.1373 |     - |     - |     440 B |
