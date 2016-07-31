using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] list = new int[n + 1];
            int newVal = 0;

            for (int i = 2; i < list.Length; i++)
            {
                if (list[i] == 1)
                {
                    continue;
                }

                for (int j =  i*2; j < list.Length; j+=i)
                {   
                    list[j] = 1;   
                }
                newVal = i;
            }

            Console.WriteLine(newVal);
        }
    }
}
