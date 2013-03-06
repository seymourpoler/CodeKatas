
using System;
using System.Web.UI;
using System.Collections.Generic;
using Microsoft.SharePoint;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Entidades;
using Representacion;

namespace Web.ControlTemplates
{
    public partial class SeguimientoMensualDeIndicadores : UserControl, ISeguimientoMensualDeIndicadoresVista
    {
        private GestorExcepciones _gestorDeError;
        private SeguimientoMensualDeIndicadoresPresentador _presentador = null;
        protected SeguimientoMensualDeIndicadoresPresentador Presentador
        {
            get
            {
                if (_presentador == null)
                {
                    _presentador = new SeguimientoMensualDeIndicadoresPresentador(this);
                }

                return _presentador;
            }
        }
        public string Anio { get; set; }
        public string Mes { get; set; }
        public string Url { get { return SPContext.Current.Web.Url; } }
        public string EtiquetaInformacion { set { lblInfo.Text = value; } }

        public ListGeneric<EvolucionMensualParaPintar> DatosSeguimientoMensualDeIndicadores
        {
            set
            {
                Response.ContentType = "application/json";
                Response.Write(value.ToJsonWithOptimization());
                Response.End();
            }
        }

        public ListGeneric<string> DistintosAniosDeLosSeguimientosMensualesDeLosIndicadores
        {
            set
            {
                Response.ContentType = "application/json";
                Response.Write(value.ToJSON());
                Response.End();
            }
        }

        public string UltimoMesDeLosSeguimientosMensualesDeLosIndicadores
        {
            set
            {
                Response.ContentType = "application/json";
                Response.Write(value.ToJSON());
                Response.End();
            }
        }

        public SeguimientoMensualDeIndicadores()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string accion = Request["accion"];
                switch (accion)
                {
                    case "Buscar":
                        Buscar();
                    break;
                    case "CargarAnios":
                        CargarAnios();
                    break;
                    case "CargarMes":
                        CargarMes();
                    break;
                    case "CargarTodosLosDatos":
                        CagarTodosLosDatos();
                    break;
                }
            }
            catch (System.Threading.ThreadAbortException th) { }
            catch (Exception ex)
            {
                Presentador.PintarError();
                _gestorDeError.TratarExcepcion(ex,
                                                   "Fallo en la carga de la página",
                                                   "Page_Load");
            }
        }

        private void Buscar()
        {
            try
            {
                string mes  = Request["mes"];
                string anio = Request["anio"];
                Presentador.CargarDatosPorMesAnio(new EvolucionMensual() { Mes = mes, Anio = anio });
            }
            catch (System.Threading.ThreadAbortException th) { }
            catch (Exception ex)
            {
                _gestorDeError.TratarExcepcion(ex,
                                                   ex.ToString(),
                                                   "Buscar");
            }
        }

        private void CargarAnios()
        {
            try
            {
                Presentador.CargarAnios();
            }
            catch (System.Threading.ThreadAbortException th) { }
            catch (Exception ex)
            {
                _gestorDeError.TratarExcepcion(ex,
                                                   " Error En la carga de los años de las evoluciones mensuales de los indicadores",
                                                   "CargarAnio");
            }
        }

        private void CargarMes()
        {
            try
            {
                var anio = Request["anioSeleccionado"];
                Presentador.SelecionarMesEnFuncionDelAnio(new EvolucionMensual { Anio = anio});
            }
            catch (System.Threading.ThreadAbortException th) { }
            catch (Exception ex)
            {
                _gestorDeError.TratarExcepcion(ex,
                                                   "En la carga del último mes de las evoluciones mensuales de los indicadores",
                                                   "CargarMes");
            }
        }

        private void CagarTodosLosDatos() 
        {
            try
            {
                Presentador.CargarTodosLosDatos();
            }
            catch (System.Threading.ThreadAbortException th) { }
            catch (Exception ex)
            {
                _gestorDeError.TratarExcepcion(ex,
                                                   "En la carga de las evoluciones mensuales de los indicadores",
                                                   "CagarTodosLosDatos");
            }
        }
    }
}
