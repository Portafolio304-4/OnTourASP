using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSOnTour.DTOs;
using WSOnTour.Logica.Model;

namespace WSOnTour
{
    /// <summary>
    /// Descripción breve de wsActividadPago
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsActividadPago : System.Web.Services.WebService
    {

        [WebMethod]
        public bool CreatePaid(string descripcion, int monto, int id_curso, DateTime fecha)
        {
            ActividadPago pago = new ActividadPago();
            pago.Descripcion = descripcion;
            pago.Monto = monto;
            pago.Id_curso = id_curso;
            pago.Fecha = DateTime.Now;
            ActividadPagoModel query = new ActividadPagoModel(pago);

            return query.CreatePaid();
        }

        [WebMethod]
        public List<ResumenActividadPago> GetAllByCurso(int id_curso)
        {
            ActividadPago pago = new ActividadPago();
            pago.Id_curso = id_curso;
            pago.Fecha = DateTime.Now;
            ActividadPagoModel query = new ActividadPagoModel(pago);

            return query.GetAllByCurso();
        }
    }
}
