using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //AGREGAR
using System.Data.SqlClient; //AGREGAR

namespace DatosMantenedor
{
    public class Conexion
    {
        public static string CadenaConexion()
        {
            return "workstation id=mi3-wsq2.a2hosting.com;packet size=4096;user id=titcl_citt_bd;pwd=jkD34h9?Vvx84u_7;data source=mi3-wsq2.a2hosting.com;persist security info=False;initial catalog=titcl_beacons_bd";
        }

    }
}
