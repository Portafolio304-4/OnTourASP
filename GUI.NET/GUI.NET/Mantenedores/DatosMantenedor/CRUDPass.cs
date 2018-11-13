using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DatosMantenedor
{
    public class CRUDPass
    {
        public int insertPass(DateTime fecha, string Usuario_Rut_Usuario, string clave)
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            int res = 0;
            string consulta = "insert into Pass (fecha,Usuario_Rut_Usuario,clave)" +
                "values ('" + fecha + "','" + Usuario_Rut_Usuario + "'," + clave + ")";

            SqlCommand cmd = new SqlCommand(consulta, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
