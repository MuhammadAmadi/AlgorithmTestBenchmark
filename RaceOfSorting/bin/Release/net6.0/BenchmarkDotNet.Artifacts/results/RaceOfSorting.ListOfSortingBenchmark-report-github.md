``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19045
AMD A8-9600 RADEON R7, 10 COMPUTE CORES 4C+6G, 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT


```
|            Method |         Mean |     Error |    StdDev | Rank |   Gen 0 | Allocated |
|------------------ |-------------:|----------:|----------:|-----:|--------:|----------:|
|     TestQuickSort |     5.902 μs | 0.0869 μs | 0.0813 μs |    1 |  7.6904 |      4 KB |
|    TestBoobleSort | 1,577.787 μs | 9.3121 μs | 8.7105 μs |    5 |  5.8594 |      4 KB |
| TestSelectionSort |   694.241 μs | 3.8109 μs | 3.1822 μs |    4 |  6.8359 |      4 KB |
|  TestCountingSort |     8.166 μs | 0.1579 μs | 0.1477 μs |    2 | 15.3809 |      8 KB |
|    TestDotnetSort |    31.043 μs | 0.2539 μs | 0.2250 μs |    3 |  7.6904 |      4 KB |
