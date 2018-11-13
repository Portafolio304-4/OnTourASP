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
    public class CRUDPerfil
    {
        public int insertPerfil(string cod_perfil, string des_perfil)
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            int res = 0;
            string consulta = "insert into Perfil (cod_perfil,des_perfil)" +
                "values ('" + cod_perfil + "','" + des_perfil + "')";

            SqlCommand cmd = new SqlCommand(consulta, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public DataTable ListarPerfil()
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select cod_perfil,des_perfil from Perfil ;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
