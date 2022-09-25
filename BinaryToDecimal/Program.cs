using System.Runtime.InteropServices;

namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string binary = "10000101";
            double total = 0;

            for (int i = binary.Length-1,x=0; i >=0; i--)
            {
                total = total + (Convert.ToInt32(binary[i].ToString()) * Math.Pow(2, x));
                x++;
            }

            Console.WriteLine($"{binary} = {total}");

            Console.ReadLine();
        }
    }
}