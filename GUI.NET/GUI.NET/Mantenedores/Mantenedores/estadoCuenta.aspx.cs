using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class estadoCuenta : System.Web.UI.Page
    {
        wsApoderado.wsApoderadoSoapClient cliente_apoderado = new wsApoderado.wsApoderadoSoapClient();
        wsPago.wsPagoSoapClient cliente_pago = new wsPago.wsPagoSoapClient();
        wsActividadPago.wsActividadPagoSoapClient cliente_actividad_pago = new wsActividadPago.wsActividadPagoSoapClient();
        wsCurso.wsCursoSoapClient cliente_curso = new wsCurso.wsCursoSoapClient();
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
                if (!dropCurso.Items.Contains(item))
                {
                    this.dropCurso.Items.Add(item);
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

        protected void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            int id_curso = int.Parse(this.dropCurso.SelectedValue);
            string rut_alumno = this.dropRutAlumno.SelectedValue;
            if (id_curso == -1 || rut_alumno == "-1")
            {
                lblResultado.Text = "Debe seleccionar un curso y un alumno";
                lblDeudaTotalAlumno.Visible = false;
                lblTotalPagadoAlumno.Visible = false;
                lblTotalPorPagarAlumno.Visible = false;

                lblResumenActividades.Visible = false;
                gvActividadesAlumno.Visible = false;
                lblInfo.Visible = false;

                lblResumenPagos.Visible = false;
                gvPagoAlumno.Visible = false;
            }
            else
            {
                wsEstadoCuenta.wsEstadoCuentaSoapClient client_ec = new wsEstadoCuenta.wsEstadoCuentaSoapClient();
                int total_pagado_alumno = client_ec.GetTotalPagado(rut_alumno, id_curso);
                int total_deuda_alumno = client_ec.GetDeudaAlumno(id_curso);
                int total_deuda_curso = client_ec.GetDeudaTotal(id_curso);

                lblDeudaTotalAlumno.Text = "Deuda Total Alumno: $" + total_deuda_alumno.ToString();
                lblTotalPagadoAlumno.Text = "Total Cancelado: $" + total_pagado_alumno.ToString();
                lblTotalPorPagarAlumno.Text = "Total Por Pagar: $" + (total_deuda_alumno - total_pagado_alumno).ToString();

                lblDeudaTotalAlumno.Visible = true;
                lblTotalPagadoAlumno.Visible = true;
                lblTotalPorPagarAlumno.Visible = true;

                LoadGridPagosAlumno(rut_alumno);
                LoadGridHistoricoActividades(id_curso);
                lblResultado.Text = "Estado de cuenta generado con exito!!";


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

        private void LoadGridPagosAlumno(string rut_alumno)
        {
            lblResumenPagos.Visible = true;
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Monto", typeof(int));

            wsPago.ResumenPago[] pagos = cliente_pago.GetAllByAlumno(rut_alumno);

            foreach (wsPago.ResumenPago resumen in pagos)
            {
                DataRow dr = dt.NewRow();

                dr["Fecha"] = resumen.Fecha;
                dr["Monto"] = resumen.Abono;

                dt.Rows.Add(dr);

            }


            this.gvPagoAlumno.DataSource = dt;
            this.DataBind();
            gvPagoAlumno.Visible = true;
        }
        private void LoadGridHistoricoActividades(int id_curso)
        {
            lblResumenActividades.Visible = true;
            lblInfo.Visible = true;
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Monto", typeof(int));

            if (this.dropCurso.SelectedValue != "-1")
            {
                wsActividadPago.ResumenActividadPago[] pagos = cliente_actividad_pago.GetAllByCurso(int.Parse(this.dropCurso.SelectedValue));
                int numero_alumnos = cliente_curso.CountAlumnosInCurso(id_curso);


                foreach (wsActividadPago.ResumenActividadPago resumen in pagos)
                {
                    DataRow dr = dt.NewRow();

                    dr["Fecha"] = resumen.Fecha;
                    dr["Descripcion"] = resumen.Descripcion;
                    dr["Monto"] = resumen.Monto/numero_alumnos;

                    dt.Rows.Add(dr);

                }
                
            }
            this.gvActividadesAlumno.DataSource = dt;
            this.DataBind();

            gvActividadesAlumno.Visible = true;
        }
    }
}