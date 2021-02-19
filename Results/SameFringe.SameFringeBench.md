## SameFringe.SameFringeBench

### Source
[SameFringeBench.cs](../LinqBenchmarks/SameFringe/SameFringeBench.cs)

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
|      Method |  Count |         Mean |       Error |      StdDev |
|------------ |------- |-------------:|------------:|------------:|
| **ForeachLoop** |   **1000** |     **627.8 μs** |    **15.95 μs** |     **8.34 μs** |
|        Linq |   1000 |     631.5 μs |    12.90 μs |     6.74 μs |
|   HyperLinq |   1000 |     640.4 μs |    13.65 μs |     6.06 μs |
|    Tinyield |   1000 |     147.1 μs |     1.85 μs |     0.97 μs |
| **ForeachLoop** | **100000** | **211,965.2 μs** | **2,165.39 μs** |   **961.44 μs** |
|        Linq | 100000 | 203,484.8 μs | 8,095.31 μs | 4,234.00 μs |
|   HyperLinq | 100000 | 209,089.0 μs | 4,095.99 μs | 1,818.65 μs |
|    Tinyield | 100000 |  31,376.6 μs |   323.86 μs |   143.80 μs |
