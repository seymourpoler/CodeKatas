using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataNovember
{
    public class Books
    {
        private List<int> _books;

        public Books(List<int> books)
        {
            _books = books;
        }
        public decimal GetPrice()
        {
            decimal resultado = 0;
            bool terminado = false;
            int cantidad;
            while(!terminado)
            {
                cantidad = 0;
                for (int contador = 0;contador < _books.Count; contador++)
                {
                    if(-1 < _books[contador])
                    {
                        _books[contador] = _books[contador] - 1;
                        cantidad ++;
                    }
                }
                resultado = resultado + GetDiscount(cantidad);
                if (0 == cantidad) terminado = true;
            }

            return resultado;
        }

        private decimal GetDiscount(int num)
        {
            decimal resultado = 0;

            switch (num)
            {
                case 1:
                    return Convert.ToDecimal(8);
                    break;
                case 2:
                    return Convert.ToDecimal(num * 8  * 0.95);
                    break;
                case 3:
                    return Convert.ToDecimal(num * 8 * 0.9);
                    break;
                case 4:
                    return Convert.ToDecimal(num * 8 * 0.8);
                    break;
                case 5:
                    return Convert.ToDecimal(num * 8 * 0.75);
                    break;
            }

            return resultado;
        }
    }
}
