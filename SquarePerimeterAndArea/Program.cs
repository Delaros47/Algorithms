using System;

namespace SquarePerimeterAndArea
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the side of Square : ");
            var side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of Square : {side*side}");
            Console.WriteLine($"Perimeter of Square : {4*side}");



            Console.ReadLine();
        }
    }
}
