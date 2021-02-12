## Array.Int32.ArrayInt32Distinct

### Source
[ArrayInt32Distinct.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Distinct.cs)

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
|               Method | Duplicates | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------- |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |          4 |   100 |  4.125 μs | 0.0159 μs | 0.0149 μs |  1.00 |    0.00 | 1.9150 |     - |     - |    6008 B |
|          ForeachLoop |          4 |   100 |  4.125 μs | 0.0145 μs | 0.0135 μs |  1.00 |    0.00 | 1.9150 |     - |     - |    6008 B |
|                 Linq |          4 |   100 |  8.630 μs | 0.0201 μs | 0.0179 μs |  2.09 |    0.01 | 1.3733 |     - |     - |    4312 B |
|               LinqAF |          4 |   100 | 15.052 μs | 0.2653 μs | 0.3356 μs |  3.64 |    0.08 |      - |     - |     - |   12400 B |
|           StructLinq |          4 |   100 |  4.814 μs | 0.0137 μs | 0.0128 μs |  1.17 |    0.01 | 0.0076 |     - |     - |      32 B |
| StructLinq_IFunction |          4 |   100 |  4.818 μs | 0.0092 μs | 0.0086 μs |  1.17 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |          4 |   100 |  4.974 μs | 0.0222 μs | 0.0186 μs |  1.21 |    0.00 |      - |     - |     - |         - |
|             Tinyield |          4 |   100 |  5.645 μs | 0.0238 μs | 0.0222 μs |  1.37 |    0.01 | 2.0065 |     - |     - |    6320 B |
