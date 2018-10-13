using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectLiteralToQueryString
{
	public class ObjectLiteralToQueryString
    {
		public string ToQueryString(Hashtable hashtable)
		{
			if(hashtable is null)
			{
				return String.Empty;
			}
			if(hashtable.Count == 0)
			{
				return String.Empty;
			}
			var values = new List<string>();
			foreach(var key in hashtable.Keys)
			{
				values.Add($"{key}={hashtable[key]}");
			}

			return String.Join("&", values);
		}
    }
}
