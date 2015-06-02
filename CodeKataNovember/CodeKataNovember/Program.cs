using System;
using System.Collections.Generic;

namespace CodeKataNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books;
            List<int> bks = new List<int>();
            books = new Books(bks);
            decimal money = books.GetPrice();
        }
    }
}
