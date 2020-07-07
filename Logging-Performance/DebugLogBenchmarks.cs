using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logging_Performance
{
    [MemoryDiagnoser]
    public class DebugLogBenchmarks
    {
        private LoggerLogging _loggerLogging;
        private LoggerMessageLogging _loggerMessageLogging;
        private const string Value1 = "Value";
        private const int Value2 = 100;

        [GlobalSetup]
        public void Setup()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging(builder => builder
                .AddFilter("LoggingBenchmarks", LogLevel.Debug)
            );

            var loggerFactory = serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();

            var logger = loggerFactory.CreateLogger("TEST");

            _loggerLogging = new LoggerLogging(logger);
            _loggerMessageLogging = new LoggerMessageLogging(logger);
        }

        [Benchmark(Baseline = true)]
        public void LoggerDebugNoParams() => _loggerLogging.LogDebug();

        [Benchmark]
        public void LoggerMessageDebugNoParams() => _loggerMessageLogging.LogDebug();

        [Benchmark]
        public void LoggerDebugWithOneParams() => _loggerLogging.LogDebug(Value1);

        [Benchmark]
        public void LoggerMessageDebugWithOneParams() => _loggerMessageLogging.LogDebug(Value1);

        [Benchmark]
        public void LoggerDebugWithTwoParams() => _loggerLogging.LogDebug(Value1, Value2);

        [Benchmark]
        public void LoggerMessageDebugWithTwoParams() => _loggerMessageLogging.LogDebug(Value1, Value2);
    }
}
