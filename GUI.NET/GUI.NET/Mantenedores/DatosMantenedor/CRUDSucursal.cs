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
    public class CRUDSucursal
    {
        public DataTable ListarSucursalesFiltrado(string idEmpresa)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select cod_sucursal,nom_sucursal from Sucursal where Empresa_Rut_Empresa ='" + idEmpresa+"';", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ListarSucursales()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select cod_sucursal,nom_sucursal from Sucursal ;", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ListarTodoSucursal()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Empresa.nom_empresa AS Empresa, dbo.Sucursal.cod_sucursal AS CodSucursal, dbo.Region.nom_region AS Region, dbo.Provincia.nom_provincia AS Provincia, dbo.Comuna.nom_comuna AS Comuna, " +
                                                "dbo.Sucursal.nom_sucursal AS NomSucursal, dbo.Sucursal.direccion AS Direccion " +
                                                "FROM            dbo.Comuna FULL OUTER JOIN " +
                                                "dbo.Provincia ON dbo.Comuna.Provincia_cod_provincia = dbo.Provincia.cod_provincia FULL OUTER JOIN " +
                                                "dbo.Region ON dbo.Comuna.Provincia_Region_cod_region = dbo.Region.cod_region AND dbo.Provincia.Region_cod_region = dbo.Region.cod_region FULL OUTER JOIN " +
                                                "dbo.Sucursal ON dbo.Comuna.cod_comuna = dbo.Sucursal.Comuna_cod_comuna AND dbo.Provincia.cod_provincia = dbo.Sucursal.Comuna_Provincia_cod_provincia AND " +
                                                "dbo.Region.cod_region = dbo.Sucursal.Comuna_Provincia_Region_cod_region FULL OUTER JOIN " +
                                                "dbo.Empresa ON dbo.Sucursal.Empresa_Rut_Empresa = dbo.Empresa.Rut_empresa " +
                                                "WHERE(dbo.Sucursal.cod_sucursal IS NOT NULL) ;"
                                                , con);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string insertSucursal(string cod_sucursal, string rut_empresa, string cod_comuna, string nom_sucursal, string direccion, string cod_provincia, string cod_region)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Sucursal (cod_sucursal,Empresa_Rut_Empresa,Comuna_Provincia_cod_provincia,Comuna_Provincia_Region_cod_region, " +
                "Comuna_cod_comuna,nom_sucursal,direccion) " +
                "values (@cod_sucursal,@rut_empresa,@cod_provincia,@cod_region,@cod_comuna,@nom_sucursal,@direccion );", con);

            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_provincia", SqlDbType.NVarChar).Value = cod_provincia;
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@cod_comuna", SqlDbType.NVarChar).Value = cod_comuna;
            command.Parameters.Add("@nom_sucursal", SqlDbType.NVarChar).Value = nom_sucursal;
            command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;

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

        public string deleteSucursal(string codigoSeleccionado)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Sucursal " +
                                                "where cod_sucursal = @codigoSeleccionado ", con);
            command.Parameters.Add("@codigoSeleccionado", SqlDbType.NVarChar).Value = codigoSeleccionado;
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

        public string updateSucursal(string cod_sucursal, string rut_empresa, string cod_comuna, string nom_sucursal, string direccion, string cod_provincia, string cod_region)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Sucursal " +
                                                "set Empresa_Rut_Empresa = @rut_empresa," +
                                                "Comuna_Provincia_cod_provincia = @cod_provincia, " +
                                                "Comuna_Provincia_Region_cod_region = @cod_region, " +
                                                "Comuna_cod_comuna = @cod_comuna, " +
                                                "nom_sucursal = @nom_sucursal, " +
                                                "direccion = @direccion " +
                                                "where cod_sucursal = @cod_sucursal", con);

            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_provincia", SqlDbType.NVarChar).Value = cod_provincia;
            command.Parameters.Add("@cod_region", SqlDbType.NVarChar).Value = cod_region;
            command.Parameters.Add("@cod_comuna", SqlDbType.NVarChar).Value = cod_comuna;
            command.Parameters.Add("@nom_sucursal", SqlDbType.NVarChar).Value = nom_sucursal;
            command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;

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

        public DataTable buscarSucursal(string cod_sucursal)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Empresa.nom_empresa AS Empresa, dbo.Sucursal.cod_sucursal AS CodSucursal, dbo.Region.nom_region AS Region, dbo.Provincia.nom_provincia AS Provincia, dbo.Comuna.nom_comuna AS Comuna, " +
                                                "dbo.Sucursal.nom_sucursal AS NomSucursal, dbo.Sucursal.direccion AS Direccion " +
                                                "FROM            dbo.Comuna FULL OUTER JOIN " +
                                                "dbo.Provincia ON dbo.Comuna.Provincia_cod_provincia = dbo.Provincia.cod_provincia FULL OUTER JOIN " +
                                                "dbo.Region ON dbo.Comuna.Provincia_Region_cod_region = dbo.Region.cod_region AND dbo.Provincia.Region_cod_region = dbo.Region.cod_region FULL OUTER JOIN " +
                                                "dbo.Sucursal ON dbo.Comuna.cod_comuna = dbo.Sucursal.Comuna_cod_comuna AND dbo.Provincia.cod_provincia = dbo.Sucursal.Comuna_Provincia_cod_provincia AND " +
                                                "dbo.Region.cod_region = dbo.Sucursal.Comuna_Provincia_Region_cod_region FULL OUTER JOIN " +
                                                "dbo.Empresa ON dbo.Sucursal.Empresa_Rut_Empresa = dbo.Empresa.Rut_empresa " +
                                                "WHERE(dbo.Sucursal.cod_sucursal = @cod_sucursal) ;"
                                                , con);
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }

}
