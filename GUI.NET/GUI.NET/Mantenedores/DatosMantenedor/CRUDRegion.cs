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
    public class CRUDRegion
    {
        public DataTable ListarRegiones()
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select cod_region, nom_region from Region ;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public string insertRegion(string cod_region, string nom_region)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Region (cod_region,nom_region) " +
                "values(@cod_region,@nom_Region);", con);
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@nom_Region", SqlDbType.NVarChar).Value = nom_region;
            adapter.InsertCommand = command;
            string msg = "Exito";
            try
            {
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException odbcEx)
            {
                msg = odbcEx.Number.ToString();
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return msg;
        }

        public DataTable ListarTodoRegion()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.Region.cod_region AS CodigoRegion, dbo.Region.nom_region AS NombreRegion " +
                                                "FROM dbo.Region " +
                                                "where dbo.Region.cod_region IS NOT NULL ", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string updateRegion(string cod_region, string nom_region)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Region " +
                                                "set nom_region = @nom_Region," +
                                                "where cod_region = @cod_region ", con);
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@nom_region", SqlDbType.NVarChar).Value = nom_region;

            adapter.UpdateCommand = command;
            string msg = "Exito";
            try
            {
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException odbcEx)
            {
                msg = odbcEx.Number.ToString();
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return msg;
        }

        public string deleteRegion(string cod_region)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Region " +
                                                "where cod_region = @cod_region ", con);
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            adapter.DeleteCommand = command;
            string msg = "Exito";
            try
            {
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException odbcEx)
            {
                msg = odbcEx.Number.ToString();
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return msg;
        }

        public DataTable buscarRegion(string cod_region)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.Region.cod_region AS CodigoRegion, dbo.Region.nom_region AS NombreRegion " +
                                                "FROM dbo.Region " +
                                                "WHERE dbo.Region.cod_region = @cod_region", con);
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }




    }

}
