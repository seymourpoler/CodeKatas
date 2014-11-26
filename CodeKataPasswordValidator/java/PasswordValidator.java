public class PasswordValidator {
	private int MIN_CHAR_LENGTH = 6;
	public boolean isValidPassword(String password){
		return password.length() >= MIN_CHAR_LENGTH &&
				hasAtLeastOneLowerCaseChar(password) &&
				hasAtLeastOneUpperCaseChar(password) &&
				hasAtLeastOneNumber(password) &&
				hasAtLeastOneUnderscore(password);
	}
	
	private boolean hasAtLeastOneLowerCaseChar(String input){
		return input.matches(".*[a-z].*");
	}
	
	private boolean hasAtLeastOneUpperCaseChar(String input){
		return input.matches(".*[A-Z].*");
	}
	
	private boolean hasAtLeastOneNumber(String input){
		return input.matches(".*[0-9].*");
	}
	
	private boolean hasAtLeastOneUnderscore(String input){
		return input.matches(".*_.*");
	}
}
