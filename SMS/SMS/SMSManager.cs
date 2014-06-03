using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SMS
{
    public class SMSManager
    {
        private ICharacterManager _characterManager;

        public SMSManager(ICharacterManager characterManager)
        {
            _characterManager = characterManager;
        }

        public string WriteMessage(string numbers)
        {
            var result = new StringBuilder();
            var character = string.Empty;
            var values = GetNumbers(numbers);
            values.ToList().ForEach(number =>
                {
                    character = _characterManager.GetCharacter(number);
                    result.Append(character);
                });
            return result.ToString();
        }

        public List<string> GetNumbers(string numbers)
        {
            var result = new List<string>();
            var acumulationNumbers = new StringBuilder();
            var beforeNumber = string.Empty;
            var currentNumber = string.Empty;

            if (numbers.Length == 1)
            {
                return new List<string> { numbers };
            }

            for (var position = 0; position < numbers.Length; position++)
            {
                currentNumber = numbers[position].ToString();
                if (position == 0)
                {
                    beforeNumber = currentNumber;
                    acumulationNumbers.Append(currentNumber);
                }
                else if (position == numbers.Length - 1)
                {
                    if (currentNumber == beforeNumber)
                    {
                        acumulationNumbers.Append(currentNumber);
                        result.Add(acumulationNumbers.ToString());
                    }
                    else
                    {
                        result.Add(acumulationNumbers.ToString());
                        result.Add(currentNumber);
                    }
                }
                else
                {
                    if (currentNumber == beforeNumber)
                    {
                        acumulationNumbers.Append(currentNumber);
                    }
                    else
                    {
                        result.Add(acumulationNumbers.ToString());
                        acumulationNumbers.Clear();
                        acumulationNumbers.Append(currentNumber);
                    }
                    beforeNumber = currentNumber;
                }
            }
            return result;
        }
    }
}
