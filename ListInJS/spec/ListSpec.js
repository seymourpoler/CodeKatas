describe("list in javascript using TDD", function(){
	describe(".count()", function(){
		it("Given empty list when call Count method then returns zero ", function(){
			var numbers = new List();
			expect(numbers.count()).to.eql(0);
		});
		it("Given list when call Count method then returns the number of elements ", function(){
			var numbers = new List([1,2,3,4]);
			expect(numbers.count()).to.eql(4);	
		});
	});
	describe(".sum()", function(){
		it("Given list when call Sum method then returns Zero ", function(){
			var numbers = new List();
			expect(numbers.sum()).to.eql(0);
		});
		it("Given list with numbers when call Sum method then returns the sumary", function(){
			var numbers = new List([1,2,3,4]);
			expect(numbers.sum()).to.eql(10);
		});
		it("Given list with strings when call Sum method then returns only the sum of the numbers ", function(){
			var numbers = new List([1,'w', {a:1, b:3}, 5, 'rdf']);
			expect(numbers.sum()).to.eql(6);
		});
		it("Given list with obejcts when call Sum method then returns only the sum of the filtered elements", function(){
			var numbers = new List([{a:1, b:3},{a:6, b:3}]);
			expect(numbers.sum(function(x){
									return x.a;
								})).to.eql(7);
		});
	});
});