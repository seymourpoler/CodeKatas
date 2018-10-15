using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectLiteralToQueryString
{
	public class ObjectLiteralToQueryString
    {
		public string ToQueryString(Hashtable hashtable)
		{
			if(hashtable.IsNull())
			{
				return String.Empty;
			}
			if(hashtable.IsEmpty())
			{
				return String.Empty;
			}
			var values = new List<string>();
			foreach(var key in hashtable.Keys)
			{
				values.Add($"{key}={hashtable[key]}");
			}
			//values.Reverse();
			return String.Join("&", values);
		}
    }
}
