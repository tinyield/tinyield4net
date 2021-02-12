## Range.RangeSelectToList

### Source
[RangeSelectToList.cs](../LinqBenchmarks/Range/RangeSelectToList.cs)

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
|                                Method | Start | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard |     0 |   100 |   507.4 ns |  2.19 ns |  1.94 ns |  1.26 |    0.01 | 0.1450 |     - |     - |     456 B |
|                       ValueLinq_Stack |     0 |   100 |   971.8 ns | 12.96 ns | 12.12 ns |  2.41 |    0.03 | 0.2213 |     - |     - |     696 B |
|             ValueLinq_SharedPool_Push |     0 |   100 |   843.3 ns |  1.30 ns |  1.15 ns |  2.09 |    0.01 | 0.1450 |     - |     - |     456 B |
|             ValueLinq_SharedPool_Pull |     0 |   100 |   941.4 ns |  1.53 ns |  1.19 ns |  2.33 |    0.01 | 0.1450 |     - |     - |     456 B |
|        ValueLinq_ValueLambda_Standard |     0 |   100 |   407.2 ns |  1.28 ns |  1.13 ns |  1.01 |    0.00 | 0.1450 |     - |     - |     456 B |
|           ValueLinq_ValueLambda_Stack |     0 |   100 |   746.6 ns |  1.76 ns |  1.37 ns |  1.85 |    0.01 | 0.2213 |     - |     - |     696 B |
| ValueLinq_ValueLambda_SharedPool_Push |     0 |   100 |   626.9 ns |  1.41 ns |  1.17 ns |  1.55 |    0.01 | 0.1450 |     - |     - |     456 B |
| ValueLinq_ValueLambda_SharedPool_Pull |     0 |   100 |   792.2 ns |  2.05 ns |  1.72 ns |  1.96 |    0.01 | 0.1450 |     - |     - |     456 B |
|                               ForLoop |     0 |   100 |   403.9 ns |  1.51 ns |  1.41 ns |  1.00 |    0.00 | 0.3772 |     - |     - |    1184 B |
|                           ForeachLoop |     0 |   100 |   976.7 ns |  6.90 ns |  6.45 ns |  2.42 |    0.02 | 0.3948 |     - |     - |    1240 B |
|                                  Linq |     0 |   100 |   446.8 ns |  1.82 ns |  1.62 ns |  1.11 |    0.00 | 0.1731 |     - |     - |     544 B |
|                            LinqFaster |     0 |   100 |   449.5 ns |  1.32 ns |  1.10 ns |  1.11 |    0.00 | 0.4153 |     - |     - |    1304 B |
|                                LinqAF |     0 |   100 | 1,129.1 ns |  5.32 ns |  4.98 ns |  2.80 |    0.01 | 0.3757 |     - |     - |    1184 B |
|                            StructLinq |     0 |   100 |   329.5 ns |  1.11 ns |  0.98 ns |  0.82 |    0.00 | 0.1631 |     - |     - |     512 B |
|                  StructLinq_IFunction |     0 |   100 |   140.2 ns |  0.74 ns |  0.69 ns |  0.35 |    0.00 | 0.1452 |     - |     - |     456 B |
|                             Hyperlinq |     0 |   100 |   290.2 ns |  1.69 ns |  1.58 ns |  0.72 |    0.00 | 0.1450 |     - |     - |     456 B |
|                   Hyperlinq_IFunction |     0 |   100 |   177.0 ns |  0.81 ns |  0.68 ns |  0.44 |    0.00 | 0.1452 |     - |     - |     456 B |
|                              Tinyield |     0 |   100 | 1,423.8 ns |  4.30 ns |  3.81 ns |  3.52 |    0.02 | 0.4883 |     - |     - |    1536 B |
