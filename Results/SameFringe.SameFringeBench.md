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
  Job-LGSKAU : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method |  Count |         Mean |       Error |      StdDev | Ratio | RatioSD |
|------------ |------- |-------------:|------------:|------------:|------:|--------:|
| **ForeachLoop** |   **1000** |     **600.5 μs** |     **7.05 μs** |     **3.69 μs** |  **1.00** |    **0.00** |
|        Linq |   1000 |     649.7 μs |    18.07 μs |     9.45 μs |  1.08 |    0.02 |
|      LinqAF |   1000 |     646.8 μs |    14.94 μs |     7.82 μs |  1.08 |    0.02 |
|   HyperLinq |   1000 |     653.7 μs |    11.07 μs |     4.92 μs |  1.09 |    0.01 |
|    Tinyield |   1000 |     153.4 μs |     2.43 μs |     1.27 μs |  0.26 |    0.00 |
|             |        |              |             |             |       |         |
| **ForeachLoop** | **100000** | **213,792.2 μs** | **4,024.05 μs** | **2,104.66 μs** |  **1.00** |    **0.00** |
|        Linq | 100000 | 220,482.4 μs | 3,802.60 μs | 1,988.83 μs |  1.03 |    0.02 |
|      LinqAF | 100000 | 221,649.8 μs | 3,482.33 μs | 1,546.18 μs |  1.04 |    0.01 |
|   HyperLinq | 100000 | 204,918.7 μs | 5,254.84 μs | 2,748.39 μs |  0.96 |    0.01 |
|    Tinyield | 100000 |  31,542.0 μs |   522.45 μs |   273.25 μs |  0.15 |    0.00 |
