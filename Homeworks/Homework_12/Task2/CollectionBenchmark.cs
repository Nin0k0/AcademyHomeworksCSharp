using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
namespace Task2
{
    [MemoryDiagnoser]
    [WarmupCount(2)]
    [IterationCount(1)]
    
    
    public class CollectionBenchmark
    {



        public List<int> list = new List<int>();
        public HashSet<int> hashSet = new HashSet<int>();
        public Hashtable hashTable = new Hashtable();
        public Stack<int> stack = new Stack<int>();
        public Queue<int> queue = new Queue<int>();
        public Dictionary<int, string> dictionary = new Dictionary<int, string>();
        int value1 = 10;


        [Benchmark]
        public void ListAdd()
        {
            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
            }
        }


        [Benchmark(OperationsPerInvoke = 16)]
        public void ListIteration()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        [Benchmark(OperationsPerInvoke = 16)]
        public void ListRemove()
        {
            list.Remove(value1);
        }





        [Benchmark(OperationsPerInvoke = 16)]
        public void HashSetAdd()
        {
            hashSet.Add(15);
        }



        [Benchmark(OperationsPerInvoke = 16)]
        public void HashSetIteration()
        {
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }


        [Benchmark(OperationsPerInvoke = 16)]
        public void HashSetRemove()
        {
            hashSet.Remove(1001);
        }

        [Benchmark]
        public void HashtableAdd()
        {
            for (int i = 0; i < 10000; i++)
            {
                hashTable.Add(i,i);
            }
        }


        [Benchmark(OperationsPerInvoke = 16)]
        public void HashtableIteration()
        {
            foreach (var item in hashTable)
            {
                Console.WriteLine(item);
            }
        }
        [Benchmark(OperationsPerInvoke = 16)]
        public void HashtableRemove()
        {
            hashTable.Remove("some1");
        }

        [Benchmark]
        public void StackPush()
        {
            for (int i = 0; i < 10000; i++)
            {
                stack.Push(i);
            }
        }
        [Benchmark(OperationsPerInvoke = 16)]
        public void StackIteration()
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        [Benchmark]
        public void StackPop()
        {
            for (int i = 0; i < 10000; i++)
            {
                stack.Pop();
            }
        }




        [Benchmark(OperationsPerInvoke = 16)]
        public void QueueEnqueue()
        {
            queue.Enqueue(1001);
        }

        [Benchmark(OperationsPerInvoke = 16)]
        public void QueueDequeue()
        {
            queue.Dequeue();
        }

        [Benchmark(OperationsPerInvoke = 16)]
        public void QueueIteration()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            };
        }

        [Benchmark]
        public void DictionaryAdd()
        {
            for (int i = 0; i < 10000; i++)
            {
                dictionary.Add(i, $"Value{i}");
            }
        }

        [Benchmark]
        public void DictionaryUpdate()
        {
            dictionary[100] = "someTest";
        }
        [Benchmark(OperationsPerInvoke = 16)]
        public void DictionaryIteration()
        {
            foreach (var kvp in dictionary)
            {
                var key = kvp.Key;
                var value = kvp.Value;
            }
        }
        [Benchmark(OperationsPerInvoke = 16)]
        public void DictionaryRemove()
        {
            dictionary.Remove(1001);
        }












    }

}
