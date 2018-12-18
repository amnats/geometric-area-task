using GeometricArea.Figure;
using GeometricArea.Util.Exceptions;
using Xunit;

namespace GeometricAreaTest
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        public void CanCreate(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
        }
        
        [Theory]
        [InlineData(1, 2, 3)]
        public void ThrowsIfSidesAreInvalid(double sideA, double sideB, double sideC)
        {
            Assert.Throws<InvalidTriangleSidesException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(double.MinValue, double.MinValue, double.MinValue)]
        public void ThrowsWhenSidesAreNonPositive(double sideA, double sideB, double sideC)
        {
            Assert.Throws<SideLengthOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue, double.PositiveInfinity)]
        public void CanCalculateArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var area = triangle.CalculateArea();
            
            Assert.Equal(expectedArea, area);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(6, 4, 5, false)]
        public void CanCalculateIfIsRightSquared(double sideA, double sideB, double sideC, bool expectedResult)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var isRightAngled = triangle.IsRightAngled();
            
            Assert.Equal(expectedResult, isRightAngled);
        }
    }
}