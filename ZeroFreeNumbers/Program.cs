namespace ZeroFreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter=0;
            for (int i = 1; i <=1000000; i++)
            {
                if (!i.ToString().Contains('0'))
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }

            Console.WriteLine($"From 1 until 1 Million there are {counter} zero free numbers");


            Console.ReadLine();
        }
    }
}