``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.15063.0 (1703/CreatorsUpdate/Redstone2)
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
Frequency=2143475 Hz, Resolution=466.5321 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                         Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|             LoggerInfoNoParams |  40.735 ns | 0.8369 ns | 1.3030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      LoggerMessageInfoNoParams |  10.356 ns | 0.2389 ns | 0.3576 ns |  0.25 |    0.01 |      - |     - |     - |         - |
|        LoggerInfoWithOneParams | 134.541 ns | 2.8823 ns | 8.4078 ns |  3.36 |    0.30 | 0.0203 |     - |     - |      32 B |
| LoggerMessageInfoWithOneParams |   9.409 ns | 0.2302 ns | 0.4266 ns |  0.23 |    0.01 |      - |     - |     - |         - |
|        LoggerInfoWithTwoParams | 161.926 ns | 3.2771 ns | 6.9125 ns |  4.00 |    0.25 | 0.0408 |     - |     - |      64 B |
| LoggerMessageInfoWithTwoParams |  10.743 ns | 0.2516 ns | 0.2471 ns |  0.26 |    0.01 |      - |     - |     - |         - |
