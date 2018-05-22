using System;
using System.Collections.Generic;

namespace CodeKataCsv
{
    public class CsvConverter
    {
        public IReadOnlyCollection<string> Convert<T>(List<T> list) 
            where T : class
        {
            if(list == null || list.Count == 0)
            { 
                return new string[] { };
            }
            throw new NotImplementedException();
        }
    }
}
