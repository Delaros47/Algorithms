using System;

namespace AreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a radius circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Circle : "  +AreaOfCircle(radius));




            Console.ReadLine();
        }

        private static double AreaOfCircle(double r)
        {

            return (Math.PI * r*r);
        }

    }
}
