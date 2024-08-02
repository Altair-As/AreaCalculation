using AreaCalculation.Figures;

namespace AreaCalculation
{
    public class AreaCalculation
    {
        public double Area(double radius)
        {
            return Circle.Area(radius);
        }

        public double Area(double a, double b, double c)
        {
            return Triangle.Area(a, b, c);
        }
    }
}
