
using NUnit.Core;
using NUnit.Framework;

namespace CodeKataCentralita
{
    [TestFixture] 
    public class CentralitaTest
    {
        private const double costeLlamadaLocal = 0.15;
        private Centralita _centralita;

        [SetUp]
        public void SetUpEachTest()
        {
            _centralita = new Centralita();
        }

        [TearDown]
        public void TearDownEachDown()
        {
            _centralita = null;
        }

        [Test]
        public void Grabar_Una_Llamada_Cuaquiera()
        {
            var llamadaLocal = new LlamadaLocal();
            _centralita.Registrar(llamadaLocal);

            var llamadasRegistradas = _centralita.ConseguirLlamadasRegistradas();
            Assert.AreEqual(1, llamadasRegistradas.Count);
        }

        [Test]
        public void Grabar_Una_Llamada_Local()
        {
            var duracionLlamada = 12;
            var llamadaLocal = new LlamadaLocal();
            llamadaLocal.Duracion = duracionLlamada;
            _centralita.Registrar(llamadaLocal);

            Assert.AreEqual(duracionLlamada * costeLlamadaLocal, _centralita.ConseguirCosteTotalDeLasLlamadas());
        }

        [Test]
        public void Grabar_Una_Llamada_Provincial_En_Franja_Uno()
        {
            var duracionLlamada = 14;
            var llamadaProvincial = new LlamadaProvincial();
            llamadaProvincial.Franja = Franjas.Uno;
            llamadaProvincial.Duracion = duracionLlamada;

            _centralita.Registrar(llamadaProvincial);

            var llamadasRegistradas = _centralita.ConseguirLlamadasRegistradas();

            Assert.AreEqual(duracionLlamada * 0.2, llamadasRegistradas[0].ConseguirCosteDeLaLlamada());
        }

        [Test]
        public void Grabar_Una_Llamada_Provincial_En_Franja_Dos()
        {
            var duracionLlamada = 18;
            var llamadaProvincial = new LlamadaProvincial();
            llamadaProvincial.Franja = Franjas.Dos;
            llamadaProvincial.Duracion = duracionLlamada;

            _centralita.Registrar(llamadaProvincial);

            var llamadasRegistradas = _centralita.ConseguirLlamadasRegistradas();

            Assert.AreEqual(duracionLlamada * 0.25, _centralita.ConseguirCosteTotalDeLasLlamadas());
        }

        [Test]
        public void Grabar_Una_Llamada_Provincial_Con_Otra_Llamada_Local()
        {
            var duracionLlamadaLocal = 18;
            var llamadaLocal = new LlamadaLocal();
            llamadaLocal.Duracion = duracionLlamadaLocal;
            _centralita.Registrar(llamadaLocal);

            var duracionLlamadaProvincial = 15;
            var llamadaProvincial = new LlamadaProvincial();
            llamadaProvincial.Franja = Franjas.Dos;
            llamadaProvincial.Duracion = duracionLlamadaProvincial;
            _centralita.Registrar(llamadaProvincial);

            var llamadasRegistradas = _centralita.ConseguirLlamadasRegistradas();

            var costeTotal = (duracionLlamadaProvincial * 0.25) + (duracionLlamadaLocal * costeLlamadaLocal);

            Assert.AreEqual(costeTotal, _centralita.ConseguirCosteTotalDeLasLlamadas());
        }

        [Test]
        public void Grabar_Dos_Llamadas_Provinciales_Con_Distintas_Franjas_Con_Otras_Dos_Llamadas_Locales()
        {
            var duracionLlamadaLocal = 18;
            var llamadaLocal = new LlamadaLocal();
            llamadaLocal.Duracion = duracionLlamadaLocal;
            _centralita.Registrar(llamadaLocal);

            var duracionLlamadaProvincial = 15;
            var llamadaProvincial = new LlamadaProvincial();
            llamadaProvincial.Franja = Franjas.Dos;
            llamadaProvincial.Duracion = duracionLlamadaProvincial;
            _centralita.Registrar(llamadaProvincial);

            var llamadasRegistradas = _centralita.ConseguirLlamadasRegistradas();

            var costeTotal = (duracionLlamadaProvincial * 0.25) + (duracionLlamadaLocal * costeLlamadaLocal);

            Assert.AreEqual(costeTotal, _centralita.ConseguirCosteTotalDeLasLlamadas());
        }
    }
}
