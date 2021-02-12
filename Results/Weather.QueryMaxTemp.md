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
  [Host]        : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  .NET Core 5.0 : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|      Method | Count |      Mean |     Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|     ForLoop |   100 |  3.143 μs | 0.0251 μs |  0.0209 μs |  1.00 |    0.00 | 1.1406 |     - |     - |    3.5 KB |
| ForeachLoop |   100 |  3.416 μs | 0.0445 μs |  0.0417 μs |  1.09 |    0.02 | 1.1406 |     - |     - |    3.5 KB |
|        Linq |   100 |  5.722 μs | 0.0484 μs |  0.0453 μs |  1.82 |    0.02 | 1.2207 |     - |     - |   3.75 KB |
|      LinqAF |   100 | 36.209 μs | 5.6297 μs | 16.2431 μs | 10.99 |    6.30 |      - |     - |     - |   3.77 KB |
|  StructLinq |   100 |  7.897 μs | 0.0867 μs |  0.0769 μs |  2.51 |    0.03 | 1.2360 |     - |     - |   3.82 KB |
|   Hyperlinq |   100 |  6.121 μs | 0.0551 μs |  0.0489 μs |  1.95 |    0.02 | 1.2207 |     - |     - |   3.74 KB |
|    Tinyield |   100 |  4.518 μs | 0.0498 μs |  0.0466 μs |  1.44 |    0.02 | 1.4572 |     - |     - |   4.48 KB |
