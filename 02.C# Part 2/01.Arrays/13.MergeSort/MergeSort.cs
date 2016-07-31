using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Merge12Sortt
{
    public static void DoMergeSort(this int[] numbers)
    {
        var sortedNumbers = MergeSort(numbers);

        for (int i = 0; i < sortedNumbers.Length; i++)
        {
            numbers[i] = sortedNumbers[i];
        }
    }
    public static int[] MergeSort(int[] numbers)
    {
        if (numbers.Length <= 1)
        {
            return numbers;
        }

        var left = new List<int>();
        var right = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 > 0)
            {
                left.Add(numbers[i]);
            }
            else
            {
                right.Add(numbers[i]);
            }
        }

        left = MergeSort(left.ToArray()).ToList();
        right = MergeSort(right.ToArray()).ToList();

        return Merge(left,right);
    }

    private static int[] Merge(List<int> left, List<int> right)
    {
        var result = new List<int>();

        while (NotEmpty(left) && NotEmpty(right))
        {
            if (left.First() <= right.First())
            {
                MoveValueFromScourceToResult(left, result);
            }
            else
            {
                MoveValueFromScourceToResult(right, result);
            }
        }

        while(NotEmpty(left))
        {
            MoveValueFromScourceToResult(left, result);
        }

        while (NotEmpty(right))
        {
            MoveValueFromScourceToResult(right, result);
        }

        return result.ToArray();
    }

    private static bool NotEmpty(List<int> left)
    {
        return left.Count > 0;
    }

    private static void MoveValueFromScourceToResult(List<int> left, List<int> result)
    {
        result.Add(left.First());
        left.RemoveAt(0);
    }

    static void Main(string[] args)
    {

    }
}
