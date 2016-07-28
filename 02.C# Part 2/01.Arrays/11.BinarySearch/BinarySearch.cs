using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] array = new long[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = long.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());
        Array.Sort(array);


        int startIndex = 0;
        int endIndex = n - 1;
        int midIndex = (endIndex - startIndex) / 2;
        int count = 0;
        int result = 0;

        while(count <= n / 2)
        {
            if (array[midIndex] == x)
            {
                result = midIndex;
                break;
            }
            else if (array[midIndex] < x)
            {
                startIndex = midIndex + 1;
                midIndex = (startIndex + endIndex) / 2;
                count++;
            }
            else
            {
                endIndex = midIndex - 1;
                midIndex = (endIndex + startIndex) / 2;
                count++;
            }
        }

        Console.WriteLine(result);
        
    }
}
