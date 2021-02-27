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
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  Job-LGSKAU : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |------- |----------:|----------:|----------:|------:|--------:|
| **ForeachLoop** |   **1000** |  **57.83 μs** |  **0.311 μs** |  **0.138 μs** |  **1.00** |    **0.00** |
|        Linq |   1000 | 118.72 μs |  1.195 μs |  0.625 μs |  2.05 |    0.02 |
|      LinqAF |   1000 | 460.34 μs | 49.547 μs | 21.999 μs |  7.96 |    0.37 |
|   Hyperlinq |   1000 | 113.66 μs |  1.214 μs |  0.539 μs |  1.97 |    0.01 |
|    Tinyield |   1000 | 246.18 μs |  2.550 μs |  1.132 μs |  4.26 |    0.02 |
|             |        |           |           |           |       |         |
| **ForeachLoop** | **100000** |  **59.21 μs** |  **0.937 μs** |  **0.490 μs** |  **1.00** |    **0.00** |
|        Linq | 100000 | 119.03 μs |  1.325 μs |  0.693 μs |  2.01 |    0.02 |
|      LinqAF | 100000 | 456.44 μs | 22.884 μs | 10.161 μs |  7.70 |    0.19 |
|   Hyperlinq | 100000 | 113.83 μs |  1.871 μs |  0.667 μs |  1.92 |    0.02 |
|    Tinyield | 100000 | 245.50 μs |  3.361 μs |  1.758 μs |  4.15 |    0.05 |
