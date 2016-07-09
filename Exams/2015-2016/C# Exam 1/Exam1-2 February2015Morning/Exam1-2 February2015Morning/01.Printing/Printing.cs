using System;

class Printing
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); //how many students
        int s = int.Parse(Console.ReadLine()); //paper sheet for each student
        double p = double.Parse(Console.ReadLine()); // price for a realm

        double papersForStudent = n * s;
        double howManyRealms = papersForStudent / 500;
        double priceForAllRealms = howManyRealms * p;

        Console.WriteLine("{0:F2}",priceForAllRealms);

    }
}
