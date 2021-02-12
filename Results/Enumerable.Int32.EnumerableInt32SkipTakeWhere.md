## Enumerable.Int32.EnumerableInt32SkipTakeWhere

### Source
[EnumerableInt32SkipTakeWhere.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeWhere.cs)

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
|               Method | Skip | Count |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop | 1000 |   100 |  4.334 μs | 0.0125 μs | 0.0111 μs |  1.00 | 0.0076 |     - |     - |      40 B |
|                 Linq | 1000 |   100 |  6.289 μs | 0.0143 μs | 0.0127 μs |  1.45 | 0.0610 |     - |     - |     208 B |
|               LinqAF | 1000 |   100 |  6.028 μs | 0.0128 μs | 0.0120 μs |  1.39 | 0.0076 |     - |     - |      40 B |
|           StructLinq | 1000 |   100 |  5.037 μs | 0.0161 μs | 0.0143 μs |  1.16 | 0.0381 |     - |     - |     128 B |
| StructLinq_IFunction | 1000 |   100 |  4.563 μs | 0.0195 μs | 0.0182 μs |  1.05 | 0.0076 |     - |     - |      40 B |
|            Hyperlinq | 1000 |   100 |  4.890 μs | 0.0174 μs | 0.0162 μs |  1.13 | 0.0076 |     - |     - |      40 B |
|  Hyperlinq_IFunction | 1000 |   100 |  4.657 μs | 0.0162 μs | 0.0152 μs |  1.07 | 0.0076 |     - |     - |      40 B |
|             Tinyield | 1000 |   100 | 14.688 μs | 0.0479 μs | 0.0448 μs |  3.39 | 0.1373 |     - |     - |     472 B |
