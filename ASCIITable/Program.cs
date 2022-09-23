using Microsoft.VisualBasic;
using System.Text;

namespace ASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ASCII Table (American Standard Code for Information Interchange) 

            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"{i} = {(char)i}");
            }


            Console.ReadLine();
        }
    }
}