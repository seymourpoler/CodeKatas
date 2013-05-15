
using System;
using PasswordValidator;
using NUnit.Framework;

namespace PasswordValidatorTest
{
	[TestFixture()]
	public class PasswordValidatorSpec
	{
		private PasswordValidator.PasswordValidator _validator;
		
		[SetUp()]
		public void SetUp ()
		{
			_validator = new PasswordValidator.PasswordValidator ();
		}
		
		[Test()]
		public void clase_es_valida_cuando_tiene_longitud_minima_de_seguridad ()
		{
			var isValid = _validator.isValidPassword ("1abcd1234_A"); 
			
			Assert.IsTrue (isValid);
		}

		[Test()]
		public void clase_no_es_valida_cuando_tiene_longitud_insuficiente ()
		{
			var isValid = _validator.isValidPassword ("abc"); 
			
			Assert.IsFalse (isValid);
		}
		
		[Test()]
		public void clase_no_es_valida_cuando_no_tiene_numero ()
		{
			var isValid = _validator.isValidPassword ("abcd"); 
			
			Assert.IsFalse (isValid);
		}
		
		[Test()]
		public void clase_no_es_valida_cuando_no_tiene_letra ()
		{
			var isValid = _validator.isValidPassword ("12345"); 
			
			Assert.IsFalse (isValid);
		}
		
		[Test()]
		public void clase_no_es_valida_cuando_no_tiene_letra_mayusculas ()
		{
			var isValid = _validator.isValidPassword ("12345aqs"); 
			
			Assert.IsFalse (isValid);
		}
		
		[Test()]
		public void clase_no_es_valida_cuando_no_tiene_letra_minusculas ()
		{
			var isValid = _validator.isValidPassword ("12345AQWS"); 
			
			Assert.IsFalse (isValid);
		}
		
		
	}
}

