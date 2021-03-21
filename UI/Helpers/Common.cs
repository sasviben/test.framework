using System;

namespace UI.Helpers
{
    class Common
    {
        private const string SIMPLE = "SIMPLU";
        private const string SYSTEM = "SISTEM";
        private const string LOTTO = "LOTO";

        public static double GetDoubleValueRoundedTwoDecimal(string stringValue)
        {
            if (double.TryParse(stringValue, out double doubleValue) == false)
                throw new ArgumentException($"String {stringValue} could not be parsed to double type!");

            Math.Round(doubleValue, 2);
            return doubleValue;

        }
        public static string TranslateToEnglish(string word)
        {
            string translatedWord = word;

            if (word.Equals(SIMPLE, StringComparison.OrdinalIgnoreCase))
                translatedWord = "SIMPLE";
            if (word.Equals(SYSTEM, StringComparison.OrdinalIgnoreCase))
                translatedWord = "SYSTEM";
            if (word.Equals(LOTTO, StringComparison.OrdinalIgnoreCase))
                translatedWord = "LOTTO";

            return translatedWord;

        }
        public static double GetRandomNumber(int startNumber, int endNumber)
        {
            var random = new Random();
            return (double)(random.Next(startNumber, endNumber));
        }
        public static void Wait(int seconds)
        {
            var time = DateTime.Now;
            do
            {
            } while (time.AddSeconds(seconds) > DateTime.Now);
        }
    }
}
