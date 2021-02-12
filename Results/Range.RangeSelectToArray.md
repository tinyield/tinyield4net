## Range.RangeSelectToArray

### Source
[RangeSelectToArray.cs](../LinqBenchmarks/Range/RangeSelectToArray.cs)

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
|                                Method | Start | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard |     0 |   100 |   368.8 ns | 1.42 ns | 1.26 ns |  3.22 |    0.01 | 0.1349 |     - |     - |     424 B |
|                       ValueLinq_Stack |     0 |   100 |   699.4 ns | 2.93 ns | 2.44 ns |  6.10 |    0.03 | 0.2108 |     - |     - |     664 B |
|             ValueLinq_SharedPool_Push |     0 |   100 |   765.5 ns | 2.32 ns | 2.06 ns |  6.68 |    0.03 | 0.1345 |     - |     - |     424 B |
|             ValueLinq_SharedPool_Pull |     0 |   100 |   837.6 ns | 4.65 ns | 4.35 ns |  7.31 |    0.05 | 0.1345 |     - |     - |     424 B |
|        ValueLinq_ValueLambda_Standard |     0 |   100 |   341.0 ns | 1.55 ns | 1.45 ns |  2.98 |    0.02 | 0.1349 |     - |     - |     424 B |
|           ValueLinq_ValueLambda_Stack |     0 |   100 |   484.9 ns | 3.54 ns | 2.96 ns |  4.23 |    0.04 | 0.2108 |     - |     - |     664 B |
| ValueLinq_ValueLambda_SharedPool_Push |     0 |   100 |   587.5 ns | 2.25 ns | 2.10 ns |  5.13 |    0.03 | 0.1345 |     - |     - |     424 B |
| ValueLinq_ValueLambda_SharedPool_Pull |     0 |   100 |   623.6 ns | 6.82 ns | 6.38 ns |  5.45 |    0.07 | 0.1345 |     - |     - |     424 B |
|                               ForLoop |     0 |   100 |   114.6 ns | 0.58 ns | 0.48 ns |  1.00 |    0.00 | 0.1351 |     - |     - |     424 B |
|                                  Linq |     0 |   100 |   334.2 ns | 1.13 ns | 1.05 ns |  2.92 |    0.01 | 0.1631 |     - |     - |     512 B |
|                            LinqFaster |     0 |   100 |   381.0 ns | 1.29 ns | 1.14 ns |  3.33 |    0.02 | 0.2699 |     - |     - |     848 B |
|                                LinqAF |     0 |   100 | 1,048.1 ns | 5.65 ns | 5.28 ns |  9.14 |    0.07 | 0.5016 |     - |     - |    1576 B |
|                            StructLinq |     0 |   100 |   281.7 ns | 1.88 ns | 1.76 ns |  2.46 |    0.02 | 0.1526 |     - |     - |     480 B |
|                  StructLinq_IFunction |     0 |   100 |   127.4 ns | 0.77 ns | 0.68 ns |  1.11 |    0.01 | 0.1349 |     - |     - |     424 B |
|                             Hyperlinq |     0 |   100 |   305.3 ns | 1.17 ns | 1.10 ns |  2.66 |    0.02 | 0.1349 |     - |     - |     424 B |
|                   Hyperlinq_IFunction |     0 |   100 |   152.6 ns | 0.76 ns | 0.71 ns |  1.33 |    0.01 | 0.1349 |     - |     - |     424 B |
|                        Hyperlinq_Pool |     0 |   100 |   326.2 ns | 0.64 ns | 0.57 ns |  2.85 |    0.01 | 0.0176 |     - |     - |      56 B |
|              Hyperlinq_Pool_IFunction |     0 |   100 |   205.9 ns | 0.25 ns | 0.21 ns |  1.80 |    0.01 | 0.0176 |     - |     - |      56 B |
|                              Tinyield |     0 |   100 | 1,513.8 ns | 4.80 ns | 4.49 ns | 13.22 |    0.07 | 0.6237 |     - |     - |    1960 B |
