﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class registroActividad : System.Web.UI.Page
    {
        wsApoderado.wsApoderadoSoapClient cliente_apoderado = new wsApoderado.wsApoderadoSoapClient();
        wsActividadPago.wsActividadPagoSoapClient cliente_actividad_pago = new wsActividadPago.wsActividadPagoSoapClient();
        wsSendMail.wsSendMailSoapClient cliente_correo = new wsSendMail.wsSendMailSoapClient();
        wsEstadoCuenta.wsEstadoCuentaSoapClient cliente_ec = new wsEstadoCuenta.wsEstadoCuentaSoapClient();
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
                    LoadDropTipoActividad();
                }
            }

        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            if (this.dropCurso.SelectedValue == "-1" || this.dropTipoActividad.SelectedValue == "-1")
            {
                lblResultado.Text = "Debe seleccionar un curso y un tipo de actividad";
            }
            else
            {
                string descripcion = this.dropTipoActividad.SelectedValue;
                int try_parse_monto;
                int.TryParse(txtMontoCancelar.Text, out try_parse_monto);
                if (try_parse_monto == 0)
                {
                    lblResultado.Text = "El monto de la actividad debe ser un numero";
                }
                else
                {
                    int monto = int.Parse(txtMontoCancelar.Text);
                    if (monto < 0)
                    {
                        lblResultado.Text = "El monto de la actividad debe ser mayor a cero";
                    }
                    else
                    {
                        int deuda_total = cliente_ec.GetDeudaTotal(int.Parse(dropCurso.SelectedValue));
                        int total_pagos = cliente_ec.GetTotalPagos(int.Parse(dropCurso.SelectedValue));
                        int deuda_actual = deuda_total - total_pagos;
                        if (deuda_actual < monto)
                        {
                            lblResultado.Text = "El monto de la actividad no puede ser mayor a la deuda";
                        }
                        else
                        {
                            int id_curso = int.Parse(dropCurso.Text);
                            DateTime fecha = DateTime.Now;
                            bool created = cliente_actividad_pago.CreatePaid(descripcion, monto, id_curso, fecha);
                            if (created)
                            {
                                this.lblResultado.Text = "Actividad ingresada con exito";
                                this.LoadGridHistoricoActividades();
                                wsUsuario.Usuario user = (wsUsuario.Usuario)Session["usuario"];
                                wsApoderado.Apoderado apoderado = (wsApoderado.Apoderado)Session["apoderado"];
                                string nombre_apoderado = $"{apoderado.Nombre_completo} {apoderado.Ap_paterno} {apoderado.Ap_materno}";
                                cliente_correo.SendMailActivityPaidAsync(user.Email, nombre_apoderado, dropCurso.SelectedItem.Text, monto);

                                total_pagos = cliente_ec.GetTotalPagos(int.Parse(dropCurso.SelectedValue));
                                lblDeudaTotal.Text = "Deuda Curso: $" + (deuda_total - total_pagos).ToString();

                            }
                            else
                            {
                                this.lblResultado.Text = "Fallo al ingresar actividad intente mas tarde";
                            }
                        }
                    }
                }
            }
        }

        private void LoadDropTipoActividad()
        {
            this.dropTipoActividad.Items.Clear();

            ListItem element = new ListItem("Seleccione una actividad", "-1");
            this.dropTipoActividad.Items.Add(element);

            element = new ListItem("Rifa", "Rifa");
            this.dropTipoActividad.Items.Add(element);

            element = new ListItem("Fiesta", "Fiesta");
            this.dropTipoActividad.Items.Add(element);

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

        private void LoadGridHistoricoActividades()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Curso", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Monto", typeof(int));

            if (this.dropCurso.SelectedValue != "-1")
            {
                wsActividadPago.ResumenActividadPago[] pagos = cliente_actividad_pago.GetAllByCurso(int.Parse(this.dropCurso.SelectedValue));

                foreach (wsActividadPago.ResumenActividadPago resumen in pagos)
                {
                    DataRow dr = dt.NewRow();

                    dr["Fecha"] = resumen.Fecha;
                    dr["Curso"] = resumen.Curso;
                    dr["Descripcion"] = resumen.Descripcion;
                    dr["Monto"] = resumen.Monto;

                    dt.Rows.Add(dr);

                }
            }
            


            this.gridHistoricoActividades.DataSource = dt;
            this.DataBind();
        }

        protected void dropCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropCurso.SelectedValue != "-1")
            {
                this.LoadGridHistoricoActividades();
                int deuda_total = cliente_ec.GetDeudaTotal(int.Parse(dropCurso.SelectedValue));
                int total_pagos = cliente_ec.GetTotalPagos(int.Parse(dropCurso.SelectedValue));
                lblDeudaTotal.Text = "Deuda Curso: $" + (deuda_total - total_pagos).ToString();

            }
            
        }

        protected void gridHistoricoActividades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}