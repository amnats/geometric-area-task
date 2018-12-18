using System.Collections.Generic;
using System.Linq;
using GeometricArea.Figure;
using GeometricArea.Interfaces;
using Xunit;

namespace GeometricAreaTest
{
    // A test for demonstration purposes
    public class PolymorphismTest
    {
        [Fact]
        public void CanCalculateAreaForAnyFigure()
        {
            var figures = new List<IFigure>
            {
                new Triangle(3, 4, 5),
                new Circle(2)
            };

            var areas = figures.Select(f => f.CalculateArea());
        }
    }
}