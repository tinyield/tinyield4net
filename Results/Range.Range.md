## Range.Range

### Source
[Range.cs](../LinqBenchmarks/Range/Range.cs)

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
|      Method | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|     ForLoop |     0 |   100 |  46.53 ns | 0.067 ns | 0.059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| ForeachLoop |     0 |   100 | 688.37 ns | 0.853 ns | 0.666 ns | 14.80 |    0.02 | 0.0172 |     - |     - |      56 B |
|        Linq |     0 |   100 | 550.86 ns | 0.849 ns | 0.753 ns | 11.84 |    0.02 | 0.0124 |     - |     - |      40 B |
|  LinqFaster |     0 |   100 | 184.34 ns | 0.631 ns | 0.559 ns |  3.96 |    0.01 | 0.1349 |     - |     - |     424 B |
|      LinqAF |     0 |   100 | 241.26 ns | 0.212 ns | 0.188 ns |  5.18 |    0.01 |      - |     - |     - |         - |
|  StructLinq |     0 |   100 |  47.53 ns | 0.087 ns | 0.072 ns |  1.02 |    0.00 |      - |     - |     - |         - |
|   Hyperlinq |     0 |   100 |  62.43 ns | 0.109 ns | 0.097 ns |  1.34 |    0.00 |      - |     - |     - |         - |
|    Tinyield |     0 |   100 | 747.24 ns | 1.652 ns | 1.464 ns | 16.06 |    0.03 | 0.0687 |     - |     - |     216 B |
