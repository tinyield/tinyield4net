## Enumerable.Int32.EnumerableInt32SkipTakeSelect

### Source
[EnumerableInt32SkipTakeSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeSelect.cs)

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
|                      Method | Skip | Count |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                 ForeachLoop | 1000 |   100 |  3.906 μs | 0.0150 μs | 0.0140 μs |  1.00 | 0.0076 |     - |     - |      40 B |
|                        Linq | 1000 |   100 |  5.752 μs | 0.0162 μs | 0.0151 μs |  1.47 | 0.0610 |     - |     - |     208 B |
|                      LinqAF | 1000 |   100 |  6.832 μs | 0.0161 μs | 0.0150 μs |  1.75 | 0.0076 |     - |     - |      40 B |
|                  StructLinq | 1000 |   100 |  4.633 μs | 0.0132 μs | 0.0123 μs |  1.19 | 0.0381 |     - |     - |     128 B |
|        StructLinq_IFunction | 1000 |   100 |  4.700 μs | 0.0165 μs | 0.0154 μs |  1.20 | 0.0076 |     - |     - |      40 B |
|           Hyperlinq_Foreach | 1000 |   100 |  4.789 μs | 0.0146 μs | 0.0136 μs |  1.23 | 0.0076 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | 1000 |   100 |  4.504 μs | 0.0216 μs | 0.0202 μs |  1.15 | 0.0076 |     - |     - |      40 B |
|                    Tinyield | 1000 |   100 | 14.425 μs | 0.0299 μs | 0.0265 μs |  3.69 | 0.1373 |     - |     - |     472 B |
