using System;
using GeometricArea.Util;
using GeometricArea.Interfaces;
using GeometricArea.Util.Exceptions;

namespace GeometricArea.Figure
{
    public class Circle : IFigure
    {
        private readonly double _r;

        public Circle(double r)
        {
            _r = r > 0 ? r : throw new RadiusOutOfRangeException(nameof(r));
        }

        public double CalculateArea()
        {
            var area = Math.PI * MathUtil.Square(_r);

            return area;
        }
    }
}