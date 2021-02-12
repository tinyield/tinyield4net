## Range.RangeToArray

### Source
[RangeToArray.cs](../LinqBenchmarks/Range/RangeToArray.cs)

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
|                    Method | Start | Count |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |------ |------ |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|        ValueLinq_Standard |     0 |   100 |   299.79 ns | 2.232 ns | 2.087 ns |  2.87 |    0.02 | 0.1349 |     - |     - |     424 B |
|           ValueLinq_Stack |     0 |   100 |   432.03 ns | 3.664 ns | 2.860 ns |  4.14 |    0.04 | 0.2112 |     - |     - |     664 B |
| ValueLinq_SharedPool_Push |     0 |   100 |   502.50 ns | 2.531 ns | 2.244 ns |  4.81 |    0.03 | 0.1345 |     - |     - |     424 B |
| ValueLinq_SharedPool_Pull |     0 |   100 |   566.92 ns | 2.690 ns | 2.246 ns |  5.43 |    0.03 | 0.1345 |     - |     - |     424 B |
|                   ForLoop |     0 |   100 |   104.39 ns | 0.414 ns | 0.387 ns |  1.00 |    0.00 | 0.1351 |     - |     - |     424 B |
|                      Linq |     0 |   100 |   115.97 ns | 1.035 ns | 0.918 ns |  1.11 |    0.01 | 0.1478 |     - |     - |     464 B |
|                LinqFaster |     0 |   100 |    90.91 ns | 0.456 ns | 0.426 ns |  0.87 |    0.01 | 0.1351 |     - |     - |     424 B |
|                    LinqAF |     0 |   100 |   335.18 ns | 0.900 ns | 0.841 ns |  3.21 |    0.01 | 0.1349 |     - |     - |     424 B |
|                StructLinq |     0 |   100 |   106.39 ns | 0.752 ns | 0.704 ns |  1.02 |    0.01 | 0.1351 |     - |     - |     424 B |
|                 Hyperlinq |     0 |   100 |   113.38 ns | 0.521 ns | 0.487 ns |  1.09 |    0.01 | 0.1351 |     - |     - |     424 B |
|            Hyperlinq_Pool |     0 |   100 |   170.39 ns | 0.471 ns | 0.441 ns |  1.63 |    0.01 | 0.0176 |     - |     - |      56 B |
|                  Tinyield |     0 |   100 | 1,139.64 ns | 5.969 ns | 5.583 ns | 10.92 |    0.06 | 0.5722 |     - |     - |    1800 B |
