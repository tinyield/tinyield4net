## Weather.QueryNrOfDistinctTemperatures

### Source
[QueryNrOfDistinctTemperatures.cs](../LinqBenchmarks/Weather/QueryNrOfDistinctTemperatures.cs)

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
|     **ForLoop** |   **1000** |  **4.919 μs** | **0.0622 μs** | **0.0325 μs** |  **1.00** |    **0.00** |
| ForeachLoop |   1000 |  4.788 μs | 0.0749 μs | 0.0392 μs |  0.97 |    0.01 |
|        Linq |   1000 |  7.532 μs | 0.1177 μs | 0.0615 μs |  1.53 |    0.02 |
|      LinqAF |   1000 | 10.777 μs | 0.1081 μs | 0.0480 μs |  2.19 |    0.02 |
|   Hyperlinq |   1000 |  7.746 μs | 0.0771 μs | 0.0403 μs |  1.57 |    0.01 |
|    Tinyield |   1000 |  6.132 μs | 0.1154 μs | 0.0513 μs |  1.25 |    0.01 |
|             |        |           |           |           |       |         |
|     **ForLoop** | **100000** |  **4.926 μs** | **0.0897 μs** | **0.0469 μs** |  **1.00** |    **0.00** |
| ForeachLoop | 100000 |  4.741 μs | 0.0467 μs | 0.0244 μs |  0.96 |    0.01 |
|        Linq | 100000 |  7.482 μs | 0.0396 μs | 0.0176 μs |  1.52 |    0.02 |
|      LinqAF | 100000 | 11.136 μs | 0.1763 μs | 0.0922 μs |  2.26 |    0.04 |
|   Hyperlinq | 100000 |  7.772 μs | 0.0687 μs | 0.0305 μs |  1.58 |    0.02 |
|    Tinyield | 100000 |  6.191 μs | 0.0608 μs | 0.0318 μs |  1.26 |    0.01 |
