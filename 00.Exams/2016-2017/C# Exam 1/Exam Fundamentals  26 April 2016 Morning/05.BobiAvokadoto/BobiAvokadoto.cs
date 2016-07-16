using System;

class BobiAvokadoto
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        int howManyNum = int.Parse(Console.ReadLine());

        uint bestNum = 0u;
        uint bestBits = 0u;

        for (int i = 0; i < howManyNum; i++)
        {
            uint num = uint.Parse(Console.ReadLine());
            if ((n | num) == n + num)
            {
                uint bits = 0;
                uint combo = num;

                while (combo > 0)
                {
                    bits += combo & 1u;
                    combo >>= 1;
                }
                if (bits > bestBits)
                {
                    bestNum = num;
                    bestBits = bits;
                }
            }
        }
        Console.WriteLine(bestNum);
    }
}
