using System;

namespace GeometricArea.Util.Exceptions
{
    public class RadiusOutOfRangeException : ArgumentOutOfRangeException
    {
        public RadiusOutOfRangeException(string paramName) 
            : base(paramName, "Radius should be non-negative")
        {
        }
    }
}