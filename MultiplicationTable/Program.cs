using System;
using System.Collections;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string biggestList=null;
            int biggestNumber = 0;
            int biggest = 0;
            for (int j = 2; j <=1000 ; j++)
            {
                int temp = j;
                string list = null;
                int counter = 0;
                
                
                for (int i = 2; i <=temp; i++)
                {
                    if (temp%i==0)
                    {
                        temp = temp / i;
                        list +=i+",";
                        --i;
                        counter++;
                        continue;
                    }
                   
                }
                Console.WriteLine($"Prime Factor {j} = {list}");
                if (biggest<counter)
                {
                    biggest = counter;
                    biggestList = list;
                    biggestNumber=j;
                }
            }

            Console.WriteLine($"Biggest Number : {biggestNumber} = {biggestList} ");


            //for (int i = 1; i <=10 ; i++)
            //{
            //    Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
            //    Console.WriteLine($"*******{i}*******");
            //    for (int j = 1; j <=10; j++)
            //    {

            //        Console.WriteLine($"{i}x{j} = {i*j}");

            //    }

            //}

            Console.ReadLine();
        }
    }
}
