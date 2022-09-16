using System;
using System.Reflection.Metadata.Ecma335;

namespace MinAnMaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number :");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number :");
            var second = Convert.ToInt32(Console.ReadLine());

            var max = Math.Max(first, second);
            Console.WriteLine($"{max} is Max value");

            //if (first>second)
            //{
            //    Console.WriteLine($"{first} is Max value");
            //}
            //else
            //{
            //    Console.WriteLine($"{second} is Max value");
            //}



            Console.ReadLine();
        }
    }
}
