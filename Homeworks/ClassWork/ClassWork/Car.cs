using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Car
    {

        private string _type;
        private string _brand;

        public string Type { get { return _type; } 
            set { 
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Not valid Type");
                    return;
                }
                _type = value; 
            } }
        public string Brand { get { return _brand; } 
            set { 
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Not valid Brand");
                    return;
                }
                
                _brand = value; } }

        public static void Pipini()
        {
            Console.WriteLine("Piiiiiiii piiiiiiiii");
        }
    }
}
