using System;
using System.Collections;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
                Console.WriteLine($"*******{i}*******");
                for (int j = 1; j <= 10; j++)
                {

                    Console.WriteLine($"{i}x{j} = {i * j}");

                }

            }

            Console.ReadLine();
        }
    }
}
