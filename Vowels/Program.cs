namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A,E,I,O,U and also Y considered as vowel when there is no other vowel in the word.

            string text = "Ahmet look at the sky and try";
            text = text.ToLower();
            var split = text.Split(' ');
            int counter = 0;
            for (int i = 0; i < split.Length; i++)
            {
                for (int j = 0; j < split[i].Length; j++)
                {
                    if (split[i][j] =='a' || split[i][j] == 'e' || split[i][j] == 'i' || split[i][j] == 'o' || split[i][j] == 'u')
                    {
                        counter++;
                    }
                }

                if (split[i].Contains("y") && !split[i].Contains("aeiou"))
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} vowels in the text");

            Console.ReadLine();
        }
    }
}