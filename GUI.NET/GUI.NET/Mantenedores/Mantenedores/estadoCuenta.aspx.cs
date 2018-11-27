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
                    loadDropColegio();

                }
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
        public void loadDropCurso(int id_colegio)
        {
            this.dropCurso.Items.Clear();

            ListItem first_element = new ListItem("Seleccione un Curso", "-1");
            this.dropCurso.Items.Add(first_element);
            wsApoderado.Apoderado apoderado = (wsApoderado.Apoderado)Session["apoderado"];
            wsApoderado.Curso[] cursos = this.cliente_apoderado.GetCursosByColegio(apoderado.Rut, id_colegio);
            foreach (wsApoderado.Curso curso in cursos)
            {
                ListItem item = new ListItem(curso.Nivel + " " + curso.Grado + curso.Letra, curso.Id.ToString());
                this.dropCurso.Items.Add(item);

            }


        }

        private void loadDropColegio()
        {
            this.DropColegio.Items.Clear();
            ListItem first_element = new ListItem("Seleccione un Colegio", "-1");
            this.DropColegio.Items.Add(first_element);

            wsColegio.wsColegioSoapClient client_colegio = new wsColegio.wsColegioSoapClient();
            wsColegio.Colegio[] colegios = client_colegio.ReadAllNamesAndIds();

            foreach (wsColegio.Colegio colegio in colegios)
            {
                ListItem item = new ListItem(colegio.Nombre, colegio.Id.ToString());
                this.DropColegio.Items.Add(item);

            }
        }
        protected void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            string rut_alumno = this.dropRutAlumno.SelectedValue;
            int id_curso = int.Parse(this.dropCurso.SelectedValue);
            wsEstadoCuenta.wsEstadoCuentaSoapClient client_ec = new wsEstadoCuenta.wsEstadoCuentaSoapClient();
            client_ec.GetTotalPagado(rut_alumno, id_curso);

        }

        protected void DropColegio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DropColegio.SelectedItem.Value == "-1")
            {
                dropCurso.Items.Clear();
            }
            else
            {
                dropCurso.Items.Add(new ListItem("Cargando cursos......"));
                int id_colegio = int.Parse(this.DropColegio.SelectedItem.Value);
                this.loadDropCurso(id_colegio);
            }

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