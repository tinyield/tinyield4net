## Weather.QueryNrOfTemperatureTransitions

### Source
[QueryNrOfTemperatureTransitions.cs](../LinqBenchmarks/Weather/QueryNrOfTemperatureTransitions.cs)

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
|     **ForLoop** |   **1000** |  **3.978 μs** | **0.0648 μs** | **0.0288 μs** |  **1.00** |    **0.00** |
| ForeachLoop |   1000 |  4.193 μs | 0.0553 μs | 0.0246 μs |  1.05 |    0.01 |
|        Linq |   1000 |  7.436 μs | 0.0546 μs | 0.0243 μs |  1.87 |    0.02 |
|      LinqAF |   1000 | 10.733 μs | 0.1741 μs | 0.0911 μs |  2.70 |    0.02 |
|   Hyperlinq |   1000 |  7.749 μs | 0.1796 μs | 0.0939 μs |  1.95 |    0.03 |
|    Tinyield |   1000 |  5.806 μs | 0.0316 μs | 0.0140 μs |  1.46 |    0.01 |
|             |        |           |           |           |       |         |
|     **ForLoop** | **100000** |  **3.987 μs** | **0.0539 μs** | **0.0239 μs** |  **1.00** |    **0.00** |
| ForeachLoop | 100000 |  4.245 μs | 0.0479 μs | 0.0250 μs |  1.07 |    0.01 |
|        Linq | 100000 |  7.663 μs | 0.1148 μs | 0.0600 μs |  1.92 |    0.02 |
|      LinqAF | 100000 | 10.564 μs | 0.1299 μs | 0.0679 μs |  2.65 |    0.02 |
|   Hyperlinq | 100000 |  7.868 μs | 0.0401 μs | 0.0143 μs |  1.97 |    0.01 |
|    Tinyield | 100000 |  5.872 μs | 0.0699 μs | 0.0365 μs |  1.47 |    0.02 |
