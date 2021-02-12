## Enumerable.Int32.EnumerableInt32Distinct

### Source
[EnumerableInt32Distinct.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Distinct.cs)

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
|               Method | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop |   100 | 2.383 μs | 0.0173 μs | 0.0161 μs |  1.00 | 1.9264 |     - |     - |    6048 B |
|                 Linq |   100 | 3.180 μs | 0.0130 μs | 0.0121 μs |  1.33 | 1.3771 |     - |     - |    4320 B |
|               LinqAF |   100 | 4.870 μs | 0.0310 μs | 0.0290 μs |  2.04 | 1.6632 |     - |     - |    5240 B |
|           StructLinq |   100 | 2.914 μs | 0.0104 μs | 0.0098 μs |  1.22 | 0.0191 |     - |     - |      64 B |
| StructLinq_IFunction |   100 | 2.931 μs | 0.0097 μs | 0.0086 μs |  1.23 | 0.0114 |     - |     - |      40 B |
|            Hyperlinq |   100 | 2.731 μs | 0.0097 μs | 0.0090 μs |  1.15 | 0.0114 |     - |     - |      40 B |
|             Tinyield |   100 | 2.849 μs | 0.0160 μs | 0.0150 μs |  1.20 | 2.0218 |     - |     - |    6352 B |
