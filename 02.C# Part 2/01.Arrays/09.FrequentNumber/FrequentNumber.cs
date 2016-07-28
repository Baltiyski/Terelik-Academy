using System;

class FrequentNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int theNum = 0;
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (j > i)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            if (result < count)
            {
                result = count;
                theNum = arr[i];
            }
            
        }

        Console.WriteLine("{0} ({1} times)",theNum,(result+1));
    }
}
