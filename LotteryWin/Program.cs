using System;
using System.Linq;

namespace LotteryWin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] guess = new int[6];

            for (int i = 0; i < guess.Length; i++)
            {
                Console.Write($"{i+1}. Lottery Number = ");
                guess[i] = Convert.ToInt32(Console.ReadLine());
            }

            Random random = new Random();
            int[] lottery = new int[6];
            int[] win = new int[1];

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

            Array.Sort(guess);
            Array.Sort(lottery);

            int counter = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                for (int j = 0; j < lottery.Length; j++)
                {
                    if (guess[i] == lottery[j])
                    {
                        win[counter] = lottery[j]; 
                        counter++;
                        Array.Resize(ref win,counter);
                    }
                }
            }

            if (counter==1)
            {
                Console.WriteLine("You have won 1000$");
            }else if (counter==2)
            {
                Console.WriteLine("You have won 8000$");
            }
            else if (counter == 3)
            {
                Console.WriteLine("You have won 16000$");
            }
            else if (counter == 4)
            {
                Console.WriteLine("You have won 100000$");
            }
            else if (counter == 5)
            {
                Console.WriteLine("You have won 800000$");
            }
            else if (counter == 6)
            {
                Console.WriteLine("You have won 1000000$");
            }
            else
            {
                Console.WriteLine("You win nothing please try again");
            }








            Console.ReadLine();
        }
    }
}
