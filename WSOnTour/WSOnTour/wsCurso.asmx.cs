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
    /// Descripción breve de wsCurso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCurso : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Curso> ReadAllByColegio(int id)
        {
            Curso curso = new Curso();
            curso.Id_colegio = id;
            List<Curso> cursos = new List<Curso>();
            CursoModel query = new CursoModel(curso);
            cursos = query.Read();
            return cursos;
        }

        [WebMethod]
        public bool VerifyApoderadoInCurso(int id, string rut)
        {
            Curso curso = new Curso();
            curso.Id = id;
            CursoModel query = new CursoModel(curso);
            return query.VerifyApoderadoInCurso(rut);
        }
    }
}
