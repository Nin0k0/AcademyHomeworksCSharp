using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            //LIST
            var characters = new List<string>();

            characters.Add("Rachel Green");
            characters.Add("Monica Geller");
            characters.Add("Phoebe Buffay");
            characters.Add("Joey Tribbiani");
            characters.Add("Chandler Bing");
            characters.Add("Ross Geller");

            Console.WriteLine("Character at index 2: " + characters[2]);

            characters.Remove("Joey Tribbiani");

            characters.Insert(1, "Janice Hosenstein");

            int indexOfChandler = characters.IndexOf("Chandler Bing");
            Console.WriteLine("Index of Chandler Bing: " + indexOfChandler);

            Console.WriteLine("All characters:");
            foreach (string character in characters)
            {
                Console.WriteLine(character);
            }

            characters.Clear();

            bool isEmpty = characters.Count == 0;
            Console.WriteLine("Is the character list empty? " + isEmpty);


            //ArrayList
            var charactersArrayList = new ArrayList
            {
                "SpongeBob SquarePants",
                "Patrick Star",
                "Squidward Tentacles"
            };


            Console.WriteLine("Character at index 1: " + charactersArrayList[1]);


            charactersArrayList.Remove("Patrick Star");


            charactersArrayList.Insert(1, "Mr. Krabs");

            
            var indexOfSquidward = charactersArrayList.IndexOf("Squidward Tentacles");
            Console.WriteLine("Index of Squidward Tentacles: " + indexOfSquidward);

            //DICTIONARY
            var exchangeRates = new Dictionary<string, double>();

            exchangeRates.Add("USD", 1.0);
            exchangeRates.Add("EUR", 0.85);
            exchangeRates.Add("GBP", 0.73);
            exchangeRates.Add("JPY", 110.27);
            exchangeRates.Add("CAD", 1.23);

            Console.WriteLine("Exchange rate of USD: " + exchangeRates["USD"]);

            exchangeRates.Remove("GBP");

            bool containsGBP = exchangeRates.ContainsKey("GBP");
            Console.WriteLine("Does the dictionary contain GBP? " + containsGBP);

        }
    }
}
