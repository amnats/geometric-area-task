using System;

namespace GeometricArea.Util.Exceptions
{
    public class InvalidTriangleSidesException : ApplicationException
    {
        public InvalidTriangleSidesException(double sideA, double sideB, double sideC) 
            : base($"Triangle is impossible with given sides: [{sideA}, {sideB}, {sideC}]")
        {
        }
    }
}