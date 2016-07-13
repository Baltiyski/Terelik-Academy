using System;

class DiamondTrolls
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2 + 1;
        int height = 6 + (n - 3) / 2 * 3;

        int top = (width - n) / 2;
        Console.Write(new string('.', top));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('.', top));

        int nextDot = top - 1;
        int row = top;

        for (int i = 0; i < row - 1; i++)
        {
            top--;
            Console.Write(new string('.', top));
            Console.Write('*');
            Console.Write(new string('.', nextDot));
            Console.Write('*');
            Console.Write(new string('.', nextDot));
            Console.Write('*');
            Console.WriteLine(new string('.', top));

            nextDot++;
        }
        
        Console.WriteLine(new string('*', width));
        int firstDots = 1;

        for (int i = 0; i < n -1; i++)
        {
            nextDot--;
            Console.Write(new string('.', firstDots));
            Console.Write('*');
            Console.Write(new string('.', nextDot));
            Console.Write('*');
            Console.Write(new string('.', nextDot));
            Console.Write('*');
            Console.WriteLine(new string('.', firstDots));
            firstDots++;
        }

        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));

    }
}
