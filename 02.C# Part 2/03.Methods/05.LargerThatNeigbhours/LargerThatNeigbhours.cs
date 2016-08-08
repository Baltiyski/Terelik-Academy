using System;
using System.Linq;

class LargerThatNeigbhours
{
    static int LargerNumber(int[] array)
    {
        int firstNumOfArray = array[0];
        int count = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (firstNumOfArray < array[i] && array[i] > array[i + 1])
            {

                count++;
                firstNumOfArray = array[i + 1];
                i = i + 1 ;
                
            }
            else
            {
                firstNumOfArray = array[i];
            }
            if (i == array.Length -2)
            {
                return count;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(LargerNumber(numbers));
    }
}
