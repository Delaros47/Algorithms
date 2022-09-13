using System;

namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter number for calculation of Prime Factor from 2 until your Number : ");
            var number = Convert.ToInt32(Console.ReadLine());

            int biggestNumber = 0;
            int biggestCounter = 0;
            string biggestList = null;

            for (int i = 2; i <= number; i++)
            {
                int temp = i;
                string list = null;
                int counter=0;
                for (int j = 2; j <= temp; j++)
                {

                    if (temp % j == 0)
                    {
                        temp = temp / j;
                        list += j + ",";
                        counter++;
                        --j;
                        continue;
                    }

                }

                Console.WriteLine($"{i} Prime Factor = {list}");
                if (biggestCounter<counter)
                {
                    biggestCounter = counter;
                    biggestList = list;
                    biggestNumber = i;
                }

            }

            Console.WriteLine($"Biggest Prime Factor = {biggestNumber} = {biggestList}");


            Console.ReadLine();
        }
    }
}
