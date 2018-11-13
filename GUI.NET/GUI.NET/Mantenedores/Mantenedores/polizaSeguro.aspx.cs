using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mantenedores
{
    public partial class polizaSeguro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPoliza_Click(object sender, EventArgs e)
        {
            int numPasajeros = int.Parse(this.txtNumPasajeros.Text);
            DateTime dayStart = DateTime.Parse(this.dpDayStart.Text);
            DateTime dateEnd = DateTime.Parse(this.dpDayEnd.Text);
            // Difference in days, hours, and minutes.
            TimeSpan ts = dateEnd - dayStart;

            // Difference in days.

            int numeroDias = ts.Days;
            int tipo_poliza = 1;
            if (this.rbPolizaCompleja.Checked)
            {
                tipo_poliza = 2;
            }
            else if (this.rbPolizaTotal.Checked)
            {
                tipo_poliza = 3;
            }

            wsPolizas.wsPolizasSoapClient poliza = new wsPolizas.wsPolizasSoapClient();
            int prima = poliza.GetPolizas(tipo_poliza, numPasajeros, numeroDias);
            this.lblTotal.Text = $"${prima}";
            this.lblCantidadDias.Text = numeroDias.ToString();
            this.lblTotalPersona.Text = (prima / numPasajeros).ToString();
        }
    }
}