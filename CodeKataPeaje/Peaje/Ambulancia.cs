using System.Collections.Generic;

namespace Peaje
{
    public class Ambulancia : IVehiculo
    {
        public int PagarPeaje(int impuesto)
        {
            return 0;
        }

        public List<IVehiculo> PonerEnEspera(List<IVehiculo> espera)
        {
            espera.Insert(0, this);
            return espera;
        }
    }
}
