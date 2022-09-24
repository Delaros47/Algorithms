namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <=1000000; i++)
            {
                int temp = i;
                string result = null;
                while (temp > 1)
                {
                    var value = temp % 2;
                    result = value + result;
                    temp = temp / 2;
                }
                result = temp + result;
                Console.WriteLine($"{i} = {result}");
            }
    


            

            Console.ReadLine();
        }
    }
}