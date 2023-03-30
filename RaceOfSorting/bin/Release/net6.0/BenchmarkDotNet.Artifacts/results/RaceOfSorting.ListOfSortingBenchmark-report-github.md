``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19045
AMD A8-9600 RADEON R7, 10 COMPUTE CORES 4C+6G, 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT


```
|            Method |         Mean |      Error |     StdDev | Rank |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|------------------ |-------------:|-----------:|-----------:|-----:|---------:|---------:|---------:|----------:|
|     TestQuickSort |     7.474 μs |  0.0967 μs |  0.0858 μs |    1 |   7.6904 |        - |        - |      4 KB |
|    TestBoobleSort | 1,565.182 μs | 10.7496 μs | 10.0552 μs |    4 |   5.8594 |        - |        - |      4 KB |
| TestSelectionSort |   689.263 μs |  3.1935 μs |  2.9872 μs |    3 |   6.8359 |        - |        - |      4 KB |
|  TestCountingSort |   472.290 μs |  8.6808 μs |  8.1200 μs |    2 | 124.5117 | 124.5117 | 124.5117 |    394 KB |
