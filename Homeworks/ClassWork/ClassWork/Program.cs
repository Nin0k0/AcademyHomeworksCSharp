using System;

namespace ClassWork
{
    internal class Program
    {
        static void Main()
        {
            var car = new Car()
            {
                Type = "Sedan",
                Brand = "Porsche"
            };
            Car.Pipini();
        }
    }
}
