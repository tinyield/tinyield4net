## Range.RangeToList

### Source
[RangeToList.cs](../LinqBenchmarks/Range/RangeToList.cs)

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
|                    Method | Start | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |------ |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|        ValueLinq_Standard |     0 |   100 |   355.4 ns | 1.66 ns | 1.55 ns |  0.92 |    0.01 | 0.1450 |     - |     - |     456 B |
|           ValueLinq_Stack |     0 |   100 |   690.7 ns | 3.97 ns | 3.32 ns |  1.80 |    0.01 | 0.2213 |     - |     - |     696 B |
| ValueLinq_SharedPool_Push |     0 |   100 |   538.6 ns | 2.64 ns | 2.47 ns |  1.40 |    0.01 | 0.1450 |     - |     - |     456 B |
| ValueLinq_SharedPool_Pull |     0 |   100 |   734.2 ns | 2.32 ns | 2.06 ns |  1.91 |    0.01 | 0.1450 |     - |     - |     456 B |
|                   ForLoop |     0 |   100 |   384.7 ns | 1.52 ns | 1.42 ns |  1.00 |    0.00 | 0.3772 |     - |     - |    1184 B |
|               ForeachLoop |     0 |   100 |   897.5 ns | 2.48 ns | 2.32 ns |  2.33 |    0.01 | 0.3948 |     - |     - |    1240 B |
|                      Linq |     0 |   100 |   259.4 ns | 1.59 ns | 1.48 ns |  0.67 |    0.00 | 0.1578 |     - |     - |     496 B |
|                LinqFaster |     0 |   100 |   166.5 ns | 1.30 ns | 1.22 ns |  0.43 |    0.00 | 0.2804 |     - |     - |     880 B |
|                    LinqAF |     0 |   100 |   448.6 ns | 0.94 ns | 0.83 ns |  1.17 |    0.00 | 0.1450 |     - |     - |     456 B |
|                StructLinq |     0 |   100 |   114.7 ns | 1.20 ns | 1.12 ns |  0.30 |    0.00 | 0.1452 |     - |     - |     456 B |
|                 Hyperlinq |     0 |   100 |   135.9 ns | 1.12 ns | 1.04 ns |  0.35 |    0.00 | 0.1554 |     - |     - |     488 B |
|                  Tinyield |     0 |   100 | 1,002.2 ns | 5.04 ns | 4.71 ns |  2.61 |    0.02 | 0.4387 |     - |     - |    1376 B |
