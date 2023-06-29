using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace Task2
{
    public class ListBenchmark
    {
        private List<int> list;
        private int value = 100;
        private int index = 2;

        [GlobalSetup]
        public void Setup()
        {
            list = new List<int>();
        }

        [Benchmark]
        public void AddToList()
        {
            list.Add(value);
        }

        [Benchmark]
        public void UpdateList()
        {
            if (index >= 0 && index < list.Count)
            {
                list[index] = value;
            }
        }

        [Benchmark]
        public void RemoveFromList()
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
        }

        [Benchmark]
        public void IterateList()
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
