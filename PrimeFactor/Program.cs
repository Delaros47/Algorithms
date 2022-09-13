using System;

namespace PrimeFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Enter a number in order to calculate Prime Factor of it : ");
            var number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <=number ; i++)
            {

                if (number%i==0)
                {
                    number = number /i;
                    Console.WriteLine(i);
                    --i;
                    continue;
                }

            }



            Console.ReadLine();
        }
    }
}
