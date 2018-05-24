using System;
using System.Collections.Generic;
using System.Reflection;

namespace CodeKataCsv
{
    public class CsvConverter
    {
        public IList<string> Convert<T>(List<T> list) 
            where T : class
        {
            if(list == null)
            {
                return new List<string>();
            }
            var result = new List<string>
            {
                GetHeader<T>(),
            };
            result.AddRange(GetBody(list));
            return result;
        }

        private IEnumerable<string> GetBody<T>(List<T> list)
        {
            foreach (var item in list)
            {
                yield return GetValues(item);
            }
        }

        private string GetHeader<T>() 
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            var headers = new List<string>();
            foreach(var property in properties)
            {
                headers.Add(property.Name);
            }
            return String.Join(";", headers.ToArray());
        }

        private string GetValues<T>(T item)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            var values = new List<string>();
            foreach (var property in properties)
            {
                values.Add(GetValue(item, property));
            }
            return String.Join(";", values.ToArray());
        }

        private string GetValue<T>(T item, PropertyInfo property)
        {
            return System.Convert.ToString(property.GetValue(item));
        }
    }
}
