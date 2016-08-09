using System;
using System.Collections.Generic;
using System.Linq;


class IntegerCalculation
{
    static int Minimum(int[] array)
    {
        int minimum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }
        return minimum;
    }

    static int Maximum(int[] array)
    {
        int maximum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        return maximum;
    }

    static decimal Average(int[] array)
    {
        decimal average = 0m;
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        average = (decimal)sum / array.Length;

        return average;
    }

    static long Sum(int[] array)
    {
        long sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static long Product(int[] array)
    {
        long product = 1;


        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static void Main(string[] args)
    {
        int[] firstCombOfNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(Minimum(firstCombOfNum));
        Console.WriteLine(Maximum(firstCombOfNum));
        Console.WriteLine("{0:F2}", Average(firstCombOfNum));
        Console.WriteLine(Sum(firstCombOfNum));
        Console.WriteLine(Product(firstCombOfNum));
    }
}
