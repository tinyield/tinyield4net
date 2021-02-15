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

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.804 (2004/?/20H1)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  Job-IUKUNH : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |        Mean |      Error |     StdDev |
|------------ |------- |------------:|-----------:|-----------:|
| **ForeachLoop** |   **1000** |    **11.85 μs** |   **2.113 μs** |   **1.105 μs** |
|        Linq |   1000 |    28.23 μs |   1.495 μs |   0.782 μs |
|   HyperLinq |   1000 |    30.30 μs |   5.215 μs |   2.727 μs |
|    Tinyield |   1000 |    75.06 μs |  13.028 μs |   6.814 μs |
| **ForeachLoop** | **100000** | **1,436.94 μs** | **125.219 μs** |  **65.492 μs** |
|        Linq | 100000 | 2,877.11 μs | 343.139 μs | 179.468 μs |
|   HyperLinq | 100000 | 3,124.47 μs | 397.906 μs | 208.113 μs |
|    Tinyield | 100000 | 7,679.07 μs | 436.411 μs | 228.251 μs |
