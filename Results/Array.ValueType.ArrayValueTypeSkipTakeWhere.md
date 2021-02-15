## Array.ValueType.ArrayValueTypeSkipTakeWhere

### Source
[ArrayValueTypeSkipTakeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeWhere.cs)

### References:
- Cistern.ValueLinq: [0.1.14](https://www.nuget.org/packages/Cistern.ValueLinq/0.1.14)
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta31](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta31)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.804 (2004/?/20H1)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  Job-IYGCDH : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|               Method | Skip | Count |       Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------- |----- |------ |-----------:|----------:|----------:|------:|--------:|
|              ForLoop | 1000 |   100 |   364.1 ns |  11.69 ns |   6.11 ns |  1.00 |    0.00 |
|          ForeachLoop | 1000 |   100 | 2,263.3 ns | 356.51 ns | 186.46 ns |  6.22 |    0.54 |
|                 Linq | 1000 |   100 | 1,451.0 ns |  30.41 ns |  10.84 ns |  4.01 |    0.07 |
|           LinqFaster | 1000 |   100 | 1,333.4 ns |   7.45 ns |   3.90 ns |  3.66 |    0.06 |
|               LinqAF | 1000 |   100 | 5,190.2 ns | 970.51 ns | 507.60 ns | 14.26 |    1.43 |
|           StructLinq | 1000 |   100 |   640.3 ns |  24.42 ns |  10.84 ns |  1.77 |    0.05 |
| StructLinq_IFunction | 1000 |   100 |   439.8 ns |   3.18 ns |   1.41 ns |  1.21 |    0.02 |
|            Hyperlinq | 1000 |   100 |   450.8 ns |   3.68 ns |   1.31 ns |  1.25 |    0.02 |
|  Hyperlinq_IFunction | 1000 |   100 |   445.2 ns |  48.62 ns |  25.43 ns |  1.22 |    0.06 |
|             Tinyield | 1000 |   100 | 7,104.5 ns | 104.26 ns |  46.29 ns | 19.60 |    0.35 |
