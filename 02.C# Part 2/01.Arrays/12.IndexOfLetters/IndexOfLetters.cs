using System;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                               'u', 'v', 'w', 'x', 'y', 'z' };

        string word = Console.ReadLine();

        foreach (var leter in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (leter == alphabet[i])
                {
                    Console.WriteLine(Array.IndexOf(alphabet, alphabet[i]));
                }
            }
        }
                            
    }
}
