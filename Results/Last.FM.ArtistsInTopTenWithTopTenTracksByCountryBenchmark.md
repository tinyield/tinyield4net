## Last.FM.ArtistsInTopTenWithTopTenTracksByCountryBenchmark

### Source
[ArtistsInTopTenWithTopTenTracksByCountryBenchmark.cs](../LinqBenchmarks/Last/FM/ArtistsInTopTenWithTopTenTracksByCountryBenchmark.cs)

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
  Job-TCRWME : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Runtime=.NET Core 5.0  IterationCount=8  

```
|   Method | Count |     Mean |   Error |  StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |---------:|--------:|--------:|---------:|------:|------:|----------:|
| Tinyield |    10 | 390.2 μs | 9.90 μs | 4.40 μs | 185.5469 |     - |     - | 758.04 KB |
