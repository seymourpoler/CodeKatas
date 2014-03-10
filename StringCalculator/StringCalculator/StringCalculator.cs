using System;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private  char[] CHARACTERS = new[] { ',', '\n' };

        public int Add(string entry)
        {
            var values = entry.Split(CHARACTERS);
            return values
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
    }
}
