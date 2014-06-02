using System.Linq;
using System.Text;


namespace SMS
{
    public class SMSManager
    {
        private const char SEPARATOR = ' ';
        
        private ICharacterManager _characterManager;

        public SMSManager(ICharacterManager characterManager)
        {
            _characterManager = characterManager;

            
        }

        public string WriteMessage(string numbers)
        {
            var result = new StringBuilder();
            var character = string.Empty;
            var values = numbers.Split(new[] { SEPARATOR });
            values.ToList().ForEach(number =>
                {
                    character = _characterManager.GetCharacter(number);
                    result.Append(character);
                });
            return result.ToString();
        }
    }
}
