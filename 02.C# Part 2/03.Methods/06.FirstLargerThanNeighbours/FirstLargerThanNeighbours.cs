using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static int FirstlargestNeibhour(int[] array)
    {
        if (array.Length > 2)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i -1] && array[i] > array[i +1])
                {
                    return i;
                }
            }
        }
        

        return -1;
    }
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(FirstlargestNeibhour(numbers));
    }
}
