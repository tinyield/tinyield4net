## Last.FM.ArtistsInTopTenWithTopTenTracksByCountryBenchmark

### Source
[ArtistsInTopTenWithTopTenTracksByCountryBenchmark.cs](../LinqBenchmarks/Last/FM/ArtistsInTopTenWithTopTenTracksByCountryBenchmark.cs)

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
.NET Core SDK=5.0.103
  [Host]        : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  .NET Core 5.0 : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|      Method | Count |       Mean |    Error |    StdDev |     Median | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |-----------:|---------:|----------:|-----------:|------:|--------:|---------:|------:|------:|----------:|
| ForeachLoop |   100 |   187.9 μs |  2.73 μs |   2.42 μs |   186.8 μs |  1.00 |    0.00 |  25.6348 |     - |     - |  78.55 KB |
|        Linq |   100 |   296.6 μs |  4.53 μs |   4.24 μs |   297.9 μs |  1.58 |    0.03 |  35.1563 |     - |     - | 108.95 KB |
|      LinqAF |   100 |   908.1 μs | 66.09 μs | 190.69 μs |   853.3 μs |  5.97 |    0.84 |        - |     - |     - | 229.41 KB |
|   Hyperlinq |   100 |   281.8 μs |  3.95 μs |   3.50 μs |   282.6 μs |  1.50 |    0.03 |  18.0664 |     - |     - |  56.65 KB |
|    Tinyield |   100 | 2,326.8 μs | 26.17 μs |  23.20 μs | 2,326.6 μs | 12.38 |    0.21 | 152.3438 |     - |     - | 472.41 KB |
