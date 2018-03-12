using System;

namespace Calculator.Helpers
{
    public static class CalculatorsHelper
    {
        public static int Modulo(int a, int b)
        {
            return a % b;
        }

        [Obsolete("Use RandomNumber(int max).")]
        public static int BadRandomNumber(int max)
        {
            return max;
        }

        public static int RandomNumber(int max)
        {
            return new Random().Next(max);
        }
    }
}