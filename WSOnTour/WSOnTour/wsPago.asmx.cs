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
    /// Descripción breve de wsPago
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPago : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Pago> GetAllByAlumno()
        {
            return null;
        }

        [WebMethod]
        public List<Pago> GetAllByCurso()
        {
            return null;
        }

        [WebMethod]
        public List<ResumenPago> GetAllByApoderado(string rut_apoderado)
        {
            Pago pago = new Pago();
            PagoModel query = new PagoModel(pago);
            return query.GetAllByApoderado(rut_apoderado);
        }

        [WebMethod]
        public bool CreateSinglePaid(int abono, string rut_alumno, int id_tipo_pago)
        {
            Pago pago = new Pago();
            pago.Abono = abono;
            pago.Rut_alumno = rut_alumno;
            pago.Id_pago = id_tipo_pago;
            pago.Fecha = DateTime.Now;
            PagoModel query = new PagoModel(pago);

            return query.CreatePaid();
        }

        [WebMethod]
        public bool CreateActivityPaid()
        {
            return false;
        }


    }
}
