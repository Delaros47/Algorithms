using System;
using System.Runtime.InteropServices;

namespace PercentageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("What is % of? :");
            var number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is What percent of? :");
            var percent = Convert.ToDouble(Console.ReadLine());

            var result = (number / 100) * percent;
            Console.WriteLine($"{number} of % {percent} = {result}");


            Console.ReadLine();
        }
    }
}
