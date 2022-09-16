using System;
using System.Linq;

namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Random random = new Random();
            int[] temp = new int[6];

            for (int i = 0; i <6; i++)
            {
                var value = random.Next(0, 50);
                if (temp.Contains(value))
                {
                    i--;
                    continue;
                }
                temp[i] = value;

            }

            Array.Sort(temp);

            foreach (var number in temp)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
