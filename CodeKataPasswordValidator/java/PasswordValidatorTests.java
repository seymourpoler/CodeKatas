import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;


public class PasswordValidatorTests {
	private PasswordValidator _passwordValidator;
	
	@Before
	public void SetUp(){
		_passwordValidator = new PasswordValidator();
	}
	
	@Test
	public void PasswordValidator_return_true_when_has_at_least_six_chars() {
		boolean isValid = _passwordValidator.isValidPassword("1aA___");
		
		assertTrue(isValid);
	}
	
	@Test
	public void PasswordValidator_return_false_when_has_not_at_least_six_chars() {
		boolean isValid = _passwordValidator.isValidPassword("1aA__");
		
		assertFalse(isValid);
	}

	@Test
	public void PasswordValidator_return_false_when_has_not_at_least_one_uppercase_char() {
		boolean isValid = _passwordValidator.isValidPassword("1ab__");
		
		assertFalse(isValid);
	}
	
	@Test
	public void PasswordValidator_return_false_when_has_not_at_least_one_lowercase_char() {
		boolean isValid = _passwordValidator.isValidPassword("12CB__");
		
		assertFalse(isValid);
	}
	
	@Test
	public void PasswordValidator_return_false_when_has_not_at_least_one_number() {
		boolean isValid = _passwordValidator.isValidPassword("AzCB__");
		
		assertFalse(isValid);
	}
	
	@Test
	public void PasswordValidator_return_false_when_has_not_at_least_one_underscore() {
		boolean isValid = _passwordValidator.isValidPassword("AzCB12345");
		
		assertFalse(isValid);
	}
}
