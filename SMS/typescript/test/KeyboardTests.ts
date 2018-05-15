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
		let result = keyboard.ConvertTo("");

		"".should.be.equal(result);
	});

	it("returns character from number", () =>{
		let result = keyboard.ConvertTo("0");

		"-".should.be.equal(result);
	});

	it("returns character from two numbers", ()=>{
		let result = keyboard.ConvertTo("22");

		"b".should.be.equal(result);
	});

	it("returns character from three numbers", ()=>{
		let result = keyboard.ConvertTo("555");

		"l".should.be.equal(result);
	});

	it("returns a word", () =>{
		let result = keyboard.ConvertTo("6 666 66 666");

		"mono".should.be.equal(result);
	});

	it("returns two words", () =>{
		let result = keyboard.ConvertTo("6 666 66 666 111 222 2 7777 2");

		"mono casa".should.be.equal(result);
	});

	it("returns a word without white spaces", () => {
		let result = keyboard.ConvertTo("446665552");

		"hola".should.be.equal(result);
	});
});