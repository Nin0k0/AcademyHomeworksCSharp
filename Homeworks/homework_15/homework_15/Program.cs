using homework_15;
using System.Reflection;

int answerInt;

while (true)
{
    Console.WriteLine($"Which Type do you choose? 1: {typeof(Lecturers)} or 2: {typeof(Mentors)}");
    var isValidAnswer = int.TryParse(Console.ReadLine(), out answerInt);
    if (isValidAnswer && (answerInt == 1 || answerInt == 2))
        break;
    else
        Console.WriteLine("Try Again!");
}

Type? type = null;
switch (answerInt)
{
    case 1:
        type = typeof(Lecturers);

        break;
    case 2:
        type = typeof(Mentors);
        break;
}

var methods = type!.GetMethods();

MethodInfo methodInfo;

Console.WriteLine("Which method do you want to Run?");
for (var i = 0; i < methods.Length; i++) Console.WriteLine($"{i}: {methods[i]}");

int integerValue;
while (true)
{
    var isValidMethod = int.TryParse(Console.ReadLine(), out integerValue);
    if (isValidMethod && integerValue < methods.Length)
        break;
    else
        Console.WriteLine("Try Again!");
}

methodInfo = methods[integerValue];

var pars = methodInfo.GetParameters();
Console.WriteLine(pars.Length);

object[] argsuments = new object[pars.Length];
for (var i = 0; i < pars.Length;)
{
    Console.WriteLine($"Enter parameter named {pars[i].Name} with Type {pars[i].ParameterType}");

    var userInput = Console.ReadLine();

    try
    {
        var paramValue = Convert.ChangeType(userInput, pars[i].ParameterType);
        if (paramValue == null)
        {

        }
        else
        {
            i++;
            argsuments[i] = paramValue;

        }

    }
    catch (Exception)
    {
        Console.WriteLine("invalid Parameter Value! Try again!");
    }
}

methodInfo.Invoke(type, argsuments);