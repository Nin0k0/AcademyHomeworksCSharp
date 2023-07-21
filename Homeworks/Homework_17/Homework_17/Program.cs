using System.Collections.Concurrent;
using Homework_17;

var myList = new MyList<string> { "Nino" };


var range = new List<string>
{
    "dev",
    "developer",
    "khelosan"
};
var removerange = new List<string>
{

    "developer",
    "khelosan"
};

myList.AddRange(range);

Console.WriteLine(myList[0]);
Console.WriteLine(myList.Count);

Console.WriteLine(myList.Remove("Nino"));

Console.WriteLine(myList.Count);

Console.WriteLine(myList.Single(x => x.Length > 4));
Console.WriteLine(myList.SingleOrDefault(x => x.Length < 2));

myList.RemoveAt(2);

myList.RemoveRange(removerange);

Console.WriteLine(myList.Contains("Nino"));
Console.WriteLine(myList.Contains("Something"));
var result = myList.Find(x => x.Length >= 4);
Console.WriteLine(result);

var list = myList.Where(x => x.Length > 4);
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine(myList.Count);


