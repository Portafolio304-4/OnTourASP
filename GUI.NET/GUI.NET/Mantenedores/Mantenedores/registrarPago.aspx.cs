using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSOnTour.DTOs;
using WSOnTour.Logica;

namespace Mantenedores
{
    public partial class registrarPago : System.Web.UI.Page
    {
        wsApoderado.wsApoderadoSoapClient cliente_apoderado = new wsApoderado.wsApoderadoSoapClient();
        wsPago.wsPagoSoapClient cliente_pago = new wsPago.wsPagoSoapClient();
        wsSendMail.wsSendMailSoapClient cliente_mail = new wsSendMail.wsSendMailSoapClient();
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
                    ListItem first_element = new ListItem("Seleccione un Alumno", "-1");
                    this.dropRutAlumno.Items.Add(first_element);
                    this.LoadGridHistoricoPagos(apoderado.Rut);
                }
                
            }

        }

        

        protected void dropCurso_SelectedIndexChanged(object sender, EventArgs e)
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

                if (!this.dropCurso.Items.Contains(item))
                {
                    this.dropCurso.Items.Add(item);
                }

            }


        }
        public int CalcularDeuda(string rut, int curso)
        {
            wsEstadoCuenta.wsEstadoCuentaSoapClient client_ec = new wsEstadoCuenta.wsEstadoCuentaSoapClient();
            int deuda_alumno = client_ec.GetDeudaAlumno(curso);
            int pago_alumno = client_ec.GetTotalPagado(rut, curso);
            return deuda_alumno - pago_alumno;
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

        protected  void btnPagar_Click(object sender, EventArgs e)
        {
            if (this.dropCurso.SelectedValue == "-1")
            {
                this.lblMessage.Text = "Debe seleccionar un curso";
            }
            else
            {
                if (this.dropRutAlumno.SelectedValue == "-1")
                {
                    this.lblMessage.Text = "Debe seleccionar un alumno";
                }
                else
                {
                    int deuda_total = CalcularDeuda(this.dropRutAlumno.SelectedValue, int.Parse(this.dropCurso.SelectedValue));
                    int result_try_abono;
                    int.TryParse(this.txtMontoCancelar.Text, out result_try_abono);
                    if (result_try_abono == 0)
                    {
                        this.lblMessage.Text = "Debe ingresar un monto valido ej:1000, no incluya puntos ni comas";
                    }
                    else
                    {
                        int abono = int.Parse(this.txtMontoCancelar.Text);
                        if (abono < 0)
                        {
                            this.lblMessage.Text = "Debe ingresar un monto positivo";
                        }
                        else
                        {
                            if (abono > deuda_total)
                            {
                                lblMessage.Text = "No puede cancelar un monto mayor, a la deuda actual que sostiene";
                            }
                            else
                            {
                                string rut_alumno = this.dropRutAlumno.SelectedValue;
                                int id_tipo_pago = 1;

                                bool created = cliente_pago.CreateSinglePaid(abono, rut_alumno, id_tipo_pago);

                                if (created)
                                {
                                    this.lblMessage.Text = "Pago creado con exito";
                                    wsApoderado.Apoderado apoderado = (wsApoderado.Apoderado)Session["apoderado"];
                                    this.LoadGridHistoricoPagos(apoderado.Rut);

                                    wsApoderado.Alumno alumno = cliente_apoderado.GetAlumnoByRut(apoderado.Rut, rut_alumno);
                                    wsUsuario.Usuario user = (wsUsuario.Usuario)Session["usuario"];

                                    string nombre_apoderado = $"{apoderado.Nombre_completo} {apoderado.Ap_paterno} {apoderado.Ap_materno}";
                                    string nombre_alumno = $"{alumno.Nombre_completo} {alumno.Ap_paterno} {alumno.Ap_materno}";

                                    deuda_total = CalcularDeuda(this.dropRutAlumno.SelectedValue, int.Parse(this.dropCurso.SelectedValue));
                                    lblDeudaActual.Text = "Deuda alumno: $" + deuda_total.ToString();
                                    txtMontoCancelar.Text = ""; 

                                    cliente_mail.SendMailPaidAsync(user.Email, nombre_apoderado, nombre_alumno, abono);


                                }
                                else
                                {
                                    this.lblMessage.Text = "El pago no se pudo registrar por favor intente mas tarde";
                                }
                            }
                            
                        } 
                    }
                }
            }
        }
        private void LoadGridHistoricoPagos(string rut_apoderado)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Rut Alumno", typeof(String));
            dt.Columns.Add("Nombre Alumno", typeof(string));
            dt.Columns.Add("Curso", typeof(String));
            dt.Columns.Add("Monto", typeof(int));

            wsPago.ResumenPago[] pagos = cliente_pago.GetAllByApoderado(rut_apoderado);

            foreach (wsPago.ResumenPago resumen in pagos)
            {
                DataRow dr = dt.NewRow();

                dr["Fecha"] = resumen.Fecha;
                dr["Rut Alumno"] = resumen.Rut_alumno;
                dr["Nombre Alumno"] = resumen.Nombre_alumno;
                dr["Curso"] = resumen.Curso;
                dr["Monto"] = resumen.Abono;

                dt.Rows.Add(dr);

            }


            this.gridHistoricoPagos.DataSource = dt;
            this.DataBind();
        }

        protected void dropRutAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dropRutAlumno.SelectedValue != "-1")
            {
                int deuda_total = CalcularDeuda(this.dropRutAlumno.SelectedValue, int.Parse(this.dropCurso.SelectedValue));
                lblDeudaActual.Text = "Deuda alumno: $" + deuda_total.ToString();

            }
            else
            {
                lblDeudaActual.Text = "";
            }
        }
    }
}