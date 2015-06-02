using System;
using System.Collections;

namespace SMS
{
    public class CharacterManager : ICharacterManager
    {
        private readonly Hashtable _data;

        public CharacterManager()
        {
            _data = new Hashtable();
            _data["0"] = "-";
            _data["00"] = "_";
            _data["000"] = ":";
            _data["0000"] = "0";

            _data["1"] = ".";
            _data["11"] = ";";
            _data["111"] = " ";
            _data["1111"] = "1";

            _data["2"] = "a";
            _data["22"] = "b";
            _data["222"] = "c";
            _data["2222"] = "2";

            _data["3"] = "d";
            _data["33"] = "e";
            _data["333"] = "f";
            _data["3333"] = "3";

            _data["4"] = "g";
            _data["44"] = "h";
            _data["444"] = "i";
            _data["4444"] = "4";

            _data["5"] = "j";
            _data["55"] = "k";
            _data["555"] = "l";
            _data["5555"] = "5";

            _data["6"] = "m";
            _data["66"] = "n";
            _data["666"] = "o";
            _data["6666"] = "6";

            _data["7"] = "p";
            _data["77"] = "q";
            _data["777"] = "r";
            _data["7777"] = "s";
            _data["77777"] = "7";

            _data["8"] = "t";
            _data["88"] = "u";
            _data["888"] = "v";
            _data["8888"] = "8";

            _data["9"] = "w";
            _data["99"] = "x";
            _data["999"] = "y";
            _data["9999"] = "z";
            _data["99999"] = "9";
        }

        public string GetCharacter(string number)
        {
            try
            {
                return _data[number].ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
