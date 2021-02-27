## Every.EveryBench

### Source
[EveryBench.cs](../LinqBenchmarks/Every/EveryBench.cs)

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
|      Method |  Count |         Mean |      Error |    StdDev | Ratio | RatioSD |
|------------ |------- |-------------:|-----------:|----------:|------:|--------:|
| **ForeachLoop** |   **1000** |     **17.28 μs** |   **0.116 μs** |  **0.051 μs** |  **1.00** |    **0.00** |
|        Linq |   1000 |     35.06 μs |   0.371 μs |  0.194 μs |  2.03 |    0.02 |
|      LinqAF |   1000 |     77.62 μs |   5.350 μs |  2.798 μs |  4.49 |    0.18 |
|   HyperLinq |   1000 |     41.71 μs |   0.425 μs |  0.222 μs |  2.42 |    0.01 |
|    Tinyield |   1000 |    100.75 μs |   0.732 μs |  0.325 μs |  5.83 |    0.03 |
|             |        |              |            |           |       |         |
| **ForeachLoop** | **100000** |  **1,771.81 μs** |   **9.413 μs** |  **4.923 μs** |  **1.00** |    **0.00** |
|        Linq | 100000 |  3,494.92 μs |  17.111 μs |  7.597 μs |  1.97 |    0.00 |
|      LinqAF | 100000 |  5,553.59 μs | 129.173 μs | 67.560 μs |  3.13 |    0.04 |
|   HyperLinq | 100000 |  4,152.63 μs |  96.577 μs | 50.512 μs |  2.34 |    0.02 |
|    Tinyield | 100000 | 10,206.56 μs | 139.960 μs | 62.143 μs |  5.76 |    0.03 |
