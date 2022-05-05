using System;
using Microsoft.VisualBasic.CompilerServices;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number for checking Prime Number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrimeNumber(number));




            Console.ReadLine();
        }

        static string IsPrimeNumber(int number)
        {
            string result = "";
            if (number>=2)
            {

                bool primeNumber = true;
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        primeNumber = false;
                    }
                }

                if (primeNumber)
                {
                    result = $"{number} is a Prime Number";
                }
                else
                {
                    result = $"{number} is not a Prime Number";
                }

            }
            else
            {
                result= "The smallest Prime Number is 2 please try to enter number greater than 2";
            }

            return result;

        }

    }
}
