using System;

namespace AgeCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the date of birth : ");
            var dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            var age = DateTime.Now.Year-dateOfBirth.Year;
            Console.WriteLine($"You are {age} years old.");

            Console.ReadLine();
        }
    }
}
