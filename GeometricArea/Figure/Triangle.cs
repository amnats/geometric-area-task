using System;
using System.Collections.Generic;
using System.Linq;
using GeometricArea.Interfaces;
using GeometricArea.Util;
using GeometricArea.Util.Exceptions;

namespace GeometricArea.Figure
{
    public class Triangle : IFigure
    {
        // Code readability is in priority 
        // above efficiency if not stated otherwise
        
        // Side lengths are stored as separate fields 
        // instead of storing them inside of a collection
        // for better readability of formulas
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            AssertSidesLengthAreValid(sideA, sideB, sideC);
            
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        private void AssertSidesLengthAreValid(double sideA, double sideB, double sideC)
        {
            AssertSideLengthIsNonNegative(sideA, nameof(sideA));
            AssertSideLengthIsNonNegative(sideB, nameof(sideB));
            AssertSideLengthIsNonNegative(sideC, nameof(sideC));

            var sidesFormTriangle = sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
            if (!sidesFormTriangle)
            {
                throw new InvalidTriangleSidesException(sideA, sideB, sideC);
            }
        }

        private void AssertSideLengthIsNonNegative(double side, string sideName)
        {
            if (side <= 0)
            {
                throw new SideLengthOutOfRangeException(sideName);
            }
        }
        
        public double CalculateArea()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            var area = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            
            return area;
        }

        public bool IsRightAngled()
        {
            var sidesCol = new SortedSet<double> { _sideA, _sideB, _sideC };
            var longestSide = sidesCol.Max;
            sidesCol.Remove(longestSide);

            var longestSideSquared = MathUtil.Square(longestSide);
            var sumOfSquaresOfOtherSides = MathUtil.Square(sidesCol.First()) + MathUtil.Square(sidesCol.Last());
            
            // c^2 == a^2 + b^2
            var isRightAngled = MathUtil.AreDoublesEqual(longestSideSquared, sumOfSquaresOfOtherSides);

            return isRightAngled;
        }
        
    }
}