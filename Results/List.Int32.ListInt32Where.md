## List.Int32.ListInt32Where

### Source
[ListInt32Where.cs](../LinqBenchmarks/List/Int32/ListInt32Where.cs)

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
|               Method | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 |   146.0 ns | 0.18 ns | 0.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 |   290.7 ns | 0.61 ns | 0.54 ns |  1.99 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 |   878.8 ns | 1.21 ns | 1.08 ns |  6.02 |    0.01 | 0.0229 |     - |     - |      72 B |
|           LinqFaster |   100 |   540.3 ns | 2.45 ns | 2.30 ns |  3.70 |    0.01 | 0.2060 |     - |     - |     648 B |
|               LinqAF |   100 |   927.1 ns | 1.40 ns | 1.24 ns |  6.35 |    0.01 |      - |     - |     - |         - |
|           StructLinq |   100 |   407.1 ns | 0.62 ns | 0.58 ns |  2.79 |    0.00 | 0.0100 |     - |     - |      32 B |
| StructLinq_IFunction |   100 |   237.0 ns | 0.38 ns | 0.34 ns |  1.62 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 |   336.1 ns | 0.36 ns | 0.28 ns |  2.30 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 |   258.6 ns | 0.35 ns | 0.33 ns |  1.77 |    0.00 |      - |     - |     - |         - |
|             Tinyield |   100 | 1,401.0 ns | 3.64 ns | 3.40 ns |  9.60 |    0.02 | 0.1087 |     - |     - |     344 B |
