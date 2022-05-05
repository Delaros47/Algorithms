using System;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number for checking Even or Odd :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(number));

            Console.ReadLine();
        }

        static string EvenOrOdd(int number)
        {
            if (number%2==0)
            {
                return "It is an Even number";
            }
            else
            {
                return "It is an Odd number";
            }
        } 
    }
}
