using System;

class AllocateArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        arr[0] = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] + 5;
        }

        for (int i = 0; i <arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
