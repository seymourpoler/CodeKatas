describe("linq in javascript using TDD", function(){
	describe(".count()", function(){
		it("Given empty array when call Count method then returns zero ", function(){
			var numbers = new List();
			expect(numbers.count()).toEqual(0);
		});
		it("Given array when call Count method then returns the number of elements ", function(){
			var numbers = new List([1,2,3,4]);
			expect(numbers.count()).toEqual(4);	
		});
	});
});