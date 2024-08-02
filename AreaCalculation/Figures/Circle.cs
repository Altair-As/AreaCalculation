using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Figures
{
    internal static class Circle
    {
        // Formula: S = π * r^2

        public static double Area(double radius)
        {
            return double.Pi * Math.Sqrt(radius * radius);
        }
    }
}
