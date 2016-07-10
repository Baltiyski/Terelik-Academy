using System;

class BitsToBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int maxZero = 0;
        int currentZero = 0;

        int maxOne = 0;
        int currentOne = 0;

        int lastBit = 5;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 29; j >= 0; j--)
            {
                int bit = ((1 << j) & num) >> j;

                if (bit == 1)
                {
                    if (lastBit == 1)
                    {
                        currentOne++;
                        maxOne = Math.Max(maxOne, currentOne);
                    }
                    else
                    {

                        currentZero = 0;
                        currentOne = 1;
                    }
                }
                else
                {
                    if (lastBit == 0)
                    {
                        currentZero++;
                        maxZero = Math.Max(maxZero, currentZero);
                    }
                    else
                    {
                        
                        currentOne = 0;
                        currentZero = 1;
                    }
                }
                lastBit = bit;
            }
        }
        Console.WriteLine(maxZero);
        Console.WriteLine(maxOne);
    }
}
