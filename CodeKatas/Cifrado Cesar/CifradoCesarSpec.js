
describe("Comprobando el cifrado Cesar", function () {

    it("Cifrando un texto vacio", function () {
        var resultado = cifrar('', 9);
        expect(resultado).toEqual('');
    })

    it("Cifrando un texto simple, con 3 desplazamientos", function () {
        var resultado = cifrar('abc', 3);
        expect(resultado).toEqual('def');
    })

    it("Cifrando con mayúsculas", function () {
        var resultado = cifrar('ABC', 5);
        expect(resultado).toEqual('FGH');
    })
    
    it("Cifrando con mayúsculas", function () {
        var resultado = cifrar('AcC1?', 2);
        expect(resultado).toEqual('CeE1?');
    })
});
