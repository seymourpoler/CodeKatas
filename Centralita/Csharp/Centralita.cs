

/*
 *  Desarrollar una aplicación de control de llamadas realizadas en una centralita telefónica.
    En la centralita se van registrando llamadas. Registrar una llamada consiste en contabilizar el número de llamadas realizadas así como el coste total de todas las llamadas realizadas.
    La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
    Existen dos tipos de llamadas:
        • Las llamadas locales que cuestan 15 céntimos el segundo.
        • Y las llamadas provinciales que dependiendo de la franja horaria en la que se realicen cuestan: 20 céntimos en franja 1, 25 céntimos en franja 2 y 30 céntimos en franja 3, cada segundo.

    Todas las llamadas tienen como datos el número origen de la llamada, el número destino y su duración en segundos.
    Desarrollar la clase Centralita que en su método main cree una centralita, registre varias llamadas de distinto tipo y le pida a la centralita un informe con el número total de llamadas y la facturación total realizada. 
 */


using System.Collections.Generic;

namespace CodeKataCentralita
{
    public class Centralita
    {
        private List<Llamada> _llamadasRegistradas;

        public Centralita()
        {
            _llamadasRegistradas = new List<Llamada>();
        }

        public void Registrar(Llamada llamada)
        {
            _llamadasRegistradas.Add(llamada);
        }

        public IList<Llamada> ConseguirLlamadasRegistradas()
        {
            return _llamadasRegistradas;
        }

        public double ConseguirCosteTotalDeLasLlamadas()
        {
            double resultado = 0;

            foreach (Llamada llamada in _llamadasRegistradas)
            {
                resultado += llamada.ConseguirCosteDeLaLlamada();
            }

            return resultado;
        }
    }
}
