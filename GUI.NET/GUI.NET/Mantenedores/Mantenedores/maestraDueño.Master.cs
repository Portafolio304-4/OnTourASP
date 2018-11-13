using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class maestraDueño : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Session["usuario"] == null)
                {
                    Server.Transfer("iniciarSesion.aspx");
                }
                else
                {
                    wsUsuario.Usuario user = (wsUsuario.Usuario)Session["usuario"];
                    wsApoderado.Apoderado apo = new wsApoderado.Apoderado();
                    wsApoderado.wsApoderadoSoapClient apoderado = new wsApoderado.wsApoderadoSoapClient();
                    apo = apoderado.ReadByUsername(user.User_name);
                    this.lblActivo.Text = apo.Nombre_completo.ToString();
                    
                }



            }
            catch (Exception ex)
            {

            }



        }

        protected void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Session["validaLogin"] = null;
            Server.Transfer("iniciarSesion.aspx");
        }
    }
}