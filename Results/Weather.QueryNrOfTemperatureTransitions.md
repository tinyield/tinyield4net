## Weather.QueryNrOfTemperatureTransitions

### Source
[QueryNrOfTemperatureTransitions.cs](../LinqBenchmarks/Weather/QueryNrOfTemperatureTransitions.cs)

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
|      Method | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |------ |----------:|----------:|----------:|------:|--------:|
|     ForLoop |   100 |  9.808 μs | 0.6720 μs | 0.3515 μs |  1.00 |    0.00 |
| ForeachLoop |   100 |  8.562 μs | 0.9434 μs | 0.4934 μs |  0.87 |    0.06 |
|        Linq |   100 | 17.267 μs | 1.2151 μs | 0.6355 μs |  1.76 |    0.12 |
|      LinqAF |   100 | 48.400 μs | 5.2288 μs | 2.3216 μs |  4.95 |    0.24 |
|  StructLinq |   100 | 22.569 μs | 5.5599 μs | 2.9080 μs |  2.31 |    0.34 |
|   Hyperlinq |   100 | 17.710 μs | 1.4012 μs | 0.7328 μs |  1.81 |    0.12 |
|    Tinyield |   100 | 13.833 μs | 3.2594 μs | 1.7047 μs |  1.41 |    0.19 |
