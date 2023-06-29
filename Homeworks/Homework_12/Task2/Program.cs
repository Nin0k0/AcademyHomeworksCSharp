using BenchmarkDotNet.Running;
using System;
using Task2.Task2;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {

            //var benchmark = BenchmarkRunner.Run<CollectionBenchmark>();

            var stopWatch = new PerfomanceStopWatch();

            // List operations
            stopWatch.ListAdd();
            stopWatch.ListIteration();
            stopWatch.ListRemove();
            Console.WriteLine();
            // HashSet operations
            stopWatch.HashSetAdd();
            stopWatch.HashSetIteration();
            stopWatch.HashSetRemove();
            Console.WriteLine();
            // Hashtable operations
            stopWatch.HashtableAdd();
            stopWatch.HashtableIteration();
            stopWatch.HashtableRemove();
            Console.WriteLine();
            // Stack operations
            stopWatch.StackPush();
            stopWatch.StackIteration();
            stopWatch.StackPop();
            Console.WriteLine();
            // Dictionary operations
            stopWatch.DictionaryAdd();
            stopWatch.DictionaryUpdate();
            stopWatch.DictionaryIteration();
            stopWatch.DictionaryRemove();

            Console.ReadLine();
        }
    }
}
