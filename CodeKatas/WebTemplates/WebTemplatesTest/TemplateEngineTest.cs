using System;
using NUnit.Framework;
using System.Collections.Generic;
using WebTemplates;

namespace WebTemplatesTest
{
	[TestFixture]
	public class Tests
	{
		private string _template;
		private TemplateEngine _engine;
		private Dictionary<string, string> _variables;
	
		public  Tests()
		{}
		
		[NUnit.Framework.SetUpAttribute]
		public void SetUp()
		{
			_template = "hola mundo";
			_engine = new TemplateEngine ();
			_variables = new Dictionary<string, string> ();
		}
		
		
		[Test]
		public void TemplateWithNoVariablesIsParsedAsIs ()
		{
			string result = _engine.ParseTemplate (_template, new Dictionary<string, string> ());
			
			Assert.AreEqual ("hola mundo", result);
		}
		
		[Test]
		public void TemplateWithSingleVariableIsParsed ()
		{
			_template = "hola {usuario}";
			_variables.Add ("usuario", "pepe");
			string result = _engine.ParseTemplate (_template, _variables);
			
			Assert.AreEqual ("hola pepe", result);
		}
		
		[Test]
		public void EngineIsNotCaseSensitiveForTemplate ()
		{
			_template = "hola {usuario}";	
			
			_variables.Add ("uSuaRio", "pepe");
			string result = _engine.ParseTemplate (_template, _variables);
			
			Assert.AreEqual ("hola pepe", result);
		}
		
		[Test]
		public void EngineIsNotCaseSensitive ()
		{
			_template = "hola {usuarIo}";	
			
			_variables.Add ("uSuaRio", "pepe");
			string result = _engine.ParseTemplate (_template, _variables);
			
			Assert.AreEqual ("hola pepe", result);
		}
	
		[Test]
		public void EngineIsNotCaseSensitiveWithTheTemplate ()
		{
			_template = "Hola {usuarIo}";	
			
			_variables.Add ("uSuaRio", "pepe");
			string result = _engine.ParseTemplate (_template, _variables);
			
			Assert.AreEqual ("Hola pepe", result);
		}
		
		[Test]
		public void EngineIsNotCaseSensitiveWithTwoReplaces ()
		{
			_template = "Hola {usuArio} {character}";	
			
			_variables.Add ("uSuaRio", "pepe");
			_variables.Add ("character", ":");
			string result = _engine.ParseTemplate (_template, _variables);
			
			Assert.AreEqual ("Hola pepe :", result);
		}
	}
}
