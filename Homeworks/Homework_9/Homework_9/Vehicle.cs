using System;
using Homework_9;

namespace Homework_9
{
    public abstract class Vehicle
    {
        protected string Name;
        private readonly VehicleCategory category;
        public Vehicle(string name,VehicleCategory category) 
        {
            Name = name;
            this.category = category;
        }

        

        public abstract void CreatedVehicleDescription();
        public abstract void Description();
        
    }

    public class SportVehicle : Vehicle
    {
        public const  VehicleCategory CurrentCategory = VehicleCategory.Sport;
        private readonly bool _isF1;
        public SportVehicle(string name, bool isF1) : base(name, CurrentCategory)
        {
            _isF1 = isF1;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {CurrentCategory} and it {(_isF1 ? "is" : "is not")} in Formula 1!");
        }

        public override void Description() 
        {
            Console.WriteLine($"this is a Description of {CurrentCategory} Category!");
        }

        public static SportVehicle AskQuestions()
        {
            Console.WriteLine("What's name? ");
            var name  = Console.ReadLine();
            Console.WriteLine("is It for F1 Race? y/n ");
            var f1 = Console.ReadLine();
            if ( f1 == "y")
            {
                return new SportVehicle(name, true);
            }
            {
                return new SportVehicle(name,false);
            }
        }
    }


    public class MilitaryVehicle : Vehicle
    {
        public const  VehicleCategory CurrentCategory = VehicleCategory.Military;
        private readonly bool _isOffensive;
        public MilitaryVehicle(string name, bool isOffensive) : base(name, CurrentCategory)
        {
            _isOffensive = isOffensive;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {CurrentCategory} and it is for {(_isOffensive ? "Offense" : "Deffense")}!");
        }

        public override void Description()
        {
            Console.WriteLine($"this is a Description of {CurrentCategory} Category!");
        }


        public static MilitaryVehicle AskQuestions()
        {
            Console.WriteLine("What's name? ");
            var name = Console.ReadLine();
            Console.WriteLine("is It Offensive vehicle? y/n ");
            var f1 = Console.ReadLine();
            if (f1 == "y")
            {
                return new MilitaryVehicle(name, true);
            }
            {
                return new MilitaryVehicle(name, false);
            }
        }
    }

    public class CasualVehicle : Vehicle
    {
        public const VehicleCategory CurrentCategory = VehicleCategory.Casual;
        private readonly bool _isForFamily;
        public CasualVehicle(string name, bool isForFamily) : base(name, CurrentCategory)
        {
            _isForFamily = isForFamily;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {CurrentCategory} and it is for {(_isForFamily ? "Family people" : "Single people")}!");
        }

        public override void Description()
        {
            Console.WriteLine($"this is a Description of {CurrentCategory} Category!");
        }

        public static CasualVehicle AskQuestions()
        {
            Console.WriteLine("What's name? ");
            var name = Console.ReadLine();
            Console.WriteLine("is It for family usage? y/n ");
            var f1 = Console.ReadLine();
            if (f1 == "y")
            {
                return new CasualVehicle(name, true);
            }
            {
                return new CasualVehicle(name, false);
            }
        }
    }

    public class PublicVehicle : Vehicle
    {
        public const VehicleCategory CurrentCategory = VehicleCategory.Casual;
        private readonly bool _canTakeMoreThan20;
        public PublicVehicle(string name, bool canTakeMoreThan20) : base(name, CurrentCategory)
        {
            _canTakeMoreThan20 = canTakeMoreThan20;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {CurrentCategory} and it is for {(_canTakeMoreThan20 ? "More than" : "Less than")} 20 people!");
        }

        public override void Description()
        {
            Console.WriteLine($"this is a Description of {CurrentCategory} Category!");
        }

        public static PublicVehicle AskQuestions()
        {
            Console.WriteLine("What's name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Can it take more than 20 people? y/n ");
            var f1 = Console.ReadLine();
            if (f1 == "y")
            {
                return new PublicVehicle(name, true);
            }
            {
                return new PublicVehicle(name, false);
            }
        }


    }



}
