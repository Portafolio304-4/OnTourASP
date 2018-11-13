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
    public class CRUDPiso
    {
        public string insertPiso(string cod_piso, string rut_empresa, string cod_sucursal,
            string des_piso, string id_beacons, string path_video, string path_audio)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Piso (cod_piso,Sucursal_Empresa_Rut_empresa,Sucursal_cod_sucursal,des_piso, " +
                "id_beacons,path_video,path_audio) " +
                "values (@cod_piso,@rut_empresa,@cod_sucursal,@des_piso,@id_beacons,@path_video,@path_audio );", con);

            command.Parameters.Add("@cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@des_piso", SqlDbType.NVarChar).Value = des_piso;
            command.Parameters.Add("@id_beacons", SqlDbType.NVarChar).Value = id_beacons;
            command.Parameters.Add("@path_video", SqlDbType.NVarChar).Value = path_video;
            command.Parameters.Add("@path_audio", SqlDbType.NVarChar).Value = path_audio;

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

        public DataTable ListarPisoFiltrado(string idSucursal)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select cod_piso,des_piso from Piso where Sucursal_cod_sucursal='"+idSucursal+"';", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ListarPisos()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("select cod_piso,des_piso from Piso ;", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ListarTodoPiso()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.Piso.cod_piso AS codPiso, dbo.Empresa.nom_empresa AS Empresa, dbo.Sucursal.nom_sucursal AS Sucursal, dbo.Piso.des_piso AS desPiso, dbo.Piso.id_beacons AS idBeacons, dbo.Piso.path_video AS video, " +
                                                "dbo.Piso.path_audio AS audio " +
                                                "FROM dbo.Empresa FULL OUTER JOIN " +
                                                "dbo.Piso ON dbo.Empresa.Rut_empresa = dbo.Piso.Sucursal_Empresa_Rut_empresa FULL OUTER JOIN " +
                                                "dbo.Sucursal ON dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa AND dbo.Piso.Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal " +
                                                "WHERE(dbo.Piso.cod_piso IS NOT NULL)", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string deletePiso(string cod_piso)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Piso " +
                                                "where cod_piso = @pisoSeleccionado ", con);
            command.Parameters.Add("@pisoSeleccionado", SqlDbType.NVarChar).Value = cod_piso;
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

        public string updatePiso(string cod_piso, string rut_empresa, string cod_sucursal,
            string des_piso, string id_beacons, string path_video, string path_audio)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Piso " +
                                                "set Sucursal_Empresa_Rut_empresa = @rut_empresa," +
                                                "Sucursal_cod_sucursal = @cod_sucursal, " +
                                                "des_piso = @des_piso, " +
                                                "id_beacons = @id_beacons, " +
                                                "path_video = @path_video, " +
                                                "path_audio = @path_audio " +
                                                "where cod_piso = @cod_piso", con);

            command.Parameters.Add("@cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@des_piso", SqlDbType.NVarChar).Value = des_piso;
            command.Parameters.Add("@id_beacons", SqlDbType.NVarChar).Value = id_beacons;
            command.Parameters.Add("@path_video", SqlDbType.NVarChar).Value = path_video;
            command.Parameters.Add("@path_audio", SqlDbType.NVarChar).Value = path_audio;

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

        public DataTable buscarPiso(string cod_piso)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.Piso.cod_piso AS codPiso, dbo.Empresa.nom_empresa AS Empresa, dbo.Sucursal.nom_sucursal AS Sucursal, dbo.Piso.des_piso AS desPiso, dbo.Piso.id_beacons AS idBeacons, dbo.Piso.path_video AS video, " +
                                                "dbo.Piso.path_audio AS audio " +
                                                "FROM dbo.Empresa FULL OUTER JOIN " +
                                                "dbo.Piso ON dbo.Empresa.Rut_empresa = dbo.Piso.Sucursal_Empresa_Rut_empresa FULL OUTER JOIN " +
                                                "dbo.Sucursal ON dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa AND dbo.Piso.Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal " +
                                                "WHERE dbo.Piso.cod_piso = @cod_piso ;", con);
            command.Parameters.Add("@cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }

}
