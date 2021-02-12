## List.ValueType.ListValueTypeWhereSelectToArray

### Source
[ListValueTypeWhereSelectToArray.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToArray.cs)

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
|                                        Method | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                            ValueLinq_Standard |   100 | 1.828 μs | 0.0116 μs | 0.0103 μs |  1.33 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                               ValueLinq_Stack |   100 | 1.744 μs | 0.0206 μs | 0.0192 μs |  1.26 |    0.02 | 0.6447 |     - |     - |    2024 B |
|                     ValueLinq_SharedPool_Push |   100 | 2.227 μs | 0.0423 μs | 0.0396 μs |  1.61 |    0.03 | 0.6447 |     - |     - |    2024 B |
|                     ValueLinq_SharedPool_Pull |   100 | 2.061 μs | 0.0188 μs | 0.0166 μs |  1.49 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                        ValueLinq_Ref_Standard |   100 | 1.665 μs | 0.0045 μs | 0.0040 μs |  1.21 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                           ValueLinq_Ref_Stack |   100 | 1.645 μs | 0.0039 μs | 0.0035 μs |  1.19 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                 ValueLinq_Ref_SharedPool_Push |   100 | 1.962 μs | 0.0088 μs | 0.0082 μs |  1.42 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                 ValueLinq_Ref_SharedPool_Pull |   100 | 2.086 μs | 0.0137 μs | 0.0128 μs |  1.51 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                ValueLinq_ValueLambda_Standard |   100 | 1.640 μs | 0.0179 μs | 0.0167 μs |  1.19 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                   ValueLinq_ValueLambda_Stack |   100 | 1.569 μs | 0.0134 μs | 0.0126 μs |  1.14 |    0.01 | 0.6447 |     - |     - |    2024 B |
|         ValueLinq_ValueLambda_SharedPool_Push |   100 | 1.674 μs | 0.0069 μs | 0.0065 μs |  1.21 |    0.01 | 0.6447 |     - |     - |    2024 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |   100 | 1.922 μs | 0.0100 μs | 0.0094 μs |  1.39 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                    ValueLinq_Standard_ByIndex |   100 | 1.511 μs | 0.0138 μs | 0.0129 μs |  1.10 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                       ValueLinq_Stack_ByIndex |   100 | 1.476 μs | 0.0083 μs | 0.0077 μs |  1.07 |    0.01 | 0.6447 |     - |     - |    2024 B |
|             ValueLinq_SharedPool_Push_ByIndex |   100 | 2.266 μs | 0.0374 μs | 0.0350 μs |  1.64 |    0.03 | 0.6447 |     - |     - |    2024 B |
|             ValueLinq_SharedPool_Pull_ByIndex |   100 | 1.838 μs | 0.0069 μs | 0.0065 μs |  1.33 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                ValueLinq_Ref_Standard_ByIndex |   100 | 1.415 μs | 0.0060 μs | 0.0056 μs |  1.03 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                   ValueLinq_Ref_Stack_ByIndex |   100 | 1.362 μs | 0.0062 μs | 0.0058 μs |  0.99 |    0.01 | 0.6447 |     - |     - |    2024 B |
|         ValueLinq_Ref_SharedPool_Push_ByIndex |   100 | 2.002 μs | 0.0141 μs | 0.0132 μs |  1.45 |    0.01 | 0.6447 |     - |     - |    2024 B |
|         ValueLinq_Ref_SharedPool_Pull_ByIndex |   100 | 1.716 μs | 0.0068 μs | 0.0064 μs |  1.24 |    0.01 | 0.6447 |     - |     - |    2024 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |   100 | 1.386 μs | 0.0064 μs | 0.0057 μs |  1.00 |    0.01 | 0.6447 |     - |     - |    2024 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |   100 | 1.350 μs | 0.0063 μs | 0.0059 μs |  0.98 |    0.01 | 0.6447 |     - |     - |    2024 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |   100 | 1.675 μs | 0.0065 μs | 0.0061 μs |  1.21 |    0.01 | 0.6447 |     - |     - |    2024 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |   100 | 1.643 μs | 0.0043 μs | 0.0038 μs |  1.19 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                                       ForLoop |   100 | 1.380 μs | 0.0080 μs | 0.0075 μs |  1.00 |    0.00 | 2.2736 |     - |     - |    7136 B |
|                                   ForeachLoop |   100 | 1.703 μs | 0.0082 μs | 0.0077 μs |  1.23 |    0.01 | 2.2736 |     - |     - |    7136 B |
|                                          Linq |   100 | 1.800 μs | 0.0235 μs | 0.0220 μs |  1.30 |    0.02 | 1.6556 |     - |     - |    5200 B |
|                                    LinqFaster |   100 | 1.851 μs | 0.0335 μs | 0.0314 μs |  1.34 |    0.02 | 2.2736 |     - |     - |    7136 B |
|                                        LinqAF |   100 | 3.422 μs | 0.0613 μs | 0.0573 μs |  2.48 |    0.04 | 2.2621 |     - |     - |    7104 B |
|                                    StructLinq |   100 | 1.649 μs | 0.0061 μs | 0.0057 μs |  1.19 |    0.01 | 0.6771 |     - |     - |    2128 B |
|                          StructLinq_IFunction |   100 | 1.196 μs | 0.0056 μs | 0.0053 μs |  0.87 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                                     Hyperlinq |   100 | 1.470 μs | 0.0061 μs | 0.0057 μs |  1.07 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                           Hyperlinq_IFunction |   100 | 1.149 μs | 0.0060 μs | 0.0056 μs |  0.83 |    0.01 | 0.6447 |     - |     - |    2024 B |
|                                Hyperlinq_Pool |   100 | 1.392 μs | 0.0037 μs | 0.0035 μs |  1.01 |    0.01 | 0.0172 |     - |     - |      56 B |
|                      Hyperlinq_Pool_IFunction |   100 | 1.099 μs | 0.0030 μs | 0.0025 μs |  0.80 |    0.00 | 0.0172 |     - |     - |      56 B |
|                                      Tinyield |   100 | 3.171 μs | 0.0149 μs | 0.0139 μs |  2.30 |    0.01 | 2.4338 |     - |     - |    7648 B |
