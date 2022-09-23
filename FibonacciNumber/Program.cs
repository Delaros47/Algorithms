namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number of Fibonacci : ");
            var number = Convert.ToInt32(Console.ReadLine());
            long f1 = 0, f2 = 1, f3 = 0;
            long[] array = new long[number];
            array[0] = f1;
            array[1] = f2;

            for (long i = 2; i < number; i++)
            {

                f3 = f1 + f2;
                array[i] = f3;
                f1 = f2;
                f2 = f3;

            }

            for (long i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.ReadLine();
        }
    }
}