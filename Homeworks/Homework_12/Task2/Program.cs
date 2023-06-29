using BenchmarkDotNet.Running;
using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var list = BenchmarkRunner.Run<ListBenchmark>();
        }
    }
}
