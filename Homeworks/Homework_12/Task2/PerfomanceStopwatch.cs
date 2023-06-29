using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;

    namespace Task2
    {
        public class PerfomanceStopWatch
        {
            public List<int> list = new List<int>();
            public HashSet<int> hashSet = new HashSet<int>();
            public Hashtable hashTable = new Hashtable();
            public Stack<int> stack = new Stack<int>();
            public Queue<int> queue = new Queue<int>();
            public Dictionary<int, string> dictionary = new Dictionary<int, string>();

            int value1 = 10;

            public void ListAdd()
            {
                Stopwatch stopwatch1 = Stopwatch.StartNew();
                for (int i = 0; i < 10000000; i++)
                {
                    list.Add(i);
                }
                stopwatch1.Stop();
                Console.WriteLine($"ListAdd: Elapsed time: {stopwatch1.ElapsedMilliseconds} ms");
            }

            public void ListIteration()
            {
                Stopwatch stopwatch2 = Stopwatch.StartNew();
                foreach (var item in list)
                {
                    var something = 1+1;
                }
                stopwatch2.Stop();
                Console.WriteLine($"ListIteration: Elapsed time: {stopwatch2.ElapsedMilliseconds} ms");
            }

            public void ListRemove()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                list.Remove(value1);
                stopwatch.Stop();
                Console.WriteLine($"ListRemove: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void HashSetAdd()
            {
                Stopwatch stopwatch3 = Stopwatch.StartNew();

                for(int i = 0; i < 10000000; i++)
                {
                    hashSet.Add(i);
                }
                
                stopwatch3.Stop();
                Console.WriteLine($"HashSetAdd: Elapsed time: {stopwatch3.ElapsedMilliseconds} ms");
            }

            public void HashSetIteration()
            {
                Stopwatch stopwatch4 = Stopwatch.StartNew();
                foreach (var item in hashSet)
                {
                    var something = 1 + 1;
                }
                stopwatch4.Stop();
                Console.WriteLine($"HashSetIteration: Elapsed time: {stopwatch4.ElapsedMilliseconds} ms");
            }

            public void HashSetRemove()
            {
                Stopwatch stopwatch5 = Stopwatch.StartNew();
                hashSet.Remove(15);
                stopwatch5.Stop();
                Console.WriteLine($"HashSetRemove: Elapsed time: {stopwatch5.ElapsedMilliseconds} ms");
            }

            public void HashtableAdd()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                for (int i = 0; i < 10000000; i++)
                {
                    hashTable.Add(i, i);
                }
                stopwatch.Stop();
                Console.WriteLine($"HashtableAdd: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void HashtableIteration()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                foreach (var item in hashTable)
                {
                    var something = 1 + 1;
                }
                stopwatch.Stop();
                Console.WriteLine($"HashtableIteration: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void HashtableRemove()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                hashTable.Remove("some1");
                stopwatch.Stop();
                Console.WriteLine($"HashtableRemove: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void StackPush()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                for (int i = 0; i < 10000000; i++)
                {
                    stack.Push(i);
                }
                stopwatch.Stop();
                Console.WriteLine($"StackPush: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void StackIteration()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                foreach (var item in stack)
                {
                    var something = 1 + 1;
                }
                stopwatch.Stop();
                Console.WriteLine($"StackIteration: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void StackPop()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                for (int i = 0; i < 10000000; i++)
                {
                    stack.Pop();
                }
                stopwatch.Stop();
                Console.WriteLine($"StackPop: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void DictionaryAdd()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                for (int i = 0; i < 10000000; i++)
                {
                    dictionary.Add(i, $"Value{i}");
                }
                stopwatch.Stop();
                Console.WriteLine($"DictionaryAdd: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void DictionaryUpdate()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                dictionary[1] = "someTest";
                stopwatch.Stop();
                Console.WriteLine($"DictionaryUpdate: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void DictionaryIteration()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                foreach (var kvp in dictionary)
                {
                    var key = kvp.Key;
                    var value = kvp.Value;
                }
                stopwatch.Stop();
                Console.WriteLine($"DictionaryIteration: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }

            public void DictionaryRemove()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                dictionary.Remove(1001);
                stopwatch.Stop();
                Console.WriteLine($"DictionaryRemove: Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }

}
