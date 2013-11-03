using System;
using System.Text;
using System.Collections.Generic;


namespace WebTemplates
{
	
	public class TemplateEngine
	{
		public TemplateEngine ()
		{
		}
		
		public string ParseTemplate (string template, Dictionary<string, string> dictionary)
		{
			var result = new StringBuilder ();
			string transformedValue;
			
			string[] values = template.Split (new char[]{' '});
			foreach (var val in values) {
				transformedValue = TransformValue (val, dictionary);
				result.Append (transformedValue + " ");
			}
			result.Remove (result.Length - 1, 1);
			return result.ToString ();
		}
		
		private string TransformValue (string name, Dictionary<string, string> dictionary)
		{
			string result = name;
			foreach (var keyValue in dictionary) {
				if (name.ToLower () == "{" + keyValue.Key.ToLower () + "}") {
					result= keyValue.Value;
				} 
					
			}
			return result;
		}
	}
}

