
describe("StringReverse", function () {
    describe("Funcionatity", function(){

        it("Reverse two characters", function () {
            var value = 'va';
            expect(value.reverse()).toEqual('av');
        });

        it("Reverse three characters", function () {
            var value = 'val';
            expect(value.reverse()).toEqual('lav');
        });

        it("Reverse number with three digits", function () {
            var value = '123';
            expect(value.reverse()).toEqual('321');
        });

        it("Reverse complex line text", function () {
            var value = 'q1w2e3r4t5y6u7i8o9p0';
            expect(value.reverse()).toEqual('0p9o8i7u6y5t4r3e2w1q');
        });
    });
});
