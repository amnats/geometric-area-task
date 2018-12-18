using System;

namespace GeometricArea.Util.Exceptions
{
    public class SideLengthOutOfRangeException : ArgumentOutOfRangeException
    {
        public SideLengthOutOfRangeException(string paramName) 
            : base(paramName, "Side length should be non-negative")
        {
        }
    }
}