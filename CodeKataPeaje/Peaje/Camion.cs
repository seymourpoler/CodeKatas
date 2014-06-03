using System.Collections.Generic;

namespace Peaje
{
    public class Camion : IVehiculo
    {
        public int Toneladas { get; set; }

        public int PagarPeaje(int impuesto)
        {
            return impuesto*Toneladas;
        }

        public List<IVehiculo> PonerEnEspera(List<IVehiculo> espera)
        {
            espera.Add(this);
            return espera;
        }
    }
}
