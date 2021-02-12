## Array.ValueType.ArrayValueTypeSelect

### Source
[ArrayValueTypeSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSelect.cs)

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
|                      Method | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                     ForLoop |   100 | 2.088 μs | 0.0045 μs | 0.0040 μs |  1.00 |      - |     - |     - |         - |
|                 ForeachLoop |   100 | 2.217 μs | 0.0073 μs | 0.0068 μs |  1.06 |      - |     - |     - |         - |
|                        Linq |   100 | 2.979 μs | 0.0093 μs | 0.0087 μs |  1.43 | 0.0229 |     - |     - |      80 B |
|                  LinqFaster |   100 | 2.789 μs | 0.0141 μs | 0.0132 μs |  1.33 | 1.2817 |     - |     - |    4024 B |
|                      LinqAF |   100 | 3.721 μs | 0.0056 μs | 0.0049 μs |  1.78 |      - |     - |     - |         - |
|                  StructLinq |   100 | 2.559 μs | 0.0087 μs | 0.0081 μs |  1.23 | 0.0076 |     - |     - |      32 B |
|        StructLinq_IFunction |   100 | 2.183 μs | 0.0072 μs | 0.0067 μs |  1.05 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |   100 | 2.322 μs | 0.0056 μs | 0.0052 μs |  1.11 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |   100 | 2.173 μs | 0.0072 μs | 0.0067 μs |  1.04 |      - |     - |     - |         - |
|               Hyperlinq_For |   100 | 2.390 μs | 0.0060 μs | 0.0056 μs |  1.14 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction |   100 | 2.170 μs | 0.0050 μs | 0.0047 μs |  1.04 |      - |     - |     - |         - |
|                    Tinyield |   100 | 3.073 μs | 0.0075 μs | 0.0067 μs |  1.47 | 0.1068 |     - |     - |     344 B |
