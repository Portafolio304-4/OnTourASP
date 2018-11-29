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