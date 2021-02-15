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

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.804 (2004/?/20H1)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  Job-TAAOKH : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |         Mean |        Error |       StdDev |
|------------ |------- |-------------:|-------------:|-------------:|
| **ForeachLoop** |   **1000** |     **482.3 μs** |     **90.96 μs** |     **40.39 μs** |
|        Linq |   1000 |     500.8 μs |    105.41 μs |     55.13 μs |
|   HyperLinq |   1000 |     476.4 μs |     85.38 μs |     44.65 μs |
|    Tinyield |   1000 |     111.7 μs |      4.69 μs |      2.08 μs |
| **ForeachLoop** | **100000** | **216,527.7 μs** | **16,886.64 μs** |  **7,497.77 μs** |
|        Linq | 100000 | 212,023.1 μs | 19,722.40 μs | 10,315.20 μs |
|   HyperLinq | 100000 | 215,777.8 μs |    969.69 μs |    430.55 μs |
|    Tinyield | 100000 |  30,378.3 μs |    565.86 μs |    251.24 μs |
