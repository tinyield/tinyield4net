## List.ValueType.ListValueTypeDistinct

### Source
[ListValueTypeDistinct.cs](../LinqBenchmarks/List/ValueType/ListValueTypeDistinct.cs)

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
|               Method | Duplicates | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------- |------ |-------------:|-----------:|-----------:|------:|--------:|----------:|------:|------:|----------:|
|              ForLoop |          4 |   100 |   693.861 μs |  4.6842 μs |  4.3816 μs | 1.000 |    0.00 |  730.4688 |     - |     - | 2292184 B |
|          ForeachLoop |          4 |   100 |   684.732 μs |  5.3291 μs |  4.9848 μs | 0.987 |    0.01 |  730.4688 |     - |     - | 2292184 B |
|                 Linq |          4 |   100 |   695.912 μs |  4.1026 μs |  3.8375 μs | 1.003 |    0.01 |  728.5156 |     - |     - | 2286712 B |
|           LinqFaster |          4 |   100 |     3.252 μs |  0.0050 μs |  0.0045 μs | 0.005 |    0.00 |    0.0076 |     - |     - |      24 B |
|               LinqAF |          4 |   100 | 2,299.711 μs | 16.6383 μs | 15.5634 μs | 3.314 |    0.03 | 1457.0313 |     - |     - | 4575077 B |
|           StructLinq |          4 |   100 |   793.404 μs |  3.3352 μs |  2.7850 μs | 1.144 |    0.01 |  724.6094 |     - |     - | 2273665 B |
| StructLinq_IFunction |          4 |   100 |     6.290 μs |  0.0136 μs |  0.0120 μs | 0.009 |    0.00 |         - |     - |     - |         - |
|            Hyperlinq |          4 |   100 |   642.477 μs |  3.7443 μs |  3.3192 μs | 0.926 |    0.01 |  697.2656 |     - |     - | 2187585 B |
|             Tinyield |          4 |   100 |   697.786 μs |  3.4443 μs |  3.0533 μs | 1.005 |    0.01 |  730.4688 |     - |     - | 2292592 B |
