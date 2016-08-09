using System;
using System.Numerics;

class NFactorial
{
    static BigInteger Factorial(int number)
    {
        BigInteger factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(number));
    }
}
