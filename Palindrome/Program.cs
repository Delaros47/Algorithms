using System;
using System.Linq;
using System.Xml;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a text for checking a Palindrome or not : ");
            string text = Console.ReadLine();

            string temp = null;

            for (int i = text.Length-1; i >=0; i--)
            {
                if (text[i]==' ') continue;
                temp += text[i];
            }

            text = text.Replace(" ", "");
            if (text.ToLower()==temp.ToLower())
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }

            
            Console.ReadLine();
        }
    }
}
