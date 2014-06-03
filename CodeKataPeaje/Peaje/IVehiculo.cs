using System.Collections.Generic;

namespace Peaje
{
    public interface IVehiculo
    {
        int PagarPeaje(int impuesto);
        List<IVehiculo> PonerEnEspera(List<IVehiculo>);
    }
}
