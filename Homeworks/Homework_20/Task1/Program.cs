using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

const int arraySize = 10000000;

int[] numbers = new int[arraySize];
var random = new Random();
for (int i = 0; i < arraySize; i++)
{
    numbers[i] = random.Next(1, 100);
}

long normalSum;
var stopwatch = Stopwatch.StartNew();
normalSum = CalculateNormal(numbers);
stopwatch.Stop();
Console.WriteLine($"Normal sum {normalSum} took time =>  {stopwatch.Elapsed}");

long sumParallel;
stopwatch.Restart();
sumParallel = CalculateSumParallel(numbers);
stopwatch.Stop();
Console.WriteLine($"Parallel tasks sum {sumParallel} took time => {stopwatch.Elapsed}");

static long CalculateNormal(int[] numbers)
{
    var task = Task.Run(() => numbers.Sum());
    task.Wait();

    return task.Result;
}

static long CalculateSumParallel(int[] numbers)
{
    var numberOfTasks = Environment.ProcessorCount;
    var numbersCountForEachTask = numbers.Length / numberOfTasks;

    var eachTaskSums = new long[numberOfTasks];
    var tasksArray = new Task[numberOfTasks];

    for (var i = 0; i < numberOfTasks; i++)
    {
        var start = i * numbersCountForEachTask;
        var end = (i == numberOfTasks - 1) ? numbers.Length : (i + 1) * numbersCountForEachTask;
        var currentTaskIndex = i;
        tasksArray[currentTaskIndex] = Task.Run(() =>
        {
            long localSum = numbers.Skip(start).Take(end - start).Sum();
            eachTaskSums[currentTaskIndex] = localSum;
        });
    }

    Task.WaitAll(tasksArray);

    return eachTaskSums.Sum();
}