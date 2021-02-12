## Enumerable.Int32.EnumerableInt32WhereCount

### Source
[EnumerableInt32WhereCount.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereCount.cs)

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
|               Method | Count |       Mean |    Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|---------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|          ForeachLoop |   100 |   644.8 ns |  5.59 ns | 4.95 ns |  1.00 |    0.00 | 0.0124 |     - |     - |      40 B |
|                 Linq |   100 |   914.8 ns |  8.61 ns | 8.06 ns |  1.42 |    0.01 | 0.0124 |     - |     - |      40 B |
|               LinqAF |   100 |   900.0 ns | 10.04 ns | 8.90 ns |  1.40 |    0.02 | 0.0124 |     - |     - |      40 B |
|           StructLinq |   100 |   931.3 ns |  2.92 ns | 2.73 ns |  1.44 |    0.01 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction |   100 |   672.4 ns |  0.80 ns | 0.75 ns |  1.04 |    0.01 | 0.0124 |     - |     - |      40 B |
|            Hyperlinq |   100 |   869.5 ns |  1.18 ns | 1.04 ns |  1.35 |    0.01 | 0.0124 |     - |     - |      40 B |
|  Hyperlinq_IFunction |   100 |   577.3 ns |  0.96 ns | 0.90 ns |  0.90 |    0.01 | 0.0124 |     - |     - |      40 B |
|             Tinyield |   100 | 1,245.7 ns |  2.20 ns | 1.72 ns |  1.93 |    0.01 | 0.1087 |     - |     - |     344 B |
