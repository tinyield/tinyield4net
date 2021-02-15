## Last.FM.ZipTopArtistAndTrackByCountryBenchmark

### Source
[ZipTopArtistAndTrackByCountryBenchmark.cs](../LinqBenchmarks/Last/FM/ZipTopArtistAndTrackByCountryBenchmark.cs)

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
  Job-QKIOSF : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|      Method | Count |      Mean |     Error |   StdDev | Ratio | RatioSD |
|------------ |------ |----------:|----------:|---------:|------:|--------:|
| ForeachLoop |   100 |  41.08 μs |  0.957 μs | 0.425 μs |  1.00 |    0.00 |
|        Linq |   100 |  87.87 μs |  4.418 μs | 1.962 μs |  2.14 |    0.06 |
|      LinqAF |   100 | 116.55 μs | 18.822 μs | 9.844 μs |  2.90 |    0.17 |
|   Hyperlinq |   100 |  86.15 μs |  1.559 μs | 0.815 μs |  2.09 |    0.04 |
|    Tinyield |   100 | 165.05 μs |  0.768 μs | 0.402 μs |  4.02 |    0.05 |
