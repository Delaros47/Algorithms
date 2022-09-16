using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a number for checking it is a Perfect number or not :");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PerfectNumber(number));



            Console.ReadLine();
        }

        private static string PerfectNumber(int number)
        {
            string result = "";
            var total = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    total += i;
                }

            }

            if (total == number)
            {
                result = $"{number} is a Perfect Number";
            }
            else
            {
                result = $"{number} is a not a Perfect Number";
            }

            return result;
        }


    }
}
