using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class estadoCuenta : System.Web.UI.Page
    {
        wsApoderado.wsApoderadoSoapClient cliente_apoderado = new wsApoderado.wsApoderadoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                wsUsuario.Usuario user = (wsUsuario.Usuario)Session["usuario"];
                wsApoderado.Apoderado apoderado = cliente_apoderado.ReadByUsername(user.User_name);
                if (apoderado.Rut == "")
                {
                }
                else
                {
                    Session["apoderado"] = apoderado;
                    loadDropCurso(user.User_name);
                }
            }

        }

        public void loadDropCurso(string username)
        {
            this.dropCurso.Items.Clear();

            ListItem first_element = new ListItem("Seleccione un Curso", "-1");
            this.dropCurso.Items.Add(first_element);
            wsApoderado.Apoderado apoderado = (wsApoderado.Apoderado)Session["apoderado"];
            wsApoderado.Curso[] cursos = this.cliente_apoderado.GetCursos(apoderado.Rut);
            foreach (wsApoderado.Curso curso in cursos)
            {
                ListItem item = new ListItem(curso.Nivel + " " + curso.Grado + curso.Letra, curso.Id.ToString());
                this.dropCurso.Items.Add(item);

            }


        }
        public void loadDropRutAlumno(int id_curso, string rut)
        {
            this.dropRutAlumno.Items.Clear();

            ListItem first_element = new ListItem("Seleccione un Alumno", "-1");
            this.dropRutAlumno.Items.Add(first_element);

            wsApoderado.Alumno[] alumnos = cliente_apoderado.GetAlumnosInCursos(id_curso, rut);

            foreach (wsApoderado.Alumno alumno in alumnos)
            {
                ListItem item = new ListItem(alumno.Rut, alumno.Rut);
                this.dropRutAlumno.Items.Add(item);

            }
        }

        protected void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            string rut_alumno = this.dropRutAlumno.SelectedValue;
            int id_curso = int.Parse(this.dropCurso.SelectedValue);
            wsEstadoCuenta.wsEstadoCuentaSoapClient client_ec = new wsEstadoCuenta.wsEstadoCuentaSoapClient();
            int total_pagado = client_ec.GetTotalPagado(rut_alumno, id_curso);
            int total_deuda_alumno = client_ec.GetDeudaAlumno(id_curso);
            int total_deuda = client_ec.GetDeudaTotal(id_curso);


        }

        protected void dropCurso_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (this.dropCurso.SelectedValue == "-1")
            {
            }
            else
            {
                wsApoderado.Apoderado apoderado = (wsApoderado.Apoderado)Session["apoderado"];
                this.loadDropRutAlumno(int.Parse(dropCurso.SelectedValue), apoderado.Rut);
            }

        }
    }
}