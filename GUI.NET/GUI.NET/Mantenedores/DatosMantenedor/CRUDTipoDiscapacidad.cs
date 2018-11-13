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
    public class CRUDTipoDiscapacidad
    {
        public int insertTipoDiscapacidad(string cod_tipoDiscapacidad, string des_tipoDiscapacidad, string video, string audio)
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            int res = 0;
            string consulta = "insert into Tipo_Discapacidad (cod_tipoDiscapacidad,des_tipoDiscapacidad,video,audio)" +
                "values ('" + cod_tipoDiscapacidad + "','" + des_tipoDiscapacidad + "','" + video + "','" + audio + "')";

            SqlCommand cmd = new SqlCommand(consulta, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public DataTable ListarTipoDiscapacidad()
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select cod_tipoDiscapacidad, des_tipoDiscapacidad from Tipo_Discapacidad ;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
