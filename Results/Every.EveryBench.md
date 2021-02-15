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

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.804 (2004/?/20H1)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  Job-FXKPKQ : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |        Mean |      Error |     StdDev |
|------------ |------- |------------:|-----------:|-----------:|
| **ForeachLoop** |   **1000** |    **12.89 μs** |   **2.492 μs** |   **1.106 μs** |
|        Linq |   1000 |    24.79 μs |   4.124 μs |   2.157 μs |
|   HyperLinq |   1000 |    30.34 μs |   0.465 μs |   0.166 μs |
|    Tinyield |   1000 |    70.17 μs |  16.080 μs |   8.410 μs |
| **ForeachLoop** | **100000** | **1,453.94 μs** | **205.248 μs** |  **91.131 μs** |
|        Linq | 100000 | 2,690.97 μs |  80.554 μs |  35.767 μs |
|   HyperLinq | 100000 | 3,128.33 μs |  32.933 μs |  14.622 μs |
|    Tinyield | 100000 | 7,095.36 μs | 206.274 μs | 107.885 μs |
