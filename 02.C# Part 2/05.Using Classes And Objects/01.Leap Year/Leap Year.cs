using System;

class Program
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        bool isYearLeap = System.DateTime.IsLeapYear(year);
        if (!isYearLeap)
        {
            Console.WriteLine("Common");
        }
        else
        {
            Console.WriteLine("Leap");
        }
    }
}
