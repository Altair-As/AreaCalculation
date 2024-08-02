using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Figures
{
    internal static class Triangle
    {
        // Formula: S = √(р (р — а)(р — b)(p — c))
        // Or: S = (a * b) / 2

        public static double Area(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            double leg1 = sides[0];
            double leg2 = sides[1];
            double hypotenuse = sides[2];

            if (IsRight(leg1, leg2, hypotenuse))
            {
                return (leg1 * leg2) / 2;
            }
            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        private static bool IsRight(double leg1, double leg2, double hypotenuse)
        {
            return Math.Pow(leg1, 2) + Math.Pow(leg2, 2) == Math.Pow(hypotenuse, 2);
        }
    }
}
