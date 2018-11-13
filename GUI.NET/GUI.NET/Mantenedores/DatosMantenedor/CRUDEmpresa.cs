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
    public class CRUDEmpresa
    {
        public string insertarEmpresa(string nom_empresa, string Rut_Empresa, int estado)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Empresa (Rut_Empresa,nom_empresa,estado)" +
                "values(@RutEmpresa,@nom_empresa,@estado);", con);
            command.Parameters.Add("@RutEmpresa", SqlDbType.NVarChar).Value = Rut_Empresa;
            command.Parameters.Add("@nom_empresa", SqlDbType.NVarChar).Value = nom_empresa;
            command.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
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

        public DataTable ListarEmpresas()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select Rut_empresa," +
                                                "nom_empresa " +
                                                "from Empresa;", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ListarTodoEmpresa()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select Rut_empresa, " +
                                                "nom_empresa, " +
                                                "case when estado = '1' then 'Activa' " +
                                                "else 'Inactiva' end as estado " +
                                                "from Empresa;", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string updateEmpresa(string Rut_Empresa, string nom_empresa, int estado)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Empresa " +
                                                "set nom_empresa = @nom_empresa," +
                                                "estado = @estado " +
                                                "where Rut_Empresa = @Rut_Empresa", con);
            command.Parameters.Add("@nom_empresa", SqlDbType.NVarChar).Value = nom_empresa;
            command.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
            command.Parameters.Add("@Rut_Empresa", SqlDbType.NVarChar).Value = Rut_Empresa;
            adapter.UpdateCommand = command;
            string msg = "Exito";
            try
            {
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return msg;
        }

        public string eliminarEmpresa(string Rut_Empresa)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Empresa " +
                                                "where Rut_Empresa = @Rut_Empresa", con);
            command.Parameters.Add("@Rut_Empresa", SqlDbType.NVarChar).Value = Rut_Empresa;
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

        public DataTable buscarEmpresa(string rut)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select Rut_empresa," +
                                                "nom_empresa, " +
                                                "case when estado = '1' then 'Activa' " +
                                                "else 'Inactiva' end as estado " +
                                                "from Empresa where Rut_empresa=@rut_empresa", con);
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

    }

}
