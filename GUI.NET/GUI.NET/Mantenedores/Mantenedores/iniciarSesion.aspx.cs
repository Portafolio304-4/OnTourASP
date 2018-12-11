using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Mantenedores
{
    public partial class iniciarSesion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = formatearRut(txtUsuario.Text);
        }

        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                //rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    //if (cont == 3 && i != 0)
                    //{
                    //    format = "." + format;
                    //    cont = 0;
                    //}
                }
                return format;
            }
        }

        protected void btnIniciarSesionLista_Click(object sender, EventArgs e)
        {
            wsUsuario.wsUsuarioSoapClient cliente_usuario = new wsUsuario.wsUsuarioSoapClient();

            string user_name = txtUsuario.Text;
            string password = txtPassword.Text;


            wsUsuario.Usuario user = cliente_usuario.Authenticate(user_name, password);

            if (user.Id == 0)
            {
                lblResultado.Text = "Usuario o contraseña invalidos";
            }
            else if (user.Id_tipo_usuario == 1)
            {
                Session["usuario"] = user;
                Response.Redirect("portadaDueno.aspx");
            }
            else
            {
                Session["usuario"] = user;
                Response.Redirect("portadaUsuario.aspx");
            }

        }


        protected void btnRegistarseLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("registro.aspx");
        }
    }
}