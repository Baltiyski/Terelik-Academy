using System;

class FeathersDescription
{
    static void Main(string[] args)
    {
        double b = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("{0:F4}",b);
        }
        else
        {
            double sum = Math.Abs(f / b);
            if (b % 2 != 0)
            {
                Console.WriteLine("{0:F4}", sum / 317);
            }
            else
            {
                Console.WriteLine("{0:F4}", sum * 123123123123);
            }
        }
        
    }
}
