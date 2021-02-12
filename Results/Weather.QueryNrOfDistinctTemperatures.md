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

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]        : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|      Method | Count |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|     ForLoop |   100 |  4.508 μs | 0.0089 μs | 0.0079 μs |  1.00 | 1.5564 |     - |     - |   4.79 KB |
| ForeachLoop |   100 |  4.507 μs | 0.0151 μs | 0.0141 μs |  1.00 | 1.5564 |     - |     - |   4.79 KB |
|        Linq |   100 |  7.075 μs | 0.0132 μs | 0.0124 μs |  1.57 | 1.4038 |     - |     - |   4.31 KB |
|      LinqAF |   100 | 10.149 μs | 0.0242 μs | 0.0202 μs |  2.25 | 1.4038 |     - |     - |   4.33 KB |
|  StructLinq |   100 |  9.368 μs | 0.0187 μs | 0.0157 μs |  2.08 | 1.4191 |     - |     - |   4.38 KB |
|   Hyperlinq |   100 |  7.431 μs | 0.0040 μs | 0.0031 μs |  1.65 | 1.4038 |     - |     - |    4.3 KB |
|    Tinyield |   100 |  5.539 μs | 0.0344 μs | 0.0268 μs |  1.23 | 1.7166 |     - |     - |   5.28 KB |
