using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var strings = new Storage<string>();
            strings.AddItem("Georgia");
            strings.AddItem("Won");
            strings.AddItem("Against");
            strings.AddItem("Netherlands");
            strings.PrintItems();
            //strings.RemoveItem("Won");
            //strings.PrintItems();
            strings.UpdateItem("Won", "Won Gloriously");
            strings.PrintItems();

            Console.WriteLine();

            var ints = new Storage<int>();
            ints.AddItem(1200);
            ints.AddItem(4587);
            ints.AddItem(300);
            ints.PrintItems();

            Console.WriteLine();

            ints.RemoveItem(300);
            ints.PrintItems();

            Console.WriteLine();

            ints.UpdateItem(1200, 1000);
            ints.PrintItems();


            var doubles = new Storage<double>();
            doubles.AddItem(1200.45);
            doubles.AddItem(4587.98);
            doubles.AddItem(300.45);

            Console.WriteLine(); 

            doubles.PrintItems();
            doubles.RemoveItem(300.45);

            Console.WriteLine(); 

            doubles.PrintItems();
            doubles.UpdateItem(1200.45, 1000);
            doubles.PrintItems();

        }
    }
}
