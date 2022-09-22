namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First Number :");
            var first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number :");
            var second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Multiply");
            Console.WriteLine("2.Add");
            Console.WriteLine("3.Divide");
            Console.WriteLine("4.Substract");
            Console.WriteLine("Choose any number from 1-4 :");
            var result = Console.ReadLine();
            

            switch (result)
            {
                case "1":
                    Console.WriteLine($"Result : {first*second}");
                    break;
                case "2":
                    Console.WriteLine($"Result : {first+second}");
                    break;
                case "3":
                    Console.WriteLine($"Result : {first/second}");
                    break;
                case "4":
                    Console.WriteLine($"Result : {Math.Abs(first-second)}");
                    break;
                default:
                    Console.WriteLine("Please Choose from 1-4");
                    break;
            }


            Console.ReadLine();
        }
    }
}