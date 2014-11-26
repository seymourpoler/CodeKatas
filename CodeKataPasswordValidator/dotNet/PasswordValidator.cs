using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
	public class PasswordValidator
	{
		private const int MINIMUM_PASSWORD_LENGTH = 4;
		
		public bool isValidPassword (string password)
		{
			return (HasMinimumLength (password)) && 
				(ContainsNumbers (password) &&
				 (ContainsCharacters (password)) &&
				 (ContainsCapitalLetter (password)) &&
				 (ContainsMinusculaLetter (password)));
		}
				
		private bool HasMinimumLength (string password)
		{
			return password.Length >= MINIMUM_PASSWORD_LENGTH;
		}
		
		private bool ContainsNumbers (string password)
		{
			return Regex.IsMatch (password, @"[0-9]");
		}
		
		private bool ContainsCharacters (string password)
		{
			return Regex.IsMatch (password, @"[a-zA-Z]");
		}
		
		private bool ContainsCapitalLetter (string password)
		{
			return Regex.IsMatch (password, @"[A-Z]");
		}
		
		private bool ContainsMinusculaLetter (string password)
		{
			return Regex.IsMatch (password, @"[a-z]");
		}
	}
}

