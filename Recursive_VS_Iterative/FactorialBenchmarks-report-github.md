```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i5-2500 CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET SDK 6.0.116
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX


```
| Method                      | n  | Mean     | Error    | StdDev   | Allocated |
|---------------------------- |--- |---------:|---------:|---------:|----------:|
| RecursiveFactorialBenchmark | 20 | 53.76 ns | 0.326 ns | 0.305 ns |         - |
| IterativeFactorialBenchmark | 20 | 11.66 ns | 0.266 ns | 0.249 ns |         - |
