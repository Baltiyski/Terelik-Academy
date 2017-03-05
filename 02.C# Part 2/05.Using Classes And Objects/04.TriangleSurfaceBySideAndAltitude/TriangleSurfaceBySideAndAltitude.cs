using System;


class CalcSurfaceOfTriangle
{
    public decimal CalcSurface(decimal side, decimal altitude)
    {
        decimal result = (side * altitude) / 2;

        return result;
    }
}

class TriangleSurfaceBySideAndAltitude
{
    static void Main(string[] args)
    {
        decimal side = decimal.Parse(Console.ReadLine());
        decimal altitude = decimal.Parse(Console.ReadLine());

        CalcSurfaceOfTriangle calc = new CalcSurfaceOfTriangle();
        Console.WriteLine("{0:F2}",calc.CalcSurface(side, altitude));

    }
}
