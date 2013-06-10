
describe("Simplificar Palabras", function () {
    var resultado = '';

    it("Simplificar un texto vacio", function () {
        var texto = new Texto('');
        resultado = texto.simplificar();
        expect(resultado).toEqual('');
    })

    it("Simplificar una letra minúscula", function () {
        var texto = new Texto('a');
        resultado = texto.simplificar();
        expect(resultado).toEqual('A');
    })

    it("Simplificar dos letras minúsculas", function () {
        var texto = new Texto('ab');
        resultado = texto.simplificar();
        expect(resultado).toEqual('AB');
    })

    it("Simplificar una palabra", function () {
        var texto = new Texto('Salida');
        resultado = texto.simplificar();
        expect(resultado).toEqual('SALIDA');
    })
    
    it("Simplificar una palabra con simbolos diacriticos", function () {
        var texto = new Texto('Cigüeña');
        resultado = texto.simplificar();
        expect(resultado).toEqual('CIGUENA');
    })
});
