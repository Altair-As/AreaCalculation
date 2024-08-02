using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Area_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expected = Math.PI * radius * radius;

            // Act
            double actual = AreaCalculation.Area(radius);

            // Assert
            Assert.Equal(expected, actual, precision: 5);
        }

        [Fact]
        public void Area_NegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.Throws<Exception>(() => AreaCalculation.Area(radius));
        }
    }
}
