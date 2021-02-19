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
  Job-PFTDOO : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |        Mean |      Error |     StdDev |
|------------ |------- |------------:|-----------:|-----------:|
| **ForeachLoop** |   **1000** |    **16.59 μs** |   **0.296 μs** |   **0.155 μs** |
|        Linq |   1000 |    34.15 μs |   0.523 μs |   0.274 μs |
|   HyperLinq |   1000 |    39.85 μs |   0.351 μs |   0.184 μs |
|    Tinyield |   1000 |    99.70 μs |   1.704 μs |   0.891 μs |
| **ForeachLoop** | **100000** | **1,748.69 μs** |  **13.664 μs** |   **6.067 μs** |
|        Linq | 100000 | 3,439.08 μs |  19.239 μs |  10.062 μs |
|   HyperLinq | 100000 | 3,999.61 μs |  38.982 μs |  20.388 μs |
|    Tinyield | 100000 | 9,886.91 μs | 357.206 μs | 186.826 μs |
