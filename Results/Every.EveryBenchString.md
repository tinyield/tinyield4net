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
  Job-LGSKAU : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |         Mean |      Error |    StdDev |
|------------ |------- |-------------:|-----------:|----------:|
| **ForeachLoop** |   **1000** |     **16.16 μs** |   **0.142 μs** |  **0.074 μs** |
|        Linq |   1000 |     35.52 μs |   0.445 μs |  0.232 μs |
|      LinqAF |   1000 |     53.22 μs |   0.492 μs |  0.258 μs |
|   HyperLinq |   1000 |     40.05 μs |   0.142 μs |  0.063 μs |
|    Tinyield |   1000 |    100.32 μs |   2.616 μs |  1.368 μs |
| **ForeachLoop** | **100000** |  **1,662.22 μs** |  **23.654 μs** | **12.372 μs** |
|        Linq | 100000 |  3,562.09 μs | 151.286 μs | 67.172 μs |
|      LinqAF | 100000 |  5,178.70 μs |  71.447 μs | 37.368 μs |
|   HyperLinq | 100000 |  3,965.50 μs |  67.653 μs | 30.038 μs |
|    Tinyield | 100000 | 10,126.30 μs | 190.333 μs | 99.548 μs |
