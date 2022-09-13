using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a factorial number : ");
            var factorial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Result = "+FactorialCalculation(factorial));


            Console.ReadLine();
        }


        private static decimal FactorialCalculation(decimal factorial)
        {
            decimal result = 1;

            for (decimal i = 2; i <=factorial; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
