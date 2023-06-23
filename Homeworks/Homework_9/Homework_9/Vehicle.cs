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
        public  VehicleCategory currentCategory = VehicleCategory.Sport;
        private readonly bool _isF1;
        public SportVehicle(string name, bool isF1) : base(name, VehicleCategory.Sport)
        {
            _isF1 = isF1;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {currentCategory} and it {(_isF1 ? "is" : "is not")} in Formula 1!");
        }

        public override void Description() 
        {
            Console.WriteLine($"this is a Description of {currentCategory} Category!");
        }
    }


    public class MilitaryVehicle : Vehicle
    {
        public VehicleCategory currentCategory = VehicleCategory.Military;
        private readonly bool _isOffensive;
        public MilitaryVehicle(string name, bool isOffensive) : base(name, VehicleCategory.Military)
        {
            _isOffensive = isOffensive;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {currentCategory} and it is for {(_isOffensive ? "Offense" : "Deffense")}!");
        }

        public override void Description()
        {
            Console.WriteLine($"this is a Description of {currentCategory} Category!");
        }
    }

    public class CasualVehicle : Vehicle
    {
        public VehicleCategory currentCategory = VehicleCategory.Casual;
        private readonly bool _isForFamily;
        public CasualVehicle(string name, bool isForFamily) : base(name, VehicleCategory.Casual)
        {
            _isForFamily = isForFamily;
        }

        public override void CreatedVehicleDescription()
        {
            Console.WriteLine($"this vehicle is the {currentCategory} and it is for {(_isForFamily ? "Family people" : "Single people")}!");
        }

        public override void Description()
        {
            Console.WriteLine($"this is a Description of {currentCategory} Category!");
        }
    }



}
