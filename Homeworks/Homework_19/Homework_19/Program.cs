

using System.Diagnostics;

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
Console.WriteLine($"Parallel threads sum {sumParallel} took time => {stopwatch.Elapsed}");




static long CalculateNormal(int[] numbers)
{
    long sum = 0;
    for (var i = 0; i < numbers.Length; i++) sum += numbers[i];
    sum = numbers.Sum();
    return sum;
}

// ერთი threadით უფრო სწრაფი იყო, ამიტომ ვცადე დამატებით ცალკე ერთი threadis შექმნა რომელშიც შეასრულებდა ამ ოპერაციას და მაინც უფრო სწრაფი აღმოჩნდა
// ჩემი მოკრძალებული აზრით, threadების შექმნას და დამენეჯებას უფრო მეტი დრო მიაქვს ამ შემთხვევაში, ვიდრე მიზოგავს,
//ამიტომ მსგავსს ქეისში უბრალოდ მარტივი ფუნქციის დაწერა უფრო მოქნილი და ოპტიმალურია
//ყოველშემთხვევაში ჩემს გარემოზე ასე გაეშვა დაახლოებით 3ჯერ-5ჯერ უფრო სწრაფ შედეგს ვიღებ ერთი thread-ით
//სხვადასხვა გაშვებაზე სხვადასხვაა შედეგი, თუმცა ყოველთვის  1 threadიანი ოპერაცია უფრო სწრაფია
//static long CalculateNormal(int[] numbers)
//{
//    long sum = 0;

//    var thread = new Thread(() =>
//    {
//        sum = numbers.Sum();
//    });

//    thread.Start();
//    thread.Join();

//    return sum;
//}
static long CalculateSumParallel(int[] numbers)
{
    var numberOfThreads = Environment.ProcessorCount;
    var numbersCountForEachThread = numbers.Length / numberOfThreads;

    var eachThreadSums = new long[numberOfThreads];
    var threadsArray = new Thread[numberOfThreads];

    for (var i = 0; i < numberOfThreads; i++)
    {
        var start = i * numbersCountForEachThread;
        var end = (i == numberOfThreads - 1) ? numbers.Length : (i + 1) * numbersCountForEachThread;
        var currentThreadIndex = i;
        threadsArray[currentThreadIndex] = new Thread(() =>
        {

            long localSum = numbers.Skip(start).Take(end - start).Sum();
            eachThreadSums[currentThreadIndex] = localSum;
        });
        threadsArray[i].Start();

    }

    for (var i = 0; i < numberOfThreads; i++)
    {
        threadsArray[i].Join();
    }

    return eachThreadSums.Sum();
}

