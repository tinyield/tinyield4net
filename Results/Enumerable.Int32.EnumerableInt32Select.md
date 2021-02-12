## Enumerable.Int32.EnumerableInt32Select

### Source
[EnumerableInt32Select.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Select.cs)

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
|                      Method | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|                 ForeachLoop |   100 |   678.9 ns | 1.42 ns | 1.33 ns |  1.00 | 0.0124 |     - |     - |      40 B |
|                        Linq |   100 | 1,461.7 ns | 3.93 ns | 3.68 ns |  2.15 | 0.0305 |     - |     - |      96 B |
|                      LinqAF |   100 | 1,107.5 ns | 3.52 ns | 3.29 ns |  1.63 | 0.0114 |     - |     - |      40 B |
|                  StructLinq |   100 |   801.4 ns | 1.52 ns | 1.42 ns |  1.18 | 0.0200 |     - |     - |      64 B |
|        StructLinq_IFunction |   100 |   625.5 ns | 1.91 ns | 1.69 ns |  0.92 | 0.0124 |     - |     - |      40 B |
|           Hyperlinq_Foreach |   100 |   900.1 ns | 1.47 ns | 1.38 ns |  1.33 | 0.0124 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction |   100 |   615.5 ns | 1.55 ns | 1.45 ns |  0.91 | 0.0124 |     - |     - |      40 B |
|                    Tinyield |   100 | 1,299.2 ns | 5.06 ns | 4.73 ns |  1.91 | 0.1087 |     - |     - |     344 B |
