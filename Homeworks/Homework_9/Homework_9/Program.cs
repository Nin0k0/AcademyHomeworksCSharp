using System;

namespace Homework_9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose Category:");
            Console.WriteLine("1. Military");
            Console.WriteLine("2. Casual");
            Console.WriteLine("3. Public");
            Console.WriteLine("4. Sport");

            var choosen =int.TryParse(Console.ReadLine(), out var intValue);

            if (choosen)
            {
                switch (intValue)
                {
                    case 1:
                       var newMilitaryVehicle =  MilitaryVehicle.AskQuestions();
                        newMilitaryVehicle.CreatedVehicleDescription();
                        newMilitaryVehicle.Description();
                        break;
                    case 2:
                        var newCasualVehicle  = CasualVehicle.AskQuestions();
                        newCasualVehicle.CreatedVehicleDescription();
                        newCasualVehicle.Description();
                        break;
                    case 3:
                        var newPublicVehicle = PublicVehicle.AskQuestions();
                        newPublicVehicle.CreatedVehicleDescription();
                        newPublicVehicle.Description();
                        break;
                    case 4:
                        var newSportsVehicle = SportVehicle.AskQuestions();
                        newSportsVehicle.CreatedVehicleDescription();
                        newSportsVehicle.Description();
                        break;
                    default:
                        Console.WriteLine("Other Category not supported!");
                        break;

                }
            }
        }
    }
}
