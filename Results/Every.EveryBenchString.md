## Every.EveryBenchString

### Source
[EveryBenchString.cs](../LinqBenchmarks/Every/EveryBenchString.cs)

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
  Job-PFTDOO : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |        Mean |      Error |     StdDev |
|------------ |------- |------------:|-----------:|-----------:|
| **ForeachLoop** |   **1000** |    **15.47 μs** |   **0.146 μs** |   **0.065 μs** |
|        Linq |   1000 |    35.14 μs |   0.882 μs |   0.461 μs |
|   HyperLinq |   1000 |    37.92 μs |   0.299 μs |   0.156 μs |
|    Tinyield |   1000 |    98.33 μs |   1.980 μs |   1.036 μs |
| **ForeachLoop** | **100000** | **1,591.47 μs** |  **13.883 μs** |   **7.261 μs** |
|        Linq | 100000 | 3,421.85 μs |  44.981 μs |  19.972 μs |
|   HyperLinq | 100000 | 4,033.36 μs |  64.772 μs |  33.877 μs |
|    Tinyield | 100000 | 9,798.34 μs | 218.923 μs | 114.501 μs |
