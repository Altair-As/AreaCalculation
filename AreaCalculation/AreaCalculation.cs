using AreaCalculation.Figures;

namespace AreaCalculation
{
    public class AreaCalculation
    {
        /// <summary>
        /// This method calculates the area of a circle.
        /// </summary>
        /// <param name="radius">The radius of the circe.</param>
        /// <returns>The area of the circle.</returns>
        public double Area(double radius)
        {
            try
            {
                return Circle.Area(radius);
            }
            catch { throw; }
        }

        /// <summary>
        /// This method calculates the area of a triangle given the lengths of its three sides.
        /// </summary>
        /// <param name="a">The length of the first side of the triangle.</param>
        /// <param name="b">The length of the second side of the triangle.</param>
        /// <param name="c">The length of the third side of the triangle.</param>
        /// <returns>The area of the triangle.</returns>
        public double Area(double a, double b, double c)
        {
            try
            {
                return Triangle.Area(a, b, c);
            }
            catch { throw; }
        }
    }
}
