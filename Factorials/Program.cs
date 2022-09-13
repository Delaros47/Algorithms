using System;

namespace Factorials
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a factorial number to be calculated from 2 until our Number : ");
            var number = Convert.ToDecimal(Console.ReadLine());
            FactorialCalculation(number);


            Console.ReadLine();
        }

        private static void FactorialCalculation(decimal number)
        {


            for (int i = 2; i <=number; i++)
            {
                decimal result = 1;
                for (int j = 2; j <=i; j++)
                {
                    result *= j;

                }

                Console.WriteLine($"{i}! = {result}");


            }

        }


    }
}
