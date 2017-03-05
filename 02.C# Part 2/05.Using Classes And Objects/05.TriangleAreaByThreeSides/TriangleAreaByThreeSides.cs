using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TriangleAreaByThreeSides
{
    class HeroFrmula
    {
        public double Formula(double sideA, double sideB, double sideC)
        {
            double result = 0;
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            result = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA)* (halfPerimeter - sideB)* (halfPerimeter - sideC));

            return result;
        }
    }
    class TriangleAreaByThreeSides
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            HeroFrmula formula = new HeroFrmula();
            double result = formula.Formula(sideA, sideB, sideC);
            Console.WriteLine("{0:F2}", result);

        }
    }
}
