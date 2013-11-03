describe("Test para la Lista de Palindromos ", function () {
    
    it("lista vacia", function () {
        var resultado = sonPalindromos([]);    
        expect(resultado).toEqual(false);
    });

    it("lista con un solo elemento", function () {
        var resultado = sonPalindromos(['uno']);    
        expect(resultado).toEqual(false);
    });

    it("lista con un elemento palindromo", function () {
        var resultado = sonPalindromos(['uno', 'uno']);    
        expect(resultado).toEqual(true);
    });

    it("lista con un elemento palindromo con elementos impares", function () {
        var resultado = sonPalindromos(['uno', 'dos', 'uno']);    
        expect(resultado).toEqual(true);
    });

    it("lista con un elemento no palindromo con elementos pares", function () {
        var resultado = sonPalindromos(['uno', 'dos', 'tres', 'dos']);    
        expect(resultado).toEqual(false);
    });

    it("lista con un elemento no palindromo con elementos impares", function () {
        var resultado = sonPalindromos(['uno', 'dos', 'tres']);    
        expect(resultado).toEqual(false);
    });
});
