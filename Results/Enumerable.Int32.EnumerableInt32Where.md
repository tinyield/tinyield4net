## Enumerable.Int32.EnumerableInt32Where

### Source
[EnumerableInt32Where.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Where.cs)

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
|               Method | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                 Linq |   100 | 1,272.6 ns |  6.23 ns |  5.83 ns |  1.00 |    0.00 | 0.0305 |     - |     - |      96 B |
|               LinqAF |   100 | 1,147.7 ns |  8.00 ns |  7.48 ns |  0.90 |    0.01 | 0.0114 |     - |     - |      40 B |
|           StructLinq |   100 | 1,021.3 ns |  3.50 ns |  3.27 ns |  0.80 |    0.00 | 0.0191 |     - |     - |      64 B |
| StructLinq_IFunction |   100 |   794.4 ns |  2.72 ns |  2.54 ns |  0.62 |    0.00 | 0.0124 |     - |     - |      40 B |
|            Hyperlinq |   100 |   976.1 ns | 19.31 ns | 27.70 ns |  0.77 |    0.03 | 0.0124 |     - |     - |      40 B |
|  Hyperlinq_IFunction |   100 |   859.7 ns | 11.96 ns | 11.19 ns |  0.68 |    0.01 | 0.0124 |     - |     - |      40 B |
|             Tinyield |   100 | 1,195.5 ns | 11.58 ns | 10.83 ns |  0.94 |    0.01 | 0.1087 |     - |     - |     344 B |
