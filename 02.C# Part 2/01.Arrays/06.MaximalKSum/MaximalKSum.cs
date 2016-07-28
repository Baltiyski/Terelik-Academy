using System;

class MaximalKSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int countSum = 0;
        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < k; i++)
        {
            countSum += arr[i];
        }

        Console.WriteLine(countSum);

    }
}
