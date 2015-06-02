describe("Transformer", function(){
	it("Should be empty array when is empty string", function(){
		expect(findPositionsOfUpperCaseCharactersIn("a")).toEqual([]);
	});
	it("Should be empty array when there is no uppercase characters", function(){
		expect(findPositionsOfUpperCaseCharactersIn("asxzccvvff")).toEqual([]);
	});	
	it("Should be array with one position, when there is a one uppercar character in the first position", function(){
		expect(findPositionsOfUpperCaseCharactersIn("Ax")).toEqual([0]);
	});

	it("Should be array with one position, when there is a one upper", function(){
		expect(findPositionsOfUpperCaseCharactersIn("zxsaAx")).toEqual([4]);
	});
	it("Should be array with one position, when there is more than a one uppercase character", function(){
		expect(findPositionsOfUpperCaseCharactersIn("zTsaAxL")).toEqual([1,4,6]);
	});
});