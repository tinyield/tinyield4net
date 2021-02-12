## Enumerable.Int32.EnumerableInt32WhereSelectToList

### Source
[EnumerableInt32WhereSelectToList.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToList.cs)

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
|                                Method | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard |   100 | 1,466.6 ns | 5.38 ns | 4.77 ns |  1.55 |    0.01 | 0.2193 |     - |     - |     688 B |
|                       ValueLinq_Stack |   100 | 1,534.0 ns | 2.95 ns | 2.62 ns |  1.62 |    0.01 | 0.0935 |     - |     - |     296 B |
|             ValueLinq_SharedPool_Push |   100 | 1,873.4 ns | 4.85 ns | 4.30 ns |  1.98 |    0.02 | 0.0935 |     - |     - |     296 B |
|             ValueLinq_SharedPool_Pull |   100 | 1,746.5 ns | 6.60 ns | 5.85 ns |  1.84 |    0.01 | 0.0935 |     - |     - |     296 B |
|        ValueLinq_ValueLambda_Standard |   100 | 1,125.2 ns | 6.31 ns | 5.91 ns |  1.19 |    0.01 | 0.2193 |     - |     - |     688 B |
|           ValueLinq_ValueLambda_Stack |   100 | 1,047.0 ns | 3.71 ns | 3.29 ns |  1.11 |    0.01 | 0.0935 |     - |     - |     296 B |
| ValueLinq_ValueLambda_SharedPool_Push |   100 | 1,849.6 ns | 4.51 ns | 4.22 ns |  1.95 |    0.02 | 0.0935 |     - |     - |     296 B |
| ValueLinq_ValueLambda_SharedPool_Pull |   100 | 1,471.3 ns | 2.60 ns | 2.17 ns |  1.55 |    0.01 | 0.0935 |     - |     - |     296 B |
|                           ForeachLoop |   100 |   947.0 ns | 7.05 ns | 6.59 ns |  1.00 |    0.00 | 0.2193 |     - |     - |     688 B |
|                                  Linq |   100 | 1,384.2 ns | 4.31 ns | 4.03 ns |  1.46 |    0.01 | 0.2575 |     - |     - |     808 B |
|                                LinqAF |   100 | 1,590.5 ns | 4.51 ns | 4.00 ns |  1.68 |    0.01 | 0.2193 |     - |     - |     688 B |
|                            StructLinq |   100 | 1,303.6 ns | 4.27 ns | 3.57 ns |  1.38 |    0.01 | 0.1221 |     - |     - |     384 B |
|                  StructLinq_IFunction |   100 |   971.5 ns | 2.79 ns | 2.61 ns |  1.03 |    0.01 | 0.0935 |     - |     - |     296 B |
|                             Hyperlinq |   100 | 1,472.3 ns | 3.03 ns | 2.83 ns |  1.55 |    0.01 | 0.0935 |     - |     - |     296 B |
|                   Hyperlinq_IFunction |   100 | 1,074.0 ns | 3.20 ns | 2.84 ns |  1.13 |    0.01 | 0.0935 |     - |     - |     296 B |
|                              Tinyield |   100 | 1,780.5 ns | 6.05 ns | 5.66 ns |  1.88 |    0.01 | 0.3586 |     - |     - |    1128 B |
