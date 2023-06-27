using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            // შევამოწმოთ შესაძლებელი თუა სამკუთხედის შეკვრა
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                Side1 = sideA;
                Side2 = sideB;
                Side3 = sideC;
            }
            else
            {
                throw new ArgumentException("Not valid numbers!");
            }
        }

        

        public double Area()
        {
            //Heron Formuka
            double halfPerimeter = Perimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
        }

        public double Perimeter()
        {
           
            return Side1 + Side2 + Side3;
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            
            return t1.Area() == t2.Area();
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            
            return !(t1 == t2);
        }
        public static bool operator >(Triangle t1, Triangle t2)
        {
            return t1.Area() > t2.Area();
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            return t1.Area() < t2.Area();
        }
        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            var sumArea = t1.Area() + t2.Area();

            //sumArea = newTriangle Katetit chavtvalot tolferdaa gamravlebuli tavis tavze gayofili orze amitom 
            //inglisurad damezara amis dawera sorry

            var newTriangleKateti = Math.Sqrt(sumArea * 2);

            var newTriangleHipotenuza = newTriangleKateti * Math.Sqrt(2);

            return new Triangle(newTriangleKateti, newTriangleKateti, newTriangleHipotenuza);


            
        }

        public static explicit operator Triangle(double sideLength)
        {
            return new Triangle(sideLength, sideLength, sideLength);
        }
    }

}
