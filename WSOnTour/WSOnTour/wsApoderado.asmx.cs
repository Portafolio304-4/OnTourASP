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
    /// Descripción breve de wsApoderado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsApoderado : System.Web.Services.WebService
    {

        [WebMethod]
        public Apoderado ReadByUsername(string username)
        {
            Apoderado apoderado = new Apoderado();
            apoderado.Rut = username;
            ApoderadoModel query = new ApoderadoModel(apoderado);

            return query.ReadByUsername();
        }

        [WebMethod]
        public List<Curso> GetCursos(string rut)
        {
            Apoderado apoderado = new Apoderado();
            apoderado.Rut = rut;
            ApoderadoModel query = new ApoderadoModel(apoderado);

            return query.GetCursos();
        }

        [WebMethod]
        public List<Alumno> GetAlumnosInCursos(int id_curso, string rut)
        {
            Apoderado apoderado = new Apoderado();
            apoderado.Rut = rut;
            ApoderadoModel query = new ApoderadoModel(apoderado);

            return query.GetAlumnosInCursos(id_curso);
        }

        [WebMethod]
        public Alumno GetAlumnoByRut(string rut_apoderado, string rut_alumno)
        {
            Apoderado apoderado = new Apoderado();
            apoderado.Rut = rut_apoderado;
            ApoderadoModel query = new ApoderadoModel(apoderado);

            return query.GetAlumnoByRut(rut_alumno);
        }
    }
}
