
 using System.Diagnostics;
 using Task2;


 var cars = new List<ElectricCar>
 {
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Ferrari", Year = 2023 },
     new ElectricCar { Model = "Mercedes", Year = 2022 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },
     new ElectricCar { Model = "Opel", Year = 2023 },
     new ElectricCar { Model = "Toyota Prius", Year = 2021 },

 };

 await ChargeElectricCars(cars);

 Console.ReadKey();




static async Task ChargeElectricCars(IEnumerable<ElectricCar> cars)
{
    var stopwatch = new Stopwatch();
    stopwatch.Start();

    var tasks = cars.Select(async car => await car.Charge());
    await Task.WhenAll(tasks);
    stopwatch.Stop();

    Console.WriteLine($"All electric cars charged in {stopwatch.Elapsed.TotalSeconds} seconds.");
}