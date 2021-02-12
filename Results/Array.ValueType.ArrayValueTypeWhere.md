## Array.ValueType.ArrayValueTypeWhere

### Source
[ArrayValueTypeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhere.cs)

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
|               Method | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 |   577.1 ns |  1.42 ns |  1.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 |   651.2 ns |  1.98 ns |  1.85 ns |  1.13 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 | 1,186.3 ns |  7.47 ns |  6.99 ns |  2.06 |    0.01 | 0.0248 |     - |     - |      80 B |
|           LinqFaster |   100 | 1,272.9 ns | 14.25 ns | 13.33 ns |  2.21 |    0.02 | 1.9264 |     - |     - |    6048 B |
|               LinqAF |   100 | 1,483.3 ns | 25.38 ns | 23.74 ns |  2.57 |    0.04 |      - |     - |     - |         - |
|           StructLinq |   100 |   826.1 ns |  1.50 ns |  1.40 ns |  1.43 |    0.00 | 0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |   100 |   704.4 ns |  1.25 ns |  1.11 ns |  1.22 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 |   721.4 ns |  0.97 ns |  0.86 ns |  1.25 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 |   678.1 ns |  1.10 ns |  0.97 ns |  1.18 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 | 1,253.6 ns |  6.69 ns |  5.93 ns |  2.17 |    0.01 | 0.1087 |     - |     - |     344 B |
