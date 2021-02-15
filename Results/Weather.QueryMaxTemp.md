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

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.804 (2004/?/20H1)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  Job-QKIOSF : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |------ |---------:|----------:|----------:|------:|--------:|
|     ForLoop |   100 | 2.293 μs | 0.0693 μs | 0.0247 μs |  1.00 |    0.00 |
| ForeachLoop |   100 | 2.470 μs | 0.4688 μs | 0.2452 μs |  1.07 |    0.12 |
|        Linq |   100 | 4.057 μs | 0.1448 μs | 0.0516 μs |  1.77 |    0.03 |
|      LinqAF |   100 | 7.180 μs | 0.9353 μs | 0.4892 μs |  3.20 |    0.05 |
|  StructLinq |   100 | 5.957 μs | 1.2522 μs | 0.6549 μs |  2.68 |    0.28 |
|   Hyperlinq |   100 | 4.296 μs | 0.1332 μs | 0.0475 μs |  1.87 |    0.04 |
|    Tinyield |   100 | 3.615 μs | 0.7518 μs | 0.3932 μs |  1.59 |    0.17 |
