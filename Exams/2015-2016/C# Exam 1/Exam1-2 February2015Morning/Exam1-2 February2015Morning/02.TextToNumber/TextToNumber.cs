using System;

class TextToNumber
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine()); ;
        string str = Console.ReadLine();

        char monkey = '\u0040';
        int result = 0;

        foreach (var letter in str)
        {         
            if (Char.IsLetter(letter))
            {
                if (letter.Equals('A') || letter.Equals('a'))
                {
                    result = result + 0;
                }
                else if (letter.Equals('B') || letter.Equals('b'))
                {
                    result = result + 1;
                }
                else if (letter.Equals('C') || letter.Equals('c'))
                {
                    result = result + 2;
                }
                else if (letter.Equals('D') || letter.Equals('d'))
                {
                    result = result + 3;
                }
                else if (letter.Equals('E') || letter.Equals('e'))
                {
                    result = result + 4;
                }
                else if (letter.Equals('F') || letter.Equals('f'))
                {
                    result = result + 5;
                }
                else if (letter.Equals('G') || letter.Equals('g'))
                {
                    result = result + 6;
                }
                else if (letter.Equals('H') || letter.Equals('h'))
                {
                    result = result + 7;
                }
                else if (letter.Equals('I') || letter.Equals('i'))
                {
                    result = result + 8;
                }
                else if (letter.Equals('J') || letter.Equals('j'))
                {
                    result = result + 9;
                }
                else if (letter.Equals('K') || letter.Equals('k'))
                {
                    result = result + 10;
                }
                else if (letter.Equals('L') || letter.Equals('l'))
                {
                    result = result + 11;
                }
                else if (letter.Equals('M') || letter.Equals('m'))
                {
                    result = result + 12;
                }
                else if (letter.Equals('N') || letter.Equals('n'))
                {
                    result = result + 13;
                }
                else if (letter.Equals('O') || letter.Equals('o'))
                {
                    result = result + 14;
                }
                else if (letter.Equals('P') || letter.Equals('p'))
                {
                    result = result + 15;
                }
                else if (letter.Equals('Q') || letter.Equals('q'))
                {
                    result = result + 16;
                }
                else if (letter.Equals('R') || letter.Equals('r'))
                {
                    result = result + 17;
                }
                else if (letter.Equals('S') || letter.Equals('s'))
                {
                    result = result + 18;
                }
                else if (letter.Equals('T') || letter.Equals('t'))
                {
                    result = result + 19;
                }
                else if (letter.Equals('U') || letter.Equals('u'))
                {
                    result = result + 20;
                }
                else if (letter.Equals('V') || letter.Equals('v'))
                {
                    result = result + 21;
                }
                else if (letter.Equals('W') || letter.Equals('w'))
                {
                    result = result + 22;
                }
                else if (letter.Equals('X') || letter.Equals('x'))
                {
                    result = result + 23;
                }
                else if (letter.Equals('Y') || letter.Equals('y'))
                {
                    result = result + 24;
                }
                else if (letter.Equals('Z') || letter.Equals('z'))
                {
                    result = result + 25;
                }
            }
            else if (Char.IsDigit(letter))
            {
                int toNum = (int)Char.GetNumericValue(letter);
                result *= toNum;
            }
            else if (letter.Equals(monkey))
            {
                break;
            }
            else
            {
                result = result % num;
            }
        }
        Console.WriteLine(result);

    }
}
