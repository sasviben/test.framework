using System;

namespace UI.Helpers
{
    class Common
    {
        /// <summary>
        ///    Converts string value to double and rounds it to two decimal points.
        /// </summary>
        /// <param name="stringValue">
        ///    stringValue represents string that should be converted.
        /// </param>
        /// <returns>
        ///    Returns double value of a string value rounded to two decimal points
        /// </returns>
        /// <exception cref="ArgumentException">
        ///    stringValue is a zero-length string, contains only white space, contains one or more invalid characters.
        /// </exception>
        public static double GetDoubleValueRoundedTwoDecimal(string stringValue)
        {
            if (double.TryParse(stringValue, out double doubleValue) == false)
                throw new ArgumentException($"String {stringValue} could not be parsed to double type!");

            Math.Round(doubleValue, 2);
            return doubleValue;
        }
    }
}
