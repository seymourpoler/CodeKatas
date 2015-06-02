using System.Collections.Generic;

namespace Peaje
{
    public class Coche : IVehiculo
    {
        public int NumeroPersonas { get; set; }

        public int PagarPeaje(int impuesto)
        {
            return NumeroPersonas*impuesto;
        }

        public List<IVehiculo> PonerEnEspera(List<IVehiculo> espera)
        {
            espera.Add(this);
            return espera;
        }
    }
}
