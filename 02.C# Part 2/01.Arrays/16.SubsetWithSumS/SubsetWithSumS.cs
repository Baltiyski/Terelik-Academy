using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        var sum = 2;
        var isSumExist = false;
        var length = arr.Length;

        int maxConbinations = (int)Math.Pow(2, length) - 1;

        for (int i = 1; i <= maxConbinations; i++)
        {
            long currentsum = 0;
            for (int j = 0; j < length; j++)
            {

                int mask = 1 << j;
                int bit = (mask & i) >> j;

                if (bit == 1)
                {
                    currentsum += arr[j];
                }
            }

            if (currentsum == sum)
            {
                isSumExist = true;
                break;
            }
        }

        var output = isSumExist ? "yes" : "no";
        Console.WriteLine(output);
    }
}
