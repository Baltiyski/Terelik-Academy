using System;

class PrintRandomNumbers
{
    static void Main(string[] args)
    {

        Random rand = new Random();
        int number = rand.Next(100,200);
        Console.WriteLine(number);
    }
}

