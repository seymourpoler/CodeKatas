
using System;

namespace CodeKataCentralita
{
    public class LlamadaProvincial : Llamada
    {
        public Franjas Franja { get; set; }
        public LlamadaProvincial()
        {
            Franja = Franjas.Uno;
            Duracion = 0;
        }
        public override double ConseguirCosteDeLaLlamada()
        {
            switch (Franja)
            {
                case Franjas.Uno:
                    return Duracion * 0.2;
                case Franjas.Dos:
                    return Duracion * 0.25;
                case Franjas.Tres:
                    return Duracion * 0.30;
                default: throw new Exception("Franja horaria desconocida");
            }
        }
    }
}
