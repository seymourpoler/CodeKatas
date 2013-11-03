
namespace CodeKataCentralita
{
    public abstract class Llamada
    {
        public string NumeroOrigen{ get; set; }
        public string NumeroOrigenDestino{ get; set; }
        public int Duracion { get; set; }

        private double coste = 0.15;

        public virtual double ConseguirCosteDeLaLlamada() 
        {
            return Duracion * coste;
        }
    }
}
