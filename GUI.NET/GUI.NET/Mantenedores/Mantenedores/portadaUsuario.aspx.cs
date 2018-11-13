using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSOnTour.DTOs;

namespace Mantenedores
{
    public partial class portadaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {

            }
            else
            {

                //aca nose como mierda llegue al dato que necesitaba pero lo logre...
                wsUsuario.Usuario user = (wsUsuario.Usuario)Session["usuario"];
                wsApoderado.Apoderado apo = new wsApoderado.Apoderado();
                wsApoderado.wsApoderadoSoapClient apoderado = new wsApoderado.wsApoderadoSoapClient();
                apo=apoderado.ReadByUsername(user.User_name);
                this.lblNombreBienvenida.Text = apo.Nombre_completo.ToString() + " " + apo.Ap_paterno.ToString();
                //termino de buscar

                
            }

        }
    }
}