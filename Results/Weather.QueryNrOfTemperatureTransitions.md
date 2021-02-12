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

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]        : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|      Method | Count |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|     ForLoop |   100 |  3.903 μs | 0.0181 μs | 0.0169 μs |  1.00 | 1.6479 |     - |     - |   5.07 KB |
| ForeachLoop |   100 |  3.902 μs | 0.0231 μs | 0.0205 μs |  1.00 | 1.6479 |     - |     - |   5.07 KB |
|        Linq |   100 |  6.963 μs | 0.0143 μs | 0.0133 μs |  1.78 | 1.7166 |     - |     - |   5.27 KB |
|      LinqAF |   100 | 10.070 μs | 0.0154 μs | 0.0137 μs |  2.58 | 1.7242 |     - |     - |   5.28 KB |
|  StructLinq |   100 |  9.096 μs | 0.0130 μs | 0.0109 μs |  2.33 | 1.7395 |     - |     - |   5.34 KB |
|   Hyperlinq |   100 |  7.428 μs | 0.0159 μs | 0.0149 μs |  1.90 | 1.7090 |     - |     - |   5.26 KB |
|    Tinyield |   100 |  5.383 μs | 0.0143 μs | 0.0134 μs |  1.38 | 2.0370 |     - |     - |   6.24 KB |
