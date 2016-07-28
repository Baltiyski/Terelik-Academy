using System;
class MaximumSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        int sum = 0;
        int copySum = 0;
        int result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            sum = arr[i];
            for (int j = 0; j < arr.Length; j++)
            {
                if (j > i)
                {
                    sum += arr[j];
                    if (j == 0)
                    {
                        copySum = sum;
                    }
                    else if (copySum < sum)
                    {
                        copySum = sum;
                    }
                }
            }
            if (i == 0)
            {
                result = copySum;
            }
            else if (result < copySum)
            {
                result = copySum;
            }
        }

        Console.WriteLine(result);
    }
}
