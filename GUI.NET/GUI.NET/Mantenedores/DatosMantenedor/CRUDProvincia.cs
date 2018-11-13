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
    public class CRUDProvincia
    {
        public DataTable ListarProvincias(int id)
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select cod_provincia, nom_provincia from Provincia where region_cod_region = " + id + " ;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public string insertProv(string cod_prov, string cod_region, string nom_prov)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Provincia (cod_provincia,Region_cod_region,nom_provincia) " +
                "values(@cod_prov,@cod_Region,@nom_prov);", con);
            command.Parameters.Add("@cod_prov", SqlDbType.NVarChar).Value = cod_prov;
            command.Parameters.Add("@cod_Region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@nom_prov", SqlDbType.NVarChar).Value = nom_prov;
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

        public DataTable ListarTodoProv()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Region.cod_region AS CodigoRegion, dbo.Region.nom_region AS NombRegion, dbo.Provincia.cod_provincia AS CodigoProvincia, dbo.Provincia.nom_provincia AS NombProvincia " +
                                                "FROM            dbo.Provincia FULL OUTER JOIN " +
                                                "dbo.Region ON dbo.Provincia.Region_cod_region = dbo.Region.cod_region " +
                                                "WHERE(dbo.Provincia.cod_provincia IS NOT NULL)", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string updateRegion(string cod_prov, string cod_region, string nom_prov)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Provincia " +
                                                "set Region_cod_region = @nom_Region, nom_provincia = @nom_prov" +
                                                "where cod_provincia = @cod_prov ", con);
            command.Parameters.Add("@cod_prov", SqlDbType.NVarChar).Value = cod_prov;
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@nom_prov", SqlDbType.NVarChar).Value = nom_prov;

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

        public string deleteProv(string cod_prov)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Provincia " +
                                                "where cod_provincia = @cod_prov ", con);
            command.Parameters.Add("@cod_prov", SqlDbType.NVarChar).Value = cod_prov;
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

        public DataTable buscarProv(string cod_prov)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Region.cod_region AS CodigoRegion, dbo.Region.nom_region AS NombRegion, dbo.Provincia.cod_provincia AS CodigoProvincia, dbo.Provincia.nom_provincia AS NombProvincia " +
                                                "FROM            dbo.Provincia FULL OUTER JOIN " +
                                                "dbo.Region ON dbo.Provincia.Region_cod_region = dbo.Region.cod_region " +
                                                "WHERE(dbo.Provincia.cod_provincia = @cod_prov)", con);
            command.Parameters.Add("@cod_prov", SqlDbType.NVarChar).Value = cod_prov;
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }


    }

}
