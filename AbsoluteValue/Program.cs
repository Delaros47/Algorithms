using System;

namespace AbsoluteValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Get Absolute Value of the number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Absolute Value  : " + AbsoluteValue(number));


            Console.ReadLine();
        }

        static int AbsoluteValue(int number)
        {
            if (number>0)
            {
                return number;
            }else if (number<0)
            {
                return -1 * number;
            }
            else
            {
                return 0;
            }
        }
    }
}
