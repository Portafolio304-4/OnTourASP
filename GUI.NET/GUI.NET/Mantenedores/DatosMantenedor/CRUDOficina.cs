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
    public class CRUDOficina
    {
        public string insertOficina(string cod_oficina, string cod_piso, string rut_empresa,
            string cod_sucursal, string cod_area, string des_oficina, string id_beacons, string path_video,
            string path_audio)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Oficina (cod_oficina,Area_Piso_cod_piso,Area_Piso_Sucursal_Empresa_Rut_empresa,Area_Piso_Sucursal_cod_sucursal, " +
                "Area_cod_area,des_oficina,id_beacons,path_video,path_audio) values (" +
                "@cod_oficina,@cod_piso,@rut_empresa,@cod_sucursal,@cod_area,@des_oficina,@id_beacons,@path_video, " +
                "@path_audio);", con);
            command.Parameters.Add("@cod_oficina", SqlDbType.NVarChar).Value = cod_oficina;
            command.Parameters.Add("@cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@cod_area", SqlDbType.NVarChar).Value = cod_area;
            command.Parameters.Add("@des_oficina", SqlDbType.NVarChar).Value = des_oficina;
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

        public DataTable ListarDesOficina()
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select des_oficina from Oficina ;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ListarTodoOficina()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.Oficina.cod_oficina AS CodOficina, dbo.Empresa.nom_empresa AS Empresa, dbo.Sucursal.nom_sucursal AS Sucursal, dbo.Piso.des_piso AS Piso, dbo.Area.des_area AS Area, dbo.Oficina.des_oficina AS DesOficina, " +
                                                 "dbo.Oficina.id_beacons AS IdBeacons, dbo.Oficina.path_video AS Video, dbo.Oficina.path_audio AS Audio " +
                                                 " FROM dbo.Area FULL OUTER JOIN " +
                                                 "dbo.Empresa ON dbo.Area.Piso_Sucursal_Empresa_Rut_Empresa = dbo.Empresa.Rut_empresa FULL OUTER JOIN " +
                                                 "dbo.Oficina ON dbo.Area.cod_area = dbo.Oficina.Area_cod_area AND dbo.Empresa.Rut_empresa = dbo.Oficina.Area_Piso_Sucursal_Empresa_Rut_empresa FULL OUTER JOIN " +
                                                 "dbo.Piso ON dbo.Area.Piso_cod_piso = dbo.Piso.cod_piso AND dbo.Empresa.Rut_empresa = dbo.Piso.Sucursal_Empresa_Rut_empresa AND dbo.Oficina.Area_Piso_cod_piso = dbo.Piso.cod_piso FULL OUTER JOIN " +
                                                 "dbo.Sucursal ON dbo.Area.Piso_Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal AND dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa AND " +
                                                 "dbo.Oficina.Area_Piso_Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal AND dbo.Piso.Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal " +
                                                 "WHERE(dbo.Oficina.cod_oficina IS NOT NULL)", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string updateOficina(string cod_oficina, string cod_piso, string rut_empresa,
            string cod_sucursal, string cod_area, string des_oficina, string id_beacons, string path_video,
            string path_audio)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Oficina " +
                                                "set Area_Piso_cod_piso = @cod_piso," +
                                                "Area_Piso_Sucursal_Empresa_Rut_empresa = @rut_empresa, " +
                                                "Area_Piso_Sucursal_cod_sucursal = @cod_sucursal, " +
                                                "Area_cod_area = @cod_area, " +
                                                "des_oficina = @des_oficina, " +
                                                "id_beacons = @id_beacons, " +
                                                "path_video = @path_video, " +
                                                "path_audio = @path_audio " +
                                                "where cod_oficina = @cod_oficina", con);
            command.Parameters.Add("@cod_oficina", SqlDbType.NVarChar).Value = cod_oficina;
            command.Parameters.Add("@cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@cod_area", SqlDbType.NVarChar).Value = cod_area;
            command.Parameters.Add("@des_oficina", SqlDbType.NVarChar).Value = des_oficina;
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

        public string deleteOficina(string cod_oficina)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Oficina " +
                                                "where cod_oficina = @oficinaSeleccionada ", con);
            command.Parameters.Add("@oficinaSeleccionada", SqlDbType.NVarChar).Value = cod_oficina;
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

        public DataTable buscarOficina(string cod_oficina)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.Oficina.cod_oficina AS CodOficina, dbo.Empresa.nom_empresa AS Empresa, dbo.Sucursal.nom_sucursal AS Sucursal, dbo.Piso.des_piso AS Piso, dbo.Area.des_area AS Area, dbo.Oficina.des_oficina AS DesOficina, " +
                                                 "dbo.Oficina.id_beacons AS IdBeacons, dbo.Oficina.path_video AS Video, dbo.Oficina.path_audio AS Audio " +
                                                 " FROM dbo.Area FULL OUTER JOIN " +
                                                 "dbo.Empresa ON dbo.Area.Piso_Sucursal_Empresa_Rut_Empresa = dbo.Empresa.Rut_empresa FULL OUTER JOIN " +
                                                 "dbo.Oficina ON dbo.Area.cod_area = dbo.Oficina.Area_cod_area AND dbo.Empresa.Rut_empresa = dbo.Oficina.Area_Piso_Sucursal_Empresa_Rut_empresa FULL OUTER JOIN " +
                                                 "dbo.Piso ON dbo.Area.Piso_cod_piso = dbo.Piso.cod_piso AND dbo.Empresa.Rut_empresa = dbo.Piso.Sucursal_Empresa_Rut_empresa AND dbo.Oficina.Area_Piso_cod_piso = dbo.Piso.cod_piso FULL OUTER JOIN " +
                                                 "dbo.Sucursal ON dbo.Area.Piso_Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal AND dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa AND " +
                                                 "dbo.Oficina.Area_Piso_Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal AND dbo.Piso.Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal " +
                                                 "WHERE dbo.Oficina.cod_oficina = @cod_oficina", con);
            command.Parameters.Add("@cod_oficina", SqlDbType.NVarChar).Value = cod_oficina;
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

    }

}
