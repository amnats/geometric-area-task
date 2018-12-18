using System;
using GeometricArea.Figure;
using GeometricArea.Util.Exceptions;
using Xunit;

namespace GeometricAreaTest
{
    public class CircleTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ThrowsWhenRadiusIsInvalid(double r)
        {
            Assert.Throws<RadiusOutOfRangeException>(() => new Circle(r));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, 12.566370614359)]
        public void CanCalculateArea(double r, double expectedArea)
        {
            var circle = new Circle(r);

            var area = circle.CalculateArea();
            
            Assert.Equal(expectedArea, area, 10);
        }
    }
}