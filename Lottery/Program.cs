using System;
using System.Linq;

namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] lottery = new int[6];

            for (int i = 0; i < 6; i++)
            {
                var value = random.Next(0, 50);
                if (lottery.Contains(value))
                {
                    i--;
                    continue;
                }

                lottery[i] = value;

            }

            Array.Sort(lottery);

            string result = null;
            foreach (var number in lottery)
            {
                result += number + ",";
            }

            result = result.TrimEnd(',');

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
