namespace ArmstrongNumberFromOneUntilOneBillion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            for (int i = 1; i <=1000000000 ; i++)
            {
                double total = 0;
                string temp = i.ToString();
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    var value = Convert.ToInt32(temp[j].ToString());
                    total = total + Math.Pow(value, temp.Length);
                }

                if (temp==total.ToString())
                {
                    Console.WriteLine($"{temp} is an Armstrong number");
                    counter++;
                }
            }

            Console.WriteLine($"From one until one Billion we have {counter} Armstrong numbers ");


            Console.ReadLine();
        }
    }
}