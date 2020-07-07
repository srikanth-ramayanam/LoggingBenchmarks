using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logging_Performance
{
    [MemoryDiagnoser]
    public class InfoLogBenchmarks
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
                .AddFilter("LoggingBenchmarks", LogLevel.Information)
            );

            var loggerFactory = serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();

            var logger = loggerFactory.CreateLogger("TEST");

            _loggerLogging = new LoggerLogging(logger);
            _loggerMessageLogging = new LoggerMessageLogging(logger);
        }

        [Benchmark(Baseline = true)]
        public void LoggerInfoNoParams() => _loggerLogging.LogInfo();

        [Benchmark]
        public void LoggerMessageInfoNoParams() => _loggerMessageLogging.LogInfo();

        [Benchmark]
        public void LoggerInfoWithOneParams() => _loggerLogging.LogInfo(Value1);

        [Benchmark]
        public void LoggerMessageInfoWithOneParams() => _loggerMessageLogging.LogInfo(Value1);

        [Benchmark]
        public void LoggerInfoWithTwoParams() => _loggerLogging.LogInfo(Value1, Value2);

        [Benchmark]
        public void LoggerMessageInfoWithTwoParams() => _loggerMessageLogging.LogInfo(Value1, Value2);
    }
}
