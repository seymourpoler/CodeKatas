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
	describe(".take(<number>)", function(){
	    it("Given list when call Take method then returns new empty List ", function(){
	      var numbers = new List();
	      var result = numbers.take(3);
	      expect(result.count()).to.eql(0);
	    });
	    it("Given list  with numbers when call Sum method then returns the sumatory", function(){
	      var numbers = new List([5,3,7,9]);
	      var result = numbers.take(2);
	      expect(result.isEqual(new List([5,3]))).to.be(true);
	    });
  	});
  	describe(".add()", function(){
  		it("Given empty List, add new element, return a list with this element", function(){
  			var listOfNumbers = new List();
  			listOfNumbers.add()
  			expect();
  		});
  	});
  	describe(".where(<condition>)", function(){
		it("Given list  with numbers when call where with a condition method then returns a new list with applied the condition", function(){
		  var numbers = new List([5,3,7,9]);
		  var result = numbers.where(function(x){ return x > 5;});
		  expect(result.isEqual(new List([7,9]))).to.be(true);
	    });
		it("Given list  with numbers when call where with a condition method then returns a new list with applied the condition", function(){
		  var numbers = new List([5,3,7,9]);
		  var result = numbers.where(function(x){ return x > 458});
		  expect(result.isEqual(new List())).to.be(true);
	    });
  	});
  	xdescribe(".union(<list>)", function(){
		it("Given a list with numbers when call union method then returns a new list with the union of the elements", function(){
		  var numbers = new List([5,3,7,9]);
		  var result = numbers.union([1,2,3]);
		  expect(result.isEqual(new List([5,3,7,9, 1,2,3]))).to.be(true);
	    });
		it("Given an empty list when call union method then returns an empty list", function(){
		  var numbers = new List();
		  var result = number.union(new List());
		  expect(result.isEqual(new List())).to.be(true);
	    });
	});
});