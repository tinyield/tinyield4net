## Weather.QueryNrOfDistinctTemperatures

### Source
[QueryNrOfDistinctTemperatures.cs](../LinqBenchmarks/Weather/QueryNrOfDistinctTemperatures.cs)

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
|      Method | Count |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|------------ |------ |----------:|----------:|----------:|----------:|------:|--------:|
|     ForLoop |   100 |  5.330 μs | 6.2444 μs | 2.7726 μs |  4.222 μs |  1.00 |    0.00 |
| ForeachLoop |   100 |  6.971 μs | 0.0235 μs | 0.0104 μs |  6.972 μs |  1.56 |    0.59 |
|        Linq |   100 | 11.002 μs | 0.1677 μs | 0.0598 μs | 10.981 μs |  2.64 |    0.88 |
|      LinqAF |   100 | 54.629 μs | 3.4174 μs | 1.5174 μs | 54.000 μs | 12.20 |    4.59 |
|  StructLinq |   100 | 25.562 μs | 4.0261 μs | 1.7876 μs | 25.737 μs |  5.69 |    2.11 |
|   Hyperlinq |   100 | 18.314 μs | 2.2662 μs | 1.0062 μs | 18.120 μs |  4.08 |    1.49 |
|    Tinyield |   100 | 13.349 μs | 0.0186 μs | 0.0066 μs | 13.349 μs |  3.20 |    1.08 |
