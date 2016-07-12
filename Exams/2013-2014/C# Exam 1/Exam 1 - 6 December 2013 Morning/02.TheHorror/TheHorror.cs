using System;

class TheHorror
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        long count = 0;
        long sum = 0;
        long even = 0;

        foreach (var num in number)
        {
            if (even % 2 == 0)
            {
                if (Char.IsDigit(num))
                {
                    count++;
                    sum += num - '0';
                }
            }
            even++;
        }

        Console.Write(count + " ");
        Console.WriteLine(sum);
    }
}
