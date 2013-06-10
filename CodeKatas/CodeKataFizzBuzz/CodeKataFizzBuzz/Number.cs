using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataFizzBuzz
{
    public class Number
    {
        private int _number;
        
        private readonly string FIZZ = "Fizz";
        private readonly string BUZZ = "Buzz";
        private readonly string FIZZBUZZ = "FizzBuzz";

        public Number(int number)
        {
            _number = number;
        }

        public List<string> PrintFizzBuzz()
        {
            List<string> resultado = new List<string>();
            if (0 > _number) return resultado;

            if (0 == _number)
            {
                resultado.Add(FIZZBUZZ);
                return resultado;
            }
            for (int contador = 0; contador < _number; contador++)
            {
                if ((0 == contador % 3) && (0 == contador % 5))
                {
                    resultado.Add(FIZZBUZZ);    
                }
                else if ((0 == contador % 3))
                {
                    resultado.Add(FIZZ);
                }
                else if ((0 == contador % 5))
                {
                    resultado.Add(BUZZ);
                }
                else 
                {
                    resultado.Add(Convert.ToString(contador));
                }
            }

            return resultado;
        }
    }
}
