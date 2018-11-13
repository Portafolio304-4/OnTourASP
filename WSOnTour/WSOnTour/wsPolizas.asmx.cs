using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSOnTour
{
    /// <summary>
    /// Descripción breve de wsPolizas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPolizas : System.Web.Services.WebService
    {

        [WebMethod]
        public int GetPolizas(int id_tipo_seguro, int cantidad_personas, int numero_dias)
        {
            int valor_por_dia = 0;
            switch (id_tipo_seguro)
            {
                case 1:
                    // seguro simple
                    valor_por_dia = 10000;
                    break;
                case 2:
                    valor_por_dia = 15000;
                    break;
                case 3:
                    // seguro con cobertura total
                    valor_por_dia = 25000;
                    break;
            }
            return valor_por_dia * cantidad_personas * numero_dias;
        }
    }
}
