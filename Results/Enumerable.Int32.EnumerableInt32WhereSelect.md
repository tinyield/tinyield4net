## Enumerable.Int32.EnumerableInt32WhereSelect

### Source
[EnumerableInt32WhereSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelect.cs)

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
|               Method | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop |   100 |   695.7 ns | 1.19 ns | 1.11 ns |  1.00 | 0.0124 |     - |     - |      40 B |
|                 Linq |   100 | 1,334.8 ns | 4.53 ns | 4.02 ns |  1.92 | 0.0496 |     - |     - |     160 B |
|               LinqAF |   100 | 1,192.7 ns | 2.11 ns | 1.97 ns |  1.71 | 0.0114 |     - |     - |      40 B |
|           StructLinq |   100 | 1,171.1 ns | 3.20 ns | 2.99 ns |  1.68 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction |   100 |   803.3 ns | 0.82 ns | 0.73 ns |  1.15 | 0.0124 |     - |     - |      40 B |
|            Hyperlinq |   100 | 1,051.8 ns | 1.92 ns | 1.70 ns |  1.51 | 0.0114 |     - |     - |      40 B |
|  Hyperlinq_IFunction |   100 |   786.4 ns | 1.46 ns | 1.37 ns |  1.13 | 0.0124 |     - |     - |      40 B |
|             Tinyield |   100 | 1,397.4 ns | 4.99 ns | 4.67 ns |  2.01 | 0.1602 |     - |     - |     504 B |
