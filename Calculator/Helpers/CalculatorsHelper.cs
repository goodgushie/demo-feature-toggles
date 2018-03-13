using System;

namespace Calculator.Helpers
{
    public static class CalculatorsHelper
    {
        public static int Modulo(int a, int b)
        {
            return a % b;
        }

        /// <summary>
        /// Generates a non-random number
        /// </summary>
        /// <param name="max">number to be returned</param>
        /// <returns>max</returns>
        [Obsolete("Use RandomNumber(int max).")]
        public static int BadRandomNumber(int max)
        {
            return max;
        }

        /// <summary>
        /// Generates an actual random number
        /// </summary>
        /// <param name="max">Maximum number possible</param>
        /// <returns>Random number between 0 and the max</returns>
        public static int RandomNumber(int max)
        {
            return new Random().Next(max);
        }
    }
}