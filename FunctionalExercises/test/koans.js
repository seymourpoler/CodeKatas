
 var sut = require("../src/sut.js"),
 expect = require("expect.js");
/*
describe('Tutorial examples', function(){
    it.skip('Identity function returns its argument untouched', function(){
        expect(42).to.be.equal(identity(42));
    });

    it.skip('`compose` composes two functions together', function(){
        expect(add1(1)).to.be.equal(2);
        expect(mul2(3)).to.be.equal(6);
        var mul2add1 = compose(add1, mul2);
        expect(mul2add1(3)).to.be.equal(7);
    });

    it.skip('`flip` flips the arguments of a function', function (){
        var argsAsArr = (...args) => args;

        expect(argsAsArr(1, 2, 3)).to.be.eql([1, 2, 3]);

        var reverseArgsAsArr = flip(argsAsArr);
        expect(reverseArgsAsArr(1, 2, 3)).to.be.eql([3, 2, 1]);
    });

    it.skip('`complement` complements a predicate', function (){
        var isEven = (x) => x % 2 === 0;

        expect(isEven(2)).to.be.true;
        expect(isEven(3)).to.be.false;

        var isOdd = complement(isEven);
        expect(isOdd(2)).to.be.false;
        expect(isOdd(3)).to.be.true;
    });
});


describe('Function composition', function(){
    it.skip('Improve ~compose~ so the function it generates can take multiple arguments', function(){
        var argsAsArr = (...args) => args;
        var length = (xs) => xs.length;

        betterCompose = () => null;

        expect(betterCompose(length, argsAsArr)(1, 2)).to.be.equal(2);
    });

    it.skip('Write a variadic version of ~compose~', function(){
        var add1 = (x) => x + 1;

        composeAll = () => null;

        expect(composeAll(add1, add1, add1)(0)).to.be.equal(3);
    });
});
*/
describe('Higher order functions', function(){
    it('Write a function that, given a number, returns a function that takes a number and adds it to the first', function(){
        expect(sut.adder(3)(4)).to.be.equal(7);
    });

    it.skip('Write the same function for the multiplication operation', function(){
        expect(sut.multiplier(3)(4)).to.be.equal(12);
        expect(sut.multiplier(2)(4)).to.be.equal(8);
    });
    /*
    it.skip('Write a function that, given a function, returns another function that calls to original one with all but the last argument', function(){
        var argLength = (...args) => args.length;
        var callWithAllButLast = () => null;

        expect(callWithAllButLast(argLength)(1, 2, 3)).to.be.equal(2);
    });
    */
});

/*
describe('Recursion', function(){
    it.skip('Write a recursive function that, given a value and a list, returns a list with the first occurrence of the value removed', function() {
        rember = () => null;

        expect(rember(4, [1, 2, 3])).to.be.eql([1, 2, 3]);
        expect(rember(1, [1, 2, 3])).to.be.eql([2, 3]);
        expect(rember(2, [1, 2, 3])).to.be.eql([1, 3]);
        expect(rember(3, [1, 2, 3])).to.be.eql([1, 2]);
    });

    it.skip('Write the same function in accumulator-passing style', function(){
        rember = () => null;

        expect(rember(4, [1, 2, 3])).to.be.eql([1, 2, 3]);
        expect(rember(1, [1, 2, 3])).to.be.eql([2, 3]);
        expect(rember(2, [1, 2, 3])).to.be.eql([1, 3]);
        expect(rember(3, [1, 2, 3])).to.be.eql([1, 2]);

    });
});

describe('Internal & External iteration', function(){
    it.skip('Write your own version of ~map~, ~filter~ and ~reduce~ (you are allowed to use ~for~ loops and mutation)', function(){
        map = () => null;
        filter = () => null;
        reduce = () => null;

        expect(map((x) => x + 1, [0, 1, 2])).to.be.eql([1, 2, 3]);
        expect(filter((x) => x % 2 === 0, [1, 2, 3, 4, 5])).to.be.eql([1, 3, 5]);
        expect(reduce((x, y) => x + y, [1, 2, 3])).to.be.equal(6);
    });
});

describe('Currying & Partial Application', function(){
    it.skip('autoCurry', function() {
        autoCurry = () => null;
        curriedSum3 = autoCurry(function(x, y, z) { return x + y + z; });

        expect(curriedSum3(1)(2)(3)).to.be.equal(6);
        expect(curriedSum3(1)(2, 3)).to.be.equal(6);
        expect(curriedSum3(1, 2, 3)).to.be.equal(6);
        expect(curriedSum3()(1, 2)(3)).to.be.equal(6);
    });
});
*/