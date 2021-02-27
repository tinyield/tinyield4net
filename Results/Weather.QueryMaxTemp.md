## Weather.QueryMaxTemp

### Source
[QueryMaxTemp.cs](../LinqBenchmarks/Weather/QueryMaxTemp.cs)

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
|      Method |  Count |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |------- |---------:|----------:|----------:|------:|--------:|
|     **ForLoop** |   **1000** | **3.616 μs** | **0.0494 μs** | **0.0259 μs** |  **1.00** |    **0.00** |
| ForeachLoop |   1000 | 3.822 μs | 0.0501 μs | 0.0262 μs |  1.06 |    0.01 |
|        Linq |   1000 | 6.828 μs | 0.0759 μs | 0.0337 μs |  1.89 |    0.02 |
|      LinqAF |   1000 | 9.875 μs | 0.0693 μs | 0.0363 μs |  2.73 |    0.02 |
|   Hyperlinq |   1000 | 6.914 μs | 0.0404 μs | 0.0211 μs |  1.91 |    0.01 |
|    Tinyield |   1000 | 5.268 μs | 0.1020 μs | 0.0533 μs |  1.46 |    0.01 |
|             |        |          |           |           |       |         |
|     **ForLoop** | **100000** | **3.614 μs** | **0.0517 μs** | **0.0270 μs** |  **1.00** |    **0.00** |
| ForeachLoop | 100000 | 3.809 μs | 0.0134 μs | 0.0060 μs |  1.05 |    0.01 |
|        Linq | 100000 | 6.784 μs | 0.0510 μs | 0.0267 μs |  1.88 |    0.02 |
|      LinqAF | 100000 | 9.735 μs | 0.1111 μs | 0.0493 μs |  2.69 |    0.02 |
|   Hyperlinq | 100000 | 6.951 μs | 0.1339 μs | 0.0594 μs |  1.92 |    0.02 |
|    Tinyield | 100000 | 5.226 μs | 0.0991 μs | 0.0440 μs |  1.45 |    0.02 |
