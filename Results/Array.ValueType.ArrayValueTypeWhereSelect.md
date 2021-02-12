## Array.ValueType.ArrayValueTypeWhereSelect

### Source
[ArrayValueTypeWhereSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelect.cs)

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
|               Method | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|              ForLoop |   100 | 1.091 μs | 0.0036 μs | 0.0034 μs |  1.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 | 1.194 μs | 0.0032 μs | 0.0030 μs |  1.09 |      - |     - |     - |         - |
|                 Linq |   100 | 1.851 μs | 0.0047 μs | 0.0044 μs |  1.70 | 0.0534 |     - |     - |     168 B |
|           LinqFaster |   100 | 1.908 μs | 0.0101 μs | 0.0095 μs |  1.75 | 1.9264 |     - |     - |    6048 B |
|               LinqAF |   100 | 2.414 μs | 0.0183 μs | 0.0172 μs |  2.21 |      - |     - |     - |         - |
|           StructLinq |   100 | 1.515 μs | 0.0029 μs | 0.0027 μs |  1.39 | 0.0191 |     - |     - |      64 B |
| StructLinq_IFunction |   100 | 1.233 μs | 0.0035 μs | 0.0033 μs |  1.13 |      - |     - |     - |         - |
|            Hyperlinq |   100 | 1.465 μs | 0.0024 μs | 0.0022 μs |  1.34 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 | 1.311 μs | 0.0031 μs | 0.0029 μs |  1.20 |      - |     - |     - |         - |
|             Tinyield |   100 | 2.110 μs | 0.0117 μs | 0.0110 μs |  1.93 | 0.1602 |     - |     - |     504 B |
