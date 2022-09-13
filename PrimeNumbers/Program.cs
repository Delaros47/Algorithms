using System;
using System.Xml;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number for calculation Prime numbers : ");
            var number = Convert.ToInt32(Console.ReadLine());
            PrimeNumbers(number);

            Console.ReadLine();
        }

        private static void PrimeNumbers(int number)
        {
            int totalPrimeNumber=0;
            for (int i = 2; i <=number; i++)
            {
                int counter = 0;
                for (int j = 2; j <=i; j++)
                {
                    if (i%j==0)
                    {
                        counter++;
                    }
                    if(counter>1) 
                        break;

                }

                if (counter > 1)
                {

                }
                else
                {
                    Console.WriteLine($"{i} is a Prime Number ");
                    totalPrimeNumber++;
                }
                counter=0;

            }

            Console.WriteLine("Total Prime numbers = "+totalPrimeNumber);

        }
    }
}
