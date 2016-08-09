using System;
using System.Linq;

class ReverseNumber
{
    static decimal ReversNumberr(decimal number)
    {

        string reversedStr = new string(number.ToString().Reverse().ToArray());
        decimal reversedDouble;
        if (decimal.TryParse(reversedStr, out reversedDouble))
        {
            return reversedDouble;
        }

        return 0;
    }
    static void Main(string[] args)
    {
        decimal input = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReversNumberr(input));
    }
}
