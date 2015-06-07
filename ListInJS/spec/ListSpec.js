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
  			listOfNumbers.add(1);
  			expect(listOfNumbers.isEqual(new List([1]))).to.be(true);
  		});
  		it("Given empty List, add new element, return a list with fluent api", function(){
  			var result = new List([3,4,5,6])
			  						.add(1)
			  						.add(7);
  			expect(result.isEqual(new List([3,4,5,6,1,7]))).to.be(true);
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
	    it("Given list  with numbers when call apply condition  with fluent api", function(){
		  var result = new List([1,2,4,3,5,3,7,9])
		  						.where(function(x){ return x > 1})
		  						.where(function(x){ return x < 5});
		  expect(result.isEqual(new List([2,4,3,3]))).to.be(true);
	    });
  	});
  	describe(".union(<list>)", function(){
  		it("Given an empty list when call union method then returns an empty list", function(){
		  var numbers = new List();
		  var result = numbers.union(new List());
		  expect(result.isEqual(new List())).to.be(true);
	    });
		it("Given a list with numbers when call union method then returns a new list with the union of the elements", function(){
		  var numbers = new List([5,3,7,9]);
		  var result = numbers.union(new List([1,2,3]));
		  expect(result.isEqual(new List([5,3,7,9, 1,2,3]))).to.be(true);
	    });
	    it("Given a list with numbers when call union method then returns a new list with fluent api", function(){
		  var numbers = new List([5,3,7,9]);
		  var result = numbers
		  					.union(new List([1,2,3]))
		  					.union(new List([4,5,6,7]));
		  expect(result.isEqual(new List([5,3,7,9, 1,2,3,4,5,6,7]))).to.be(true);
	    });
	});
	describe(".reverse(<array>)", function(){
		it("Given list  with numbers when call reverse method then returns a new array with the reverse of the elements", function(){
		  var result = new List([5,3,7,9]).reverse();
		  expect(result.isEqual(new List([9,7,3,5]))).to.be(true);
	    });
		it("Given an empty array when call reverse method then returns an empty array", function(){
		  var numbers = new List();
		  var result = numbers.reverse();
		  expect(result.isEqual(new List())).to.be(true);
	    });
	});
	describe(".select(<function>)", function(){
	  it("Given a list  with numbers when call select method then returns a new list with the of the method applied to each element", function(){
		    var numbers = new List([5,3,7,9]);
		    var result = numbers.select(function(x){return x+1;})
		    expect(result.isEqual(new List([6,4,8,10]))).to.be(true);
		});
	});
});