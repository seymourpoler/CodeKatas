
describe("Conseguir Pares de forma recursiva", function () {

    it("Con cero repeticiones", function () {
        var resultado = mayoresParesRecursivos(0,3);
        expect(resultado).toEqual([]);
    })

    it("Con cero una repeticion y numero impar", function () {
        var resultado = mayoresParesRecursivos(1,3);
        expect(resultado).toEqual([2]);
    })

    it("Con repeticion y numero par", function () {
        var resultado = mayoresParesRecursivos(2,6);
        expect(resultado).toEqual([6,4]);
    })

    it("Con repeticion mayor que el numero de partida", function () {
        var resultado = mayoresParesRecursivos(4,3);
        expect(resultado).toEqual([2,0,-2,-4]);
    })
});
