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
    public class CRUDComuna
    {
        public DataTable ListarComuna(int id)
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select cod_comuna,nom_comuna from  comuna where Provincia_cod_provincia=" + id + ";";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public string insertComuna(string cod_comu, string cod_prov, string cod_region, string nom_comuna)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Comuna (cod_comuna,Provincia_Region_cod_region,Provincia_cod_provincia,nom_comuna) " +
                "values(@cod_comu,@cod_region,@cod_prov,@nom_comuna);", con);
            command.Parameters.Add("@cod_comu", SqlDbType.NVarChar).Value = cod_comu;
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@cod_prov", SqlDbType.NVarChar).Value = cod_prov;
            command.Parameters.Add("@nom_comuna", SqlDbType.NVarChar).Value = nom_comuna;
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

        public DataTable ListarTodoComu()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Region.cod_region AS CodigoRegion, dbo.Region.nom_region AS NombRegion, dbo.Provincia.cod_provincia AS CodigoProvincia, dbo.Provincia.nom_provincia AS NombProvincia, " +
                                                "dbo.Comuna.cod_comuna AS CodigoComuna, dbo.Comuna.nom_comuna AS NombComuna " +
                                                "FROM            dbo.Comuna FULL OUTER JOIN " +
                                                "dbo.Provincia ON dbo.Comuna.Provincia_cod_provincia = dbo.Provincia.cod_provincia FULL OUTER JOIN " +
                                                "dbo.Region ON dbo.Comuna.Provincia_Region_cod_region = dbo.Region.cod_region AND dbo.Provincia.Region_cod_region = dbo.Region.cod_region " +
                                                "WHERE(dbo.Comuna.cod_comuna IS NOT NULL)", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string updateComuna(string cod_comu, string cod_prov, string cod_region, string nom_comuna)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Comuna " +
                                                "set Provincia_Region_cod_region = @cod_region, Provincia_cod_provincia = @cod_prov, " +
                                                "nom_comuna = @nom_comuna " +
                                                "where cod_comuna = @cod_comu ", con);
            command.Parameters.Add("@cod_comu", SqlDbType.NVarChar).Value = cod_comu;
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@cod_prov", SqlDbType.NVarChar).Value = cod_prov;
            command.Parameters.Add("@nom_comuna", SqlDbType.NVarChar).Value = nom_comuna;

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

        public string deleteComuna(string cod_comu)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Comuna " +
                                                "where cod_comuna = @cod_comu ", con);
            command.Parameters.Add("@cod_comu", SqlDbType.NVarChar).Value = cod_comu;
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

        public DataTable buscarComuna(string cod_comu)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Region.cod_region AS CodigoRegion, dbo.Region.nom_region AS NombRegion, dbo.Provincia.cod_provincia AS CodigoProvincia, dbo.Provincia.nom_provincia AS NombProvincia, " +
                                                "dbo.Comuna.cod_comuna AS CodigoComuna, dbo.Comuna.nom_comuna AS NombComuna " +
                                                "FROM            dbo.Comuna FULL OUTER JOIN " +
                                                "dbo.Provincia ON dbo.Comuna.Provincia_cod_provincia = dbo.Provincia.cod_provincia FULL OUTER JOIN " +
                                                "dbo.Region ON dbo.Comuna.Provincia_Region_cod_region = dbo.Region.cod_region AND dbo.Provincia.Region_cod_region = dbo.Region.cod_region " +
                                                "WHERE dbo.Comuna.cod_comuna = @cod_comu", con);
            command.Parameters.Add("@cod_comu", SqlDbType.NVarChar).Value = cod_comu;
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }

}
