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
    /// Descripción breve de wsColegio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsColegio : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Colegio> ReadAllNamesAndIds()
        {
            List<Colegio> colegios = new List<Colegio>();
            ColegioModel query = new ColegioModel(new Colegio());
            colegios = query.Read();

            return colegios;
        }
    }
}
