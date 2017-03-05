using System;
using System.Linq;

class ReverseString
{
    public string Reverse(string word)
    {
        char[] revString = word.ToArray();
        Array.Reverse(revString);
        revString.ToString();

        return new string(revString);
    }
}

class PrintString
{
    static void Main()
    {
        string newString = Console.ReadLine();
        ReverseString newRev = new ReverseString();
        Console.WriteLine(newRev.Reverse(newString));
    }
}


