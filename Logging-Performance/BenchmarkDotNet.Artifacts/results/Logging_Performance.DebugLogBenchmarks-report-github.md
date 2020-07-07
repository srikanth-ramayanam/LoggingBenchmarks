``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.15063.0 (1703/CreatorsUpdate/Redstone2)
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
Frequency=2143475 Hz, Resolution=466.5321 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                          Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|             LoggerDebugNoParams |  40.778 ns | 0.8592 ns | 1.7551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      LoggerMessageDebugNoParams |  10.736 ns | 0.2686 ns | 0.7749 ns |  0.26 |    0.02 |      - |     - |     - |         - |
|        LoggerDebugWithOneParams | 130.199 ns | 2.7594 ns | 8.0929 ns |  3.23 |    0.26 | 0.0203 |     - |     - |      32 B |
| LoggerMessageDebugWithOneParams |   9.469 ns | 0.2289 ns | 0.3697 ns |  0.23 |    0.01 |      - |     - |     - |         - |
|        LoggerDebugWithTwoParams | 159.080 ns | 3.1986 ns | 7.7859 ns |  3.91 |    0.24 | 0.0408 |     - |     - |      64 B |
| LoggerMessageDebugWithTwoParams |  10.849 ns | 0.2630 ns | 0.3687 ns |  0.27 |    0.02 |      - |     - |     - |         - |
