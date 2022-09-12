using System;

namespace SumEvenAndOddFromOneToN
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a value to be sub of even and odd : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sub of even and odd result : "+SumOfEvenAndOddSub(number));

            Console.ReadLine();
        }


        private static int SumOfEvenAndOddSub(int n)
        {

            var odd = 0;
            var even = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i%2==0)
                {
                    even = even + i;
                }
                else
                {
                    odd = odd + i;
                }
            }

            Console.WriteLine("Sum of even numbers : "+even);
            Console.WriteLine("Sum of odd numbers : " + odd);

            return odd - even;

        }
    }
}
