describe("Kata Potencia de Dos", function () {
    
    describe("Calculando la potencia de dos", function () {
        it("Con cero", function(){
            var resultado = PotenciaDeDos(0);
            expect(resultado).toEqual(1);
        });
        it("Con mas de 256", function(){
            var resultado = PotenciaDeDos(256);
            expect(resultado).toEqual(0);
        });
        it("Con menos de 10", function(){
            var resultado = PotenciaDeDos(4);
            expect(resultado).toEqual(16);
        });
    });

});
