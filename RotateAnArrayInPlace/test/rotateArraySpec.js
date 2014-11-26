var sut = require("../src/rotateArray.js"),
 expect = require("expect.js");

describe("Kata Rotate Array using TDD", function(){
  it("Given empty array then return empty array", function(){
    expect(sut.rotate(3, [])).to.be.an('array');
  });
  it("Given array with one element and 0 positions then return the same array", function(){
    expect(sut.rotate(0, [2,3,4])).to.eql([2,3,4]);
  });
  it("Given array and position then return rotated array", function(){
    expect(sut.rotate(1, [1,2])).to.eql([2,1]);
  });
  it("Given array and positions then return rotated array", function(){
    expect(sut.rotate(3, [1,2,3,4])).to.eql([4,1,2,3]);
  });
});