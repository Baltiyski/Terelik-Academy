using System;

class CompareCharArray
{
    static void Main(string[] args)
    {
        string firstChar = Console.ReadLine();
        string secondChar = Console.ReadLine();

        char[] firstArray = new char[firstChar.Length];
        char[] secondArray = new char[secondChar.Length];



        if (firstArray.Length == secondArray.Length)
        {
            int index = 0;
            foreach (var ch in firstChar)
            {
                firstArray[index] = ch;
                index++;
            }

            index = 0;
            foreach (var ch in secondChar)
            {
                secondArray[index] = ch;
                index++;
            }

            bool isEqual = false;
            char symbol = ' ';
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    isEqual = false;
                    symbol = '<';
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    isEqual = false;
                    symbol = '>';
                    break;
                }
                else
                {
                    isEqual = true;
                }
            }
            Console.WriteLine(isEqual ? '=' : symbol);
        }
        else if(firstArray.Length > secondArray.Length)
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine("<");
        }

    }
}
