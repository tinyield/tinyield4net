## List.ValueType.ListValueTypeWhereSelect

### Source
[ListValueTypeWhereSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelect.cs)

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
|               Method | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 | 1.213 μs | 0.0013 μs | 0.0011 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 | 1.467 μs | 0.0026 μs | 0.0021 μs |  1.21 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 | 2.195 μs | 0.0112 μs | 0.0104 μs |  1.81 |    0.01 | 0.0877 |     - |     - |     280 B |
|           LinqFaster |   100 | 2.316 μs | 0.0361 μs | 0.0337 μs |  1.91 |    0.03 | 1.6251 |     - |     - |    5112 B |
|               LinqAF |   100 | 2.925 μs | 0.0563 μs | 0.0602 μs |  2.42 |    0.05 |      - |     - |     - |         - |
|           StructLinq |   100 | 1.528 μs | 0.0017 μs | 0.0016 μs |  1.26 |    0.00 | 0.0229 |     - |     - |      72 B |
| StructLinq_IFunction |   100 | 1.245 μs | 0.0022 μs | 0.0018 μs |  1.03 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 | 1.480 μs | 0.0017 μs | 0.0015 μs |  1.22 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 | 1.297 μs | 0.0012 μs | 0.0011 μs |  1.07 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 | 2.917 μs | 0.0065 μs | 0.0058 μs |  2.40 |    0.00 | 0.1793 |     - |     - |     568 B |
