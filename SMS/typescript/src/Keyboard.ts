export class Keyboard {
	public ConvertTo(numbers: string): string{
		if(numbers == ""){
			return "";
		}
		if(numbers == "0"){
			return "-";
		}
		throw 'Not Implemented';
	}
}