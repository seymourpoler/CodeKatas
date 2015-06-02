using System.Collections.Generic;

namespace Peaje
{
    public class Peajemanager
    {
        private List<IVehiculo> _colaDeEspera;
        private int _recaudacion;
        private const int IMPUESTO = 2;

        public Peajemanager()
        {
            _colaDeEspera = new List<IVehiculo>();
            _recaudacion = 0;
        }

        public void RecibirVehiculo(IVehiculo vehiculo)
        {
            _recaudacion = +_recaudacion + vehiculo.PagarPeaje(IMPUESTO);
        }

        private void PonerEnEspera(IVehiculo vehiculo)
        {
            _colaDeEspera = vehiculo.PonerEnEspera(_colaDeEspera);
        }
    }
}
