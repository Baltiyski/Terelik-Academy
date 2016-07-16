using System;

class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long sum = 0;
        long sumCopy;

        if (b == 3)
        {
            sum = a + c;
        }
        else if (b == 6)
        {
            sum = a * c;
        }
        else if(b == 9)
        {
            sum = a % c;
        }

        sumCopy = sum;
        if (sum % 3 == 0)
        {
            Console.WriteLine(sumCopy / 3);
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine(sumCopy % 3);
            Console.WriteLine(sum);
        }
        

    }
}
