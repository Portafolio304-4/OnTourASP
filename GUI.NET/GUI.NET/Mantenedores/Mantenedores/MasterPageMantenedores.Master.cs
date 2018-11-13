using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class MasterPageMantenedores : System.Web.UI.MasterPage
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
                    if (user.Id_tipo_usuario == 1)
                    {

                        this.Master.FindControl("plEncargado").Visible = false;
                        this.Master.FindControl("plApoderado").Visible = false;
                        //this.Master.FindControl("plDueno").Visible = true;

                    }

                    else if (user.Id_tipo_usuario == 2)
                    {
                        this.Master.FindControl("plEncargado").Visible = true;
                        this.Master.FindControl("plApoderado").Visible = false;
                        //this.Master.FindControl("plDueno").Visible = false;
                    }
                    else if (user.Id_tipo_usuario == 3)
                    {
                        this.Master.FindControl("plEncargado").Visible = false;
                        this.Master.FindControl("plApoderado").Visible = true;
                        /*this.Master.FindControl("plDueno").Visible = true;*/
                    }
                }



            }
            catch(Exception ex)
            {
              
            }



        }

        protected void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Session.Clear();
            Server.Transfer("iniciarSesion.aspx");
        }

        public bool PlApoderado
        {
            get { return this.plApoderado.Visible; }
            set { plApoderado.Visible = value; }
        }
        public bool PlEncargado
        {
            get { return this.plEncargado.Visible; }
            set { plApoderado.Visible = value; }
        }
        
    }
}