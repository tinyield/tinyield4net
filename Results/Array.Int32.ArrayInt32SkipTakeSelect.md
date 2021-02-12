## Array.Int32.ArrayInt32SkipTakeSelect

### Source
[ArrayInt32SkipTakeSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeSelect.cs)

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
|                      Method | Skip | Count |        Mean |     Error |    StdDev |  Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |------------:|----------:|----------:|-------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | 1000 |   100 |    73.97 ns |  0.278 ns |  0.260 ns |   1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | 1000 |   100 | 3,178.36 ns | 11.947 ns | 10.591 ns |  42.97 |    0.17 | 0.0076 |     - |     - |      32 B |
|                        Linq | 1000 |   100 | 1,326.04 ns |  4.370 ns |  4.087 ns |  17.93 |    0.09 | 0.0477 |     - |     - |     152 B |
|                  LinqFaster | 1000 |   100 |   490.38 ns |  4.274 ns |  3.789 ns |   6.63 |    0.06 | 0.4053 |     - |     - |    1272 B |
|                      LinqAF | 1000 |   100 | 3,860.51 ns | 14.368 ns | 13.440 ns |  52.19 |    0.26 |      - |     - |     - |         - |
|                  StructLinq | 1000 |   100 |   349.67 ns |  1.148 ns |  1.074 ns |   4.73 |    0.02 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |   100 |   231.52 ns |  0.289 ns |  0.271 ns |   3.13 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |   100 |   270.87 ns |  0.933 ns |  0.828 ns |   3.66 |    0.01 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |   100 |   226.53 ns |  0.419 ns |  0.371 ns |   3.06 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |   100 |   269.15 ns |  0.921 ns |  0.862 ns |   3.64 |    0.02 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |   100 |   125.33 ns |  0.577 ns |  0.539 ns |   1.69 |    0.01 |      - |     - |     - |         - |
|                    Tinyield | 1000 |   100 | 8,438.45 ns | 30.767 ns | 28.779 ns | 114.08 |    0.55 | 0.1373 |     - |     - |     440 B |
