using System;

namespace SumFrom1toN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1+2+3+4+5+...+250=n sum

            Console.Write("Write a number to be summed from 1 until our number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total : " +SumOfNNumber(number));


            Console.ReadLine();
        }

        private static int SumOfNNumber(int n)
        {

            var total = 0;
            for (int i = 1; i <= n; i++)
            {

                total = total + i;

            }

            return total;
        }
    }
}
