using System;
/*
 * Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
 * Constraints:
 *   1 <= N <= 1024
 *   Time limit: 0.1s
 *   Memory limit: 16MB
 */
class MaximalSequence
{
    static void Main(string[] args)
    {
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];

        int count = 0;
        int result = 0;
        int equals = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int num = int.Parse(Console.ReadLine());
            array[i] = num;
            if (i == 0)
            {
                equals = array[i];
                continue;
            }
            if (equals == array[i])
            {
                count++;
                if (result < count)
                {
                    result = count;
                }
            }
            else if (equals != array[i])
            {
                count = 0;
                equals = array[i];
            }
        }
        Console.WriteLine(result + 1);
    }
}
