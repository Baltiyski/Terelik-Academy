using System;

class GetLargestNumbers
{
    public static int GetMax(int firstNum, int secondNum)
    {
        int largestFromTwoNum = 0;
        if (firstNum >= secondNum)
        {
            largestFromTwoNum = firstNum;
        }
        else
        {
            largestFromTwoNum = secondNum;
        }

        return largestFromTwoNum;
    }
    static void Main(string[] args)
    {
        string[] tokens = Console.ReadLine().Split();

        int firstNum = int.Parse(tokens[0]);
        int secondNum = int.Parse(tokens[1]);
        int tirdNum = int.Parse(tokens[2]);



        int largestFromTwoNum = GetMax(firstNum, secondNum);
        if (largestFromTwoNum >= tirdNum)
        {
            Console.WriteLine(largestFromTwoNum);
        }
        else
        {
            Console.WriteLine(tirdNum);
        }

    }
}
