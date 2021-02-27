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
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  Job-DXFRHK : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |------- |-----------:|----------:|----------:|------:|--------:|
| **ForeachLoop** |   **1000** |   **215.6 μs** |   **5.54 μs** |   **2.90 μs** |  **1.00** |    **0.00** |
|        Linq |   1000 |   354.6 μs |  10.42 μs |   5.45 μs |  1.64 |    0.02 |
|      LinqAF |   1000 | 1,243.8 μs | 206.17 μs | 107.83 μs |  5.77 |    0.56 |
|   Hyperlinq |   1000 |   330.1 μs |  11.70 μs |   5.19 μs |  1.54 |    0.02 |
|    Tinyield |   1000 |   540.8 μs |  21.19 μs |  11.08 μs |  2.51 |    0.07 |
|             |        |            |           |           |       |         |
| **ForeachLoop** | **100000** |   **216.7 μs** |   **5.83 μs** |   **3.05 μs** |  **1.00** |    **0.00** |
|        Linq | 100000 |   342.2 μs |  11.40 μs |   5.06 μs |  1.58 |    0.02 |
|      LinqAF | 100000 | 1,127.8 μs | 156.47 μs |  69.47 μs |  5.19 |    0.35 |
|   Hyperlinq | 100000 |   325.6 μs |   7.35 μs |   3.84 μs |  1.50 |    0.03 |
|    Tinyield | 100000 |   554.3 μs |  45.69 μs |  23.90 μs |  2.56 |    0.13 |
