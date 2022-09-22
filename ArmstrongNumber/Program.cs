namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter a number checking for Armstong number or not : ");
            var number = Console.ReadLine();
            double total = 0;

            for (int i = 0; i < number.Length; i++)
            {
                var sum = Convert.ToInt32(number[i].ToString());
                total = total + Math.Pow(sum, number.Length);

            }

            if (number==total.ToString())
            {
                Console.WriteLine($"{number} is an Armstrong number ");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number");
            }


            Console.ReadLine();
        }
    }
}