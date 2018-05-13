import "mocha";
import "should";

import { Keyboard } from "../src/Keyboard";

describe("Keyboard", () => {
	let keyboard: Keyboard;
	
	beforeEach(() => keyboard = new Keyboard());
	
	it("works", function(){
        true.should.be.equal(true);
	});
	
	it("returns string empty when there is no numbers", () =>{
		var result = keyboard.ConvertTo("");

		"".should.be.equal(result);
	});

	it("returns character from number", () =>{
		var result = keyboard.ConvertTo("0");

		"-".should.be.equal(result);
	});
});