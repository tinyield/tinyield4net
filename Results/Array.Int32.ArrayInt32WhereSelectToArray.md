## Array.Int32.ArrayInt32WhereSelectToArray

### Source
[ArrayInt32WhereSelectToArray.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToArray.cs)

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
|                    ValueLinq_Standard |   100 |   756.2 ns | 2.93 ns | 2.45 ns |  2.51 |    0.02 | 0.0706 |     - |     - |     224 B |
|                       ValueLinq_Stack |   100 |   709.9 ns | 1.86 ns | 1.65 ns |  2.35 |    0.02 | 0.0706 |     - |     - |     224 B |
|             ValueLinq_SharedPool_Push |   100 | 1,063.6 ns | 6.21 ns | 5.80 ns |  3.53 |    0.03 | 0.0706 |     - |     - |     224 B |
|             ValueLinq_SharedPool_Pull |   100 |   918.5 ns | 1.95 ns | 1.63 ns |  3.04 |    0.02 | 0.0706 |     - |     - |     224 B |
|        ValueLinq_ValueLambda_Standard |   100 |   468.7 ns | 0.77 ns | 0.72 ns |  1.55 |    0.01 | 0.0710 |     - |     - |     224 B |
|           ValueLinq_ValueLambda_Stack |   100 |   413.5 ns | 1.24 ns | 1.16 ns |  1.37 |    0.01 | 0.0710 |     - |     - |     224 B |
| ValueLinq_ValueLambda_SharedPool_Push |   100 |   731.8 ns | 1.93 ns | 1.71 ns |  2.42 |    0.02 | 0.0706 |     - |     - |     224 B |
| ValueLinq_ValueLambda_SharedPool_Pull |   100 |   734.8 ns | 2.84 ns | 2.22 ns |  2.44 |    0.02 | 0.0706 |     - |     - |     224 B |
|                               ForLoop |   100 |   301.7 ns | 1.98 ns | 1.85 ns |  1.00 |    0.00 | 0.2780 |     - |     - |     872 B |
|                           ForeachLoop |   100 |   302.1 ns | 1.88 ns | 1.67 ns |  1.00 |    0.01 | 0.2780 |     - |     - |     872 B |
|                                  Linq |   100 |   738.7 ns | 8.13 ns | 7.21 ns |  2.45 |    0.03 | 0.2470 |     - |     - |     776 B |
|                            LinqFaster |   100 |   441.5 ns | 1.00 ns | 0.89 ns |  1.46 |    0.01 | 0.2065 |     - |     - |     648 B |
|                                LinqAF |   100 |   836.2 ns | 3.11 ns | 2.91 ns |  2.77 |    0.02 | 0.2670 |     - |     - |     840 B |
|                            StructLinq |   100 |   748.8 ns | 2.21 ns | 2.07 ns |  2.48 |    0.02 | 0.1011 |     - |     - |     320 B |
|                  StructLinq_IFunction |   100 |   364.1 ns | 2.29 ns | 2.03 ns |  1.21 |    0.01 | 0.0710 |     - |     - |     224 B |
|                             Hyperlinq |   100 |   789.2 ns | 2.81 ns | 2.62 ns |  2.62 |    0.02 | 0.0706 |     - |     - |     224 B |
|                   Hyperlinq_IFunction |   100 |   450.7 ns | 1.43 ns | 1.19 ns |  1.49 |    0.01 | 0.0710 |     - |     - |     224 B |
|                        Hyperlinq_Pool |   100 |   882.7 ns | 1.71 ns | 1.43 ns |  2.93 |    0.02 | 0.0172 |     - |     - |      56 B |
|              Hyperlinq_Pool_IFunction |   100 |   881.3 ns | 2.73 ns | 2.55 ns |  2.92 |    0.02 | 0.0172 |     - |     - |      56 B |
|                              Tinyield |   100 | 1,170.1 ns | 6.04 ns | 5.36 ns |  3.88 |    0.03 | 0.4196 |     - |     - |    1320 B |
