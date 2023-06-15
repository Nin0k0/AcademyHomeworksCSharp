using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var cL = new CustomList<int?>();
            cL.AddElement(1);
            cL.AddElement(2);
            //Console.WriteLine(cL.Count);
            //cL.RemoveElement(2);
            //cL.AddElement("78");
            //cL.AddElement("k");
            //cL.AddElement(true);
            cL.AddElement(789);
            cL.AddElement(479);
            cL.AddElement(478);
            cL.AddElement(456002);
            cL.RemoveElement(1000);
            //var element = cL.GetElement(5, out bool IsFound );
            //Console.WriteLine(element);
            //Console.WriteLine(IsFound);

            //var higherThan99 =  cL.Find(x=> x.ToString().Length >=3);

            cL.AddList(new List<int?>() {  1, 2, 3, 4, 5  });

            Console.WriteLine(cL.Count);
            //var resultList = cL.GetList(0,5,out bool  IsValid);
            //if (IsValid)
            //{
            //    foreach (var item in resultList)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            cL.InsertElement(50, 4);
            
            Console.WriteLine(cL.GetElement(4, out _));


            cL.InsertList(new List<int?>() { 1,2,3,4, 5 },0);

            var insertedList = cL.GetList(0,5,out _);

            foreach (var item in insertedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
