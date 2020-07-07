# Logging Benchmarks

Info, Debug and Warning level logging benchmarks compared b/w logger and loggermessage patterns.

LoggerMessage features create cacheable delegates that require fewer object allocations and reduced computational overhead compared to logger extension methods, such as LogInformation and LogDebug. For high-performance logging scenarios, use the LoggerMessage pattern.

LoggerMessage provides the following performance advantages over Logger extension methods:

Logger extension methods require "boxing" (converting) value types, such as int, into object. The LoggerMessage pattern avoids boxing by using static Action fields and extension methods with strongly-typed parameters.
Logger extension methods must parse the message template (named format string) every time a log message is written. LoggerMessage only requires parsing a template once when the message is defined.

references
1. https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/loggermessage?view=aspnetcore-3.1
2. https://github.com/dotnet/BenchmarkDotNet
