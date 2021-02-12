## List.ValueType.ListValueTypeSkipTakeSelect

### Source
[ListValueTypeSkipTakeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeSelect.cs)

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
|                      Method | Skip | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | 1000 |   100 |  2.275 μs | 0.0035 μs | 0.0033 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | 1000 |   100 |  7.569 μs | 0.0080 μs | 0.0075 μs |  3.33 |    0.01 | 0.0229 |     - |     - |      72 B |
|                        Linq | 1000 |   100 |  3.432 μs | 0.0041 μs | 0.0039 μs |  1.51 |    0.00 | 0.0763 |     - |     - |     248 B |
|                  LinqFaster | 1000 |   100 |  4.962 μs | 0.0505 μs | 0.0472 μs |  2.18 |    0.02 | 3.8757 |     - |     - |   12168 B |
|                      LinqAF | 1000 |   100 | 14.835 μs | 0.2831 μs | 0.3476 μs |  6.53 |    0.14 |      - |     - |     - |         - |
|                  StructLinq | 1000 |   100 |  2.553 μs | 0.0038 μs | 0.0036 μs |  1.12 |    0.00 | 0.0381 |     - |     - |     120 B |
|        StructLinq_IFunction | 1000 |   100 |  2.204 μs | 0.0023 μs | 0.0019 μs |  0.97 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |   100 |  2.354 μs | 0.0032 μs | 0.0030 μs |  1.03 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |   100 |  2.163 μs | 0.0029 μs | 0.0026 μs |  0.95 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |   100 |  2.393 μs | 0.0043 μs | 0.0040 μs |  1.05 |    0.00 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |   100 |  2.178 μs | 0.0034 μs | 0.0030 μs |  0.96 |    0.00 |      - |     - |     - |         - |
|                    Tinyield | 1000 |   100 | 20.333 μs | 0.0271 μs | 0.0240 μs |  8.94 |    0.02 | 0.1526 |     - |     - |     536 B |
