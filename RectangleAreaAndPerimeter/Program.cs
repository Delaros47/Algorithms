using System;

namespace RectangleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write a width of Rectangle : ");
            var width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write a length of Rectangle : ");
            var length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Rectangle area = {width*length}");
            Console.WriteLine($"Rectangle perimeter = {2*(length+width)}");


            Console.ReadLine();
        }
    }
}
