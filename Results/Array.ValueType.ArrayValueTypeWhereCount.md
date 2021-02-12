## Array.ValueType.ArrayValueTypeWhereCount

### Source
[ArrayValueTypeWhereCount.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereCount.cs)

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
|              ForLoop |   100 |   105.7 ns |  0.17 ns |  0.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 |   168.4 ns |  0.49 ns |  0.46 ns |  1.59 |    0.01 |      - |     - |     - |         - |
|                 Linq |   100 |   876.2 ns |  1.57 ns |  1.39 ns |  8.29 |    0.02 | 0.0095 |     - |     - |      32 B |
|           LinqFaster |   100 |   369.6 ns |  0.99 ns |  0.88 ns |  3.50 |    0.01 |      - |     - |     - |         - |
|               LinqAF |   100 | 1,486.9 ns | 28.77 ns | 36.38 ns | 14.09 |    0.40 |      - |     - |     - |         - |
|           StructLinq |   100 |   389.2 ns |  1.02 ns |  0.96 ns |  3.68 |    0.01 | 0.0200 |     - |     - |      64 B |
| StructLinq_IFunction |   100 |   245.9 ns |  0.96 ns |  0.85 ns |  2.33 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |   100 |   302.7 ns |  0.84 ns |  0.75 ns |  2.86 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 |   163.8 ns |  0.55 ns |  0.51 ns |  1.55 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 |   765.7 ns |  3.89 ns |  3.64 ns |  7.24 |    0.03 | 0.0992 |     - |     - |     312 B |
