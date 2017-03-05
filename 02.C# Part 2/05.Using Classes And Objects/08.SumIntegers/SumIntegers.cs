using System;
using System.Linq;

namespace _08.SumIntegers
{
    class IntegerSum
    {
        public long Sum(int[] array)
        {
            long sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
    class SumIntegers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            IntegerSum intSum = new IntegerSum();
            Console.WriteLine(intSum.Sum(numbers));
        }
    }
}
