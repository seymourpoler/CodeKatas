export class Keyboard {
	private characters : Map<string, string>; 

	public constructor(){
		this.characters = new Map<string, string>(); 
		this.characters.set("0", "-");
		this.characters.set("00", "_");
		this.characters.set("000", ":");
		this.characters.set("0000", "0");

		this.characters.set("1", ".");
		this.characters.set("11", ";");
		this.characters.set("111", " ");
		this.characters.set("1111", "1");

		this.characters.set("2", "a");
		this.characters.set("22", "b");
		this.characters.set("222", "c");
		this.characters.set("2222", "2");

		this.characters.set("3", "d");
		this.characters.set("33", "e");
		this.characters.set("333", "f");
		this.characters.set("3333", "3");

		this.characters.set("4", "g");
		this.characters.set("44", "h");
		this.characters.set("444", "i");
		this.characters.set("4444", "4");

		this.characters.set("5", "j");
		this.characters.set("55", "k");
		this.characters.set("555", "l");
		this.characters.set("5555", "5");

		this.characters.set("6", "m");
		this.characters.set("66", "n");
		this.characters.set("666", "o");
		this.characters.set("6666", "6");

		this.characters.set("7", "p");
		this.characters.set("77", "q");
		this.characters.set("777", "r");
		this.characters.set("7777", "s");
		this.characters.set("77777", "7");

		this.characters.set("8", "t");
		this.characters.set("88", "u");
		this.characters.set("888", "v");
		this.characters.set("8888", "8");

		this.characters.set("9", "w");
		this.characters.set("99", "x");
		this.characters.set("999", "y");
		this.characters.set("9999", "z");
		this.characters.set("99999", "9");
	}
	public ConvertTo(numbers: string): string{
		let result = "";
		if(numbers == ""){
			return result;
		}
		numbers
			.split(" ")
			.forEach((number:string) =>{
				result = result + this.characters.get(number);
			});
		return result;
	}
}