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
                                return ManageNumber(number);
                            })
                    .Sum();
        }

        private int ManageNumber(string number)
        {
            var integer = ConvertToInt(number);
            Validation(integer);
            return integer;
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

        private void Validation(int number)
        {
            if (number < 0)
            {
                throw new Exception();
            }
        }
    }
}
