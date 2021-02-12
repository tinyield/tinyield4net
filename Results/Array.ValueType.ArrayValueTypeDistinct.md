## Array.ValueType.ArrayValueTypeDistinct

### Source
[ArrayValueTypeDistinct.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeDistinct.cs)

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
|               Method | Duplicates | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------- |------ |-------------:|-----------:|-----------:|------:|--------:|----------:|------:|------:|----------:|
|              ForLoop |          4 |   100 |   682.144 μs |  4.5167 μs |  4.2249 μs | 1.000 |    0.00 |  730.4688 |     - |     - | 2292184 B |
|          ForeachLoop |          4 |   100 |   670.414 μs |  5.7555 μs |  5.3837 μs | 0.983 |    0.01 |  730.4688 |     - |     - | 2292184 B |
|                 Linq |          4 |   100 |   704.974 μs |  4.9033 μs |  4.5866 μs | 1.034 |    0.01 |  728.5156 |     - |     - | 2286672 B |
|               LinqAF |          4 |   100 | 2,256.640 μs | 18.0433 μs | 16.8777 μs | 3.308 |    0.03 | 1457.0313 |     - |     - | 4575077 B |
|           StructLinq |          4 |   100 |   764.125 μs |  4.2637 μs |  3.9883 μs | 1.120 |    0.01 |  724.6094 |     - |     - | 2273657 B |
| StructLinq_IFunction |          4 |   100 |     6.347 μs |  0.0206 μs |  0.0193 μs | 0.009 |    0.00 |         - |     - |     - |         - |
|            Hyperlinq |          4 |   100 |   672.099 μs |  6.2060 μs |  5.8051 μs | 0.985 |    0.01 |  697.2656 |     - |     - | 2187585 B |
|             Tinyield |          4 |   100 |   671.264 μs |  5.2851 μs |  4.9437 μs | 0.984 |    0.01 |  730.4688 |     - |     - | 2292528 B |
