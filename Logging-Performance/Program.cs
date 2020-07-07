using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Logging_Performance
{
    internal class Program
    {
        private static void Main(string[] args) 
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        } 
    }
    
}
