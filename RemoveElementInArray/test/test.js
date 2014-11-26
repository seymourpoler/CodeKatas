var sut = require("../source/sut.js"),
 expect = require("expect.js");

describe("Remove a number in an array thought functional way using TDD", function(){
  it("Given empty array then return empty array", function(){
    expect(sut.remove(2, [])).to.eql([]);
  });
  
  it("Given array with one element and 0 positions then return the same array", function(){
    expect(sut.remove(2, [2])).to.eql([]);
  });
  it("Given array with two numbers and number then return array without the number in the array", function(){
    expect(sut.remove(1, [1,2])).to.eql([2]);
  });
  it("Given array and positions then return rotated array without the number", function(){
    expect(sut.remove(3, [1,2,3,4])).to.eql([1,2,4]);
  });

});