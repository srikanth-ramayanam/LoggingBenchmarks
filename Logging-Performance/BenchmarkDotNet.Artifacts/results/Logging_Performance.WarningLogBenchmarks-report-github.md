``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.15063.0 (1703/CreatorsUpdate/Redstone2)
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
Frequency=2143475 Hz, Resolution=466.5321 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|             LoggerWarningNoParams |  40.822 ns | 0.8619 ns | 1.3670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      LoggerMessageWarningNoParams |  10.040 ns | 0.2406 ns | 0.3373 ns |  0.25 |    0.01 |      - |     - |     - |         - |
|        LoggerWarningWithOneParams | 129.119 ns | 2.6636 ns | 7.8120 ns |  3.11 |    0.19 | 0.0203 |     - |     - |      32 B |
| LoggerMessageWarningWithOneParams |   9.478 ns | 0.2319 ns | 0.3175 ns |  0.23 |    0.01 |      - |     - |     - |         - |
|        LoggerWarningWithTwoParams | 159.118 ns | 3.1905 ns | 6.2977 ns |  3.89 |    0.20 | 0.0408 |     - |     - |      64 B |
| LoggerMessageWarningWithTwoParams |  10.858 ns | 0.2572 ns | 0.2752 ns |  0.27 |    0.01 |      - |     - |     - |         - |
