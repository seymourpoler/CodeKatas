using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataDuplicatedArray
{
    public class Lista
    {
        private List<int> _values;
        public Lista(List<int> values)
        {
            _values = values;
        }

        public List<int> GetDuplicated()
        {
            List<int> resultado = new List<int>();
            for (int contador = 0; contador < _values.Count; contador++)
            {
                for (int indice = 0; indice < _values.Count; indice++)
                {
                    if (indice != contador)
                    {
                        if (_values[contador] == _values[indice])
                        {
                            if(!IsRepeted(resultado, _values[contador]))
                                resultado.Add(_values[contador]);
                        }
                    }
                }
            }

                return resultado;
        }

        public List<int> RemoveDuplicated(List<int> values)
        {
            List<int> resultado = values;

            for (int contador = 0; contador < resultado.Count; contador++)
            {
                for (int indice = 0; indice < resultado.Count; indice++)
                {
                    if (indice != contador)
                    {
                        if (resultado[contador] == resultado[indice])
                        {
                            resultado.RemoveAt(indice);
                        }
                    }
                }
            }

            return resultado;
        }

        private bool IsRepeted (List<int> numbers, int number)
        {
            bool resultado = false;
            int contador = 0;
            
            while (!resultado && (contador < numbers.Count))
            {
                if (number == numbers[contador]) resultado = true;
                contador++;
            }

            return resultado;

        }
    }
}
