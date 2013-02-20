
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Reflection;

namespace Entidades.Utilidades
{
    public class ListGeneric<T> : List<T>, IEnumerable<T>
    {
        public string ToJSON()
        {
            var  jsonSerializer = new JavaScriptSerializer();
            return jsonSerializer.Serialize(this);
        }

        public string ToJsonWithOptimization()
        {
            var resultado = string.Empty;
            var datos = ConseguirDatos();
            resultado = SerializarDatos(datos);
            return resultado;
        }

        private List<List<string>> ConseguirDatos()
        {
            var resultado = new List<List<String>>();
            List<string> fila;

            foreach (T elemento in this)
            {
                fila = ConseguirValoresDelObjeto(elemento);
                resultado.Add(fila);
            }

            return resultado;
        }

        private List<string> ConseguirValoresDelObjeto(T objeto)
        {
            var resultado = new List<string>();

            var valor = string.Empty;
            if (objeto.GetType().IsSealed)
            {
                resultado.Add(objeto.ToString());
            }
            else
            {
                foreach (var info in objeto.GetType().GetProperties())
                {
                    valor = ConseguirValorDeLaPropiedad(info, objeto);
                    resultado.Add(valor);
                }
            }
            return resultado;
        }

        private string ConseguirValorDeLaPropiedad(PropertyInfo propiedadInfo, T elemento)
        {
            var resultado = string.Empty;

            if (propiedadInfo.CanRead)
            {
                object objeto = propiedadInfo.GetValue(elemento, null);
                if (objeto != null)
                {
                    resultado = objeto.ToString();
                }
            }

            return resultado;
        }

        private string SerializarDatos(List<List<string>> datos)
        {
            var resultado = string.Empty;
            var jsonSerializer = new JavaScriptSerializer();
            resultado = jsonSerializer.Serialize(datos);
            return resultado;
        }

    }
}
