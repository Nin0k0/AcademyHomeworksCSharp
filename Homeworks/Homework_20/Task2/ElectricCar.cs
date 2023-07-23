namespace Task2;

public class ElectricCar
{
    public int BatteryLevel { get; private set; } = 0;
    public string Model { get; set; }
    public int Year { get; set; }

    public async Task Charge()
    {
        while (BatteryLevel < 100)
        {
            BatteryLevel += 5;
            Console.WriteLine($"Charging {Model} - Battery Level: {BatteryLevel}%");
            if (BatteryLevel!=100)
            {
                await Task.Delay(10000);
            }
            
        }
    }
}