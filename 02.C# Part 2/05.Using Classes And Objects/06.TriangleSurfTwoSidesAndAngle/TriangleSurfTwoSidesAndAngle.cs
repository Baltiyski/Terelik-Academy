using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleSurfTwoSidesAndAngle
{
    class Formula
    {
        public double Calculate(double sideA, double sideB, double angle)
        {
            double sin = Math.Sin(rad(angle));
            double result = (sideA * sideB * sin) / 2;

            return result;
        }

        public static double rad(double deg)
        {
            return deg * Math.PI / 180;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Formula form = new Formula();
            Console.WriteLine("{0:F2}",form.Calculate(sideA, sideB, angle));
            //Console.WriteLine(Math.Sin(angle));

        }
    }
}
