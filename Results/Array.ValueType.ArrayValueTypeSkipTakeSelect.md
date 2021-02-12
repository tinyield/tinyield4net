## Array.ValueType.ArrayValueTypeSkipTakeSelect

### Source
[ArrayValueTypeSkipTakeSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeSelect.cs)

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
|                     ForLoop | 1000 |   100 |  2.127 μs | 0.0072 μs | 0.0068 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | 1000 |   100 |  5.658 μs | 0.0128 μs | 0.0120 μs |  2.66 |    0.01 | 0.0076 |     - |     - |      32 B |
|                        Linq | 1000 |   100 |  3.524 μs | 0.0086 μs | 0.0072 μs |  1.66 |    0.01 | 0.0763 |     - |     - |     248 B |
|                  LinqFaster | 1000 |   100 |  3.368 μs | 0.0169 μs | 0.0158 μs |  1.58 |    0.01 | 3.8452 |     - |     - |   12072 B |
|                      LinqAF | 1000 |   100 |  9.200 μs | 0.0845 μs | 0.0791 μs |  4.33 |    0.04 |      - |     - |     - |         - |
|                  StructLinq | 1000 |   100 |  2.611 μs | 0.0068 μs | 0.0064 μs |  1.23 |    0.00 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |   100 |  2.180 μs | 0.0069 μs | 0.0061 μs |  1.03 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |   100 |  2.457 μs | 0.0096 μs | 0.0090 μs |  1.16 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |   100 |  2.191 μs | 0.0078 μs | 0.0073 μs |  1.03 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |   100 |  2.361 μs | 0.0049 μs | 0.0044 μs |  1.11 |    0.00 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |   100 |  2.148 μs | 0.0078 μs | 0.0073 μs |  1.01 |    0.00 |      - |     - |     - |         - |
|                    Tinyield | 1000 |   100 | 12.136 μs | 0.0573 μs | 0.0536 μs |  5.71 |    0.03 | 0.1373 |     - |     - |     472 B |
