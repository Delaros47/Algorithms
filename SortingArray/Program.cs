namespace SortingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 25, 11, 45, 9, 88, 65, 52, 33, 61, 3 };

            int temp = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = numbers.Length-1; i >=0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            Console.ReadLine();
        }
    }
}