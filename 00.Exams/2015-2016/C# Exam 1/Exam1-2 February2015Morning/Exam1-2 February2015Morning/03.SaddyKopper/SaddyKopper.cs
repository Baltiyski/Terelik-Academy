using System;
using System.Numerics;

class SaddyKopper
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int transformationCount = 0;

        
        while (num.Length > 1 && transformationCount < 10)
        {
            BigInteger prod = 1;
            while (num.Length > 0)
            {
                num = num.Substring(0, num.Length - 1);
                int sum = 0;
                for (int i = 0; i < num.Length; i += 2)
                {
                    sum += (num[i] - '0');
                }

                prod *= sum != 0 ? sum : 1;
            }

            transformationCount++;
            num = prod.ToString();
        }


        if (transformationCount < 10)
        {
            Console.WriteLine(transformationCount);
        }

        Console.WriteLine(num);
    }
}
