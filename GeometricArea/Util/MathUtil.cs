using System;

namespace GeometricArea.Util
{
    internal static class MathUtil
    {
        public static double Square(double num)
        {
            return num * num;
        }
        
        // from the documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.double.equals?redirectedfrom=MSDN&view=netframework-4.7.2#System_Double_Equals_System_Double_
        public static bool AreDoublesEqual(double a, double b)
        {
            var difference = Math.Abs(a * 1E-5);
            
            return Math.Abs(a - b) <= difference;
        }
    }
}