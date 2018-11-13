using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //CRUDUsuario auxDatosCrudUsuario = new CRUDUsuario();
            //if (txtNombreUsuario.Text!="" && txtpassword.Text != "")
            //{
            //    Usuario auxUsuario = auxDatosCrudUsuario.obtenerUsuario(txtNombreUsuario.Text, txtpassword.Text);
            //    if (auxUsuario.Nombre == txtNombreUsuario.Text && auxUsuario.Clave == txtpassword.Text)
            //    {
            //        this.Session["validaLogin"] = auxUsuario.Perfil;
            //        Server.Transfer("MantenedorUsuario.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Error, credenciales incorrectas');</script>");
            //    }
            //}
            //else
            //{
            //    Response.Write("<script>alert('Error, Debe llenar las credenciales');</script>");
            //}
            Server.Transfer("iniciarSesion.aspx");
        }
    }
}