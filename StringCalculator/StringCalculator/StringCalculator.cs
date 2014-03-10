using System;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private  char[] CHARACTERS = new[] { ',', '\n' };

        public int Add(string entry)
        {
            var separator = CHARACTERS;

            if (entry.StartsWith("//"))
            {
                separator = GetSeparator(entry);
                entry = GetNumbers(entry);
            }

            return SumNumber(entry, separator);
        }

        private int Sum(string[] numbers)
        {
            return numbers
                    .Select(
                        number =>
                        {
                            return ConvertToInt(number);
                        })
                    .Sum();
        }

        private int ConvertToInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }
            return Convert.ToInt32(value);
        }

        private char[] GetSeparator(string entry)
        {
            var delimiters = entry.Replace(@"//", string.Empty).Split(new[] {'\n'});
            return delimiters[0].ToCharArray();
        }

        private string GetNumbers(string entry)
        {
            var delimiters = entry.Split(new[] { '\n' });
            return delimiters[1];
        }

        private int SumNumber(string entry, char[] separator)
        {
            var values = entry.Split(separator);
            return Sum(values);
        }
    }
}
