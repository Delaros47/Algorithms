using System;

namespace ExponentCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the base number : ");
            var _base = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the exponent number : ");
            var _exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result : "+Exponent(_base,_exponent));


            Console.ReadLine();
        }

        private static int Exponent(int _base,int _exponent)
        {

            var result = 1;

            for (int i = 1; i <= _exponent; i++)
            {
                result = result * _base;
            }

            return result;
        }

    }
}
