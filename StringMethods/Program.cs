using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "C# Hello World";
            var lowerCase = text.ToLower();
            var upperCase = text.ToUpper();
            var emptyTrim = text.Trim(',');
            var trimStart = text.TrimStart(',');
            var trimEnd = text.TrimEnd(',');
            var charArray = text.ToCharArray();

            //foreach (var singleChar in charArray)
            //{
            //    if (singleChar == ' ') continue;
            //    Console.Write(singleChar + "=");
            //}

            var subString = text.Substring(3);
            var subString2 = text.Substring(3, 5);
            var startsWith = text.StartsWith("C#");
            var split = text.Split(' ');

            foreach (var array in split)
            {
                Console.WriteLine(array);
            }

            var replace = text.Replace("C#", "C++");
            var remove = text.Remove(2);
            var remove2 = text.Remove(0, 3);
            var indexOf = text.IndexOf('o');
            var lastIndexOf = text.LastIndexOf('o');
            var insert = text.Insert(0, "C++ ");
            var contains1 = text.Contains("C++");
            var padLeft = text.PadLeft(20,'-');
            var padRight = text.PadRight(20, '*');
            Console.WriteLine(padLeft);
            Console.WriteLine(padRight);
            Console.WriteLine($"Length of our text {text.Length} ");

            Console.ReadLine();
        }
    }
}
