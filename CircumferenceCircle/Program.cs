using System;

namespace CircumferenceCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circumference of a Circle -  pi*2*r

            Console.Write("Enter radius value : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Circumference of a Circle :" + CircumferenceCircle(radius));



            Console.ReadLine();
        }

        private static double CircumferenceCircle(double r)
        {
            const double pi = 3.14;
            return 2 * pi * r;

        }
    }
}
