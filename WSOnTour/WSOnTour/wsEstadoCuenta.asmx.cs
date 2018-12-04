using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSOnTour.Logica.Model;

namespace WSOnTour
{
    /// <summary>
    /// Descripción breve de wsEstadoCuenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEstadoCuenta : System.Web.Services.WebService
    {

        [WebMethod]
        public int GetTotalPagado(string rut, int curso)
        {
            EstadoCuentaModel ec = new EstadoCuentaModel();
            return ec.EstadoCuentaPago(rut, curso);
        }

        [WebMethod]
        public int GetDeudaTotal(int curso)
        {
            EstadoCuentaModel ec = new EstadoCuentaModel();
            return ec.EstadoCuentaDeudaPaquete(curso);
        }

        [WebMethod]
        public int GetDeudaAlumno(int curso)
        {
            EstadoCuentaModel ec = new EstadoCuentaModel();
            return ec.EstadoCuentaDeudaAlumno(curso);
        }
    }
}
