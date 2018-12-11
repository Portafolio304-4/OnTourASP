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
    /// Descripción breve de wsContrato
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsContrato : System.Web.Services.WebService
    {

        [WebMethod]
        public Contrato traerUnContrato(int id_curso)
        {
            Contrato contrato = new Contrato();

            contrato.Id_curso = id_curso;
            ContratoModel query = new ContratoModel(contrato);

            return query.TraerContrato(id_curso);
        }


        [WebMethod]
        public List<Contrato> GetContratos(int id_curso)
        {
            Contrato contrato = new Contrato();

            contrato.Id_curso = id_curso;
            ContratoModel query = new ContratoModel(contrato);

            return query.GetContratos(id_curso);
        }
    }
}