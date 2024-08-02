using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Area_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 4;
            double s = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Act
            double actualArea = AreaCalculation.Area(a, b, c);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Area_ValidSides_RightTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double s = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Act
            double actualArea = AreaCalculation.Area(a, b, c);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Area_ZeroSide_ThrowsArgumentException()
        {
            // Arrange
            double a = 0;
            double b = 4;
            double c = 5;

            // Act & Assert
            Assert.Throws<Exception>(() => AreaCalculation.Area(a, b, c));
        }

        [Fact]
        public void Area_InvalidTriangleSides_ThrowsArgumentException()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 3;

            // Act & Assert
            Assert.Throws<Exception>(() => AreaCalculation.Area(a, b, c));
        }
    }
}
