## Array.Int32.ArrayInt32Select

### Source
[ArrayInt32Select.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Select.cs)

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
|                      Method | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop |   100 |  61.28 ns | 0.229 ns | 0.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop |   100 |  60.87 ns | 0.221 ns | 0.207 ns |  0.99 |    0.01 |      - |     - |     - |         - |
|                        Linq |   100 | 929.06 ns | 2.218 ns | 2.075 ns | 15.16 |    0.07 | 0.0153 |     - |     - |      48 B |
|                  LinqFaster |   100 | 372.18 ns | 1.189 ns | 1.113 ns |  6.07 |    0.03 | 0.1349 |     - |     - |     424 B |
|                      LinqAF |   100 | 619.00 ns | 1.786 ns | 1.491 ns | 10.10 |    0.03 |      - |     - |     - |         - |
|                  StructLinq |   100 | 302.27 ns | 0.690 ns | 0.645 ns |  4.93 |    0.02 | 0.0100 |     - |     - |      32 B |
|        StructLinq_IFunction |   100 | 231.10 ns | 0.257 ns | 0.227 ns |  3.77 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |   100 | 249.05 ns | 1.260 ns | 1.117 ns |  4.06 |    0.02 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |   100 | 223.49 ns | 0.420 ns | 0.350 ns |  3.65 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For |   100 | 276.82 ns | 1.571 ns | 1.469 ns |  4.52 |    0.03 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction |   100 | 122.03 ns | 0.541 ns | 0.480 ns |  1.99 |    0.01 |      - |     - |     - |         - |
|                    Tinyield |   100 | 662.74 ns | 2.505 ns | 2.343 ns | 10.82 |    0.06 | 0.0992 |     - |     - |     312 B |
