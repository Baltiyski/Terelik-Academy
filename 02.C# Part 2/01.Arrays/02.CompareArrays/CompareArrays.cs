using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] firstArr = new int[n];
        int[] secondArr = new int[n];

        Boolean isEqual = true;
        int num = 0;

        for (int i = 0; i < firstArr.Length; i++)
        {
            num = int.Parse(Console.ReadLine());
            firstArr[i] = num;
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            num = int.Parse(Console.ReadLine());
            secondArr[i] = num;
        }

        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                isEqual = false;
                break;
            }
        }

        if (!isEqual)
        {
            Console.WriteLine("Not equal");
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}
