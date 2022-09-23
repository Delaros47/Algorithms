namespace AbundantNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abundant Number or Excessive number : The sum of the factors except the number itself is greater than the number

            int counter = 0;
            for (int i = 12; i <=1000000 ; i++)
            {
                int total = 0;
                for (int j = 1; j <=i/2; j++)
                {
                    if (i%j==0)
                    {
                        total = total + j;
                    }
                }

                if (total>i)
                {
                    Console.WriteLine($"{i} is an Abundant Number");
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} Abundant Number from 12 until one Million");

            //int total = 0;
            //for (int i = 1; i <=number/2; i++)
            //{
            //    if (number%i==0)
            //    {
            //        total = total + i;
            //    }
            //}

            //if (total>number)
            //{
            //    Console.WriteLine($"{number} is an Abundant Number");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not an Abundant Number");
            //}


            Console.ReadLine();
        }
    }
}