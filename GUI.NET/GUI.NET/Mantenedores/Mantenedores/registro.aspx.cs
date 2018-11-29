using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSOnTour.DTOs;

namespace Mantenedores
{
    public partial class registro : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDdlColegio();
            } 

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (this.ddlColegio.SelectedValue == "-1" || this.ddlCurso.SelectedValue == "-1")
            {
                lblResultado.Text = "Se debe seleccionar un colegio y curso validos";
            }
            else
            {
                // validar que el apoderado exista en el curso
                wsCurso.wsCursoSoapClient cliente_curso = new wsCurso.wsCursoSoapClient();
                int id_curso = int.Parse(ddlCurso.SelectedItem.Value);
                string rut = txtRut.Text;

                if (cliente_curso.VerifyApoderadoInCurso(id_curso, rut))
                {
                    // validar que las constraseñas coincidan
                    if (txtPassword.Text == txtPassword2.Text)
                    {
                        int id_tipo_usuario = 3;
                        Usuario usuario = new Usuario();
                        usuario.User_name = txtRut.Text;
                        usuario.Password = txtPassword.Text;
                        usuario.Email = txtEmail.Text;
                        if (this.chkEncargado.Checked)
                        {
                            id_tipo_usuario = 4;
                        }
                        usuario.Id_tipo_usuario = id_tipo_usuario;
                        wsUsuario.wsUsuarioSoapClient cliente_usuario = new wsUsuario.wsUsuarioSoapClient();

                        bool created = cliente_usuario.Create(usuario.User_name, usuario.Password, usuario.Id_tipo_usuario, usuario.Email);

                        if (created)
                        {
                            lblResultado.Text = "Usuario Creado Con exito";
                            // reset from
                        }
                        else
                        {
                            lblResultado.Text = "No se ha podido crear el usuario por favor intente mas tarde";
                        }
                    }
                    else
                    {
                        lblResultado.Text = "Las contraseñas no coinciden";
                    }
                }
                else
                {
                    lblResultado.Text = "El apoderado no se encuentra registrado en ese curso<br> no se pudo crear la cuenta";
                }

            }



        }

        protected void ddlColegio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlColegio.SelectedItem.Value == "-1")
            {
                ddlCurso.Items.Clear();
            }
            else
            {
                ddlCurso.Items.Add(new ListItem("Cargando cursos......"));
                int id_colegio =int.Parse(this.ddlColegio.SelectedItem.Value);
                this.loadDdlCurso(id_colegio);
            }

        }

        private void loadDdlColegio()
        {
            this.ddlColegio.Items.Clear();
            ListItem first_element = new ListItem("Seleccione un Colegio", "-1");
            this.ddlColegio.Items.Add(first_element);

            wsColegio.wsColegioSoapClient client_colegio = new wsColegio.wsColegioSoapClient();
            wsColegio.Colegio[] colegios = client_colegio.ReadAllNamesAndIds();

            foreach (wsColegio.Colegio colegio in colegios)
            {
                ListItem item = new ListItem(colegio.Nombre, colegio.Id.ToString());
                this.ddlColegio.Items.Add(item);

            }
        }

        private void loadDdlCurso(int id)
        {
            this.ddlCurso.Items.Clear();
            ListItem first_element = new ListItem("Seleccione un Curso", "-1");
            this.ddlCurso.Items.Add(first_element);
            wsCurso.wsCursoSoapClient client_curso = new wsCurso.wsCursoSoapClient();

            wsCurso.Curso[] cursos = client_curso.ReadAllByColegio(id);

            foreach (wsCurso.Curso curso in cursos)
            {
                ListItem item = new ListItem(curso.Nivel + " " +  curso.Grado + curso.Letra, curso.Id.ToString());
                this.ddlCurso.Items.Add(item);
            }

            
        }
        

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer("iniciarSesion.aspx");
        }
    }
}