## Last.FM.ZipTopArtistAndTrackByCountryBenchmark

### Source
[ZipTopArtistAndTrackByCountryBenchmark.cs](../LinqBenchmarks/Last/FM/ZipTopArtistAndTrackByCountryBenchmark.cs)

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
|      Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |------------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
| ForeachLoop |   100 |    50.55 μs |  0.459 μs |  0.429 μs |  1.00 |    0.00 |   7.6904 |     - |     - |  23.65 KB |
|        Linq |   100 |   105.87 μs |  1.070 μs |  0.893 μs |  2.10 |    0.03 |  12.6953 |     - |     - |  39.05 KB |
|      LinqAF |   100 |   346.29 μs | 23.588 μs | 65.755 μs |  8.21 |    1.39 |        - |     - |     - |  161.9 KB |
|   Hyperlinq |   100 |   106.94 μs |  2.135 μs |  5.586 μs |  2.23 |    0.13 |   4.8828 |     - |     - |  15.61 KB |
|    Tinyield |   100 | 2,201.85 μs | 43.235 μs | 98.467 μs | 42.36 |    1.35 | 113.2813 |     - |     - | 354.12 KB |
