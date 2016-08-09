using System;
using System.Collections.Generic;
using System.Linq;

class Polynomials
{
    static int[] Polynomial(int[] firstPoly, int[] secondPoly)
    {

        int[] sum = new int[firstPoly.Length];

        for (int i = 0; i < firstPoly.Length; i++)
        {
            sum[i] = firstPoly[i] + secondPoly[i];
        }

        for (int i = secondPoly.Length; i < firstPoly.Length; i++)
        {
            sum[i] = firstPoly[i];
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] firstCombOfNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondCombOfNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] sum = Polynomial(firstCombOfNum, secondCombOfNum);

        List<int> list = new List<int>();

        for (int i = 0; i < sum.Length; i++)
        {
            list.Add(sum[i]);
        }

        Console.WriteLine(string.Join(" ",list));
        
    }
}
