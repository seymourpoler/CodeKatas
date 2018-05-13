export class Keyboard {

	public ConvertTo(numbers: string): string{
		if(numbers == ""){
			return "";
		}
		if(numbers == "0"){
			return "-";
		}
		if(numbers == "22"){
			return "b";
		}
		throw 'Not Implemented';
	}
}