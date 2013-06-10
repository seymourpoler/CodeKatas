describe("StringBuilder", function () {
    
    describe("StringBuilder Constructor", function () {
        it("Empty Constructor", function(){
            var stringBuilder =  new StringBuilder('');
            expect(stringBuilder.toString()).toEqual('');
        });

        it("Constructor with some value", function () {
            var value = 'value';
            var stringBuilder =  new StringBuilder(value);
            expect(stringBuilder.toString()).toEqual(value);
        });

    });

    describe("Funcionatity", function(){
        it("Append only a value", function () {
            var value = 'value';
            var stringBuilder =  new StringBuilder('');
            stringBuilder.append(value);
            expect(stringBuilder.toString()).toEqual(value);
        });

        it("Append two values", function () {
            var valueOne  = 'valueOne';
            var valueTwo = 'valueTwo';
            var stringBuilder =  new StringBuilder('');
            stringBuilder.append(valueOne);
            stringBuilder.append(valueTwo);
            expect(stringBuilder.toString()).toEqual(valueOne + valueTwo);
        });        

        it("Append three values", function () {
            var valueOne  = 'valueOne';
            var valueTwo = 'valueTwo';
            var valueThree = 'valueThree';
            var stringBuilder =  new StringBuilder('');
            stringBuilder.append(valueOne);
            stringBuilder.append(valueTwo);
            stringBuilder.append(valueThree);
            expect(stringBuilder.toString()).toEqual(valueOne + valueTwo + valueThree);
        });  

        it("Clear values", function () {
            var valueOne  = 'valueOne';
            var valueTwo = 'valueTwo';
            var valueThree = 'valueThree';
            var stringBuilder =  new StringBuilder('');
            stringBuilder.append(valueOne);
            stringBuilder.append(valueTwo);
            stringBuilder.append(valueThree);
            stringBuilder.clear();
            expect(stringBuilder.toString()).toEqual('');
        });        
    });
});
