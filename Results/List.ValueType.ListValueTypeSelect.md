## List.ValueType.ListValueTypeSelect

### Source
[ListValueTypeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelect.cs)

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
|                     ForLoop |   100 | 2.229 μs | 0.0025 μs | 0.0024 μs |  1.00 |      - |     - |     - |         - |
|                 ForeachLoop |   100 | 2.486 μs | 0.0034 μs | 0.0031 μs |  1.12 |      - |     - |     - |         - |
|                        Linq |   100 | 3.418 μs | 0.0047 μs | 0.0044 μs |  1.53 | 0.0420 |     - |     - |     136 B |
|                  LinqFaster |   100 | 3.246 μs | 0.0062 μs | 0.0055 μs |  1.46 | 1.2894 |     - |     - |    4056 B |
|                      LinqAF |   100 | 4.343 μs | 0.0048 μs | 0.0040 μs |  1.95 |      - |     - |     - |         - |
|                  StructLinq |   100 | 2.502 μs | 0.0032 μs | 0.0028 μs |  1.12 | 0.0114 |     - |     - |      40 B |
|        StructLinq_IFunction |   100 | 2.184 μs | 0.0031 μs | 0.0029 μs |  0.98 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |   100 | 2.306 μs | 0.0029 μs | 0.0027 μs |  1.03 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |   100 | 2.161 μs | 0.0029 μs | 0.0026 μs |  0.97 |      - |     - |     - |         - |
|               Hyperlinq_For |   100 | 2.344 μs | 0.0026 μs | 0.0024 μs |  1.05 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction |   100 | 2.120 μs | 0.0038 μs | 0.0032 μs |  0.95 |      - |     - |     - |         - |
|                    Tinyield |   100 | 4.896 μs | 0.0050 μs | 0.0047 μs |  2.20 | 0.1297 |     - |     - |     408 B |
