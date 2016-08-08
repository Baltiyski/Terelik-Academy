using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppearanceCount
{
    public static int CountNumberInArray(int[] numbers, int searchNum)
    {
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNum)
            {
                counter++;
            }
        }

        return counter;
    }
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int searchingNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(CountNumberInArray(numbers, searchingNumber));
    }
}
