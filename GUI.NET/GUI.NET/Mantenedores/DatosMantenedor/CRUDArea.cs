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

    public class CRUDArea
    {
        public string insertArea(string cod_area, string cod_sucursal, string rut_empresa,
            string cod_piso, string des_area, string id_beacons, string path_video, string path_audio)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Area (cod_area,Piso_Sucursal_cod_sucursal,Piso_Sucursal_Empresa_Rut_Empresa,Piso_cod_piso, " +
                "des_area,id_beacons,path_video,path_audio) " +
                "values (@cod_area,@Piso_Sucursal_cod_sucursal,@Piso_Sucursal_Empresa_Rut_Empresa,@Piso_cod_piso,@des_area,@id_beacons,@path_video,@path_audio );", con);

            command.Parameters.Add("@cod_area", SqlDbType.NVarChar).Value = cod_area;
            command.Parameters.Add("@Piso_Sucursal_cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@Piso_Sucursal_Empresa_Rut_Empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@Piso_cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            command.Parameters.Add("@des_area", SqlDbType.NVarChar).Value = des_area;
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

        public DataTable ListarArea()
        {
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            string consulta = "select cod_area, des_area from Area ;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ListarTodoArea()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT  dbo.Area.cod_area AS CodigoArea, dbo.Area.des_area AS DescArea, dbo.Empresa.nom_empresa AS NomEmpresa, dbo.Sucursal.nom_sucursal AS NomSucursal, dbo.Piso.des_piso AS DesPiso, dbo.Area.id_beacons AS idBeacons, " +
                         " dbo.Area.path_video AS pathVideo, dbo.Area.path_audio AS pathAudio " +
                         " FROM dbo.Area FULL OUTER  JOIN " +
                         " dbo.Empresa ON dbo.Area.Piso_Sucursal_Empresa_Rut_Empresa = dbo.Empresa.Rut_empresa FULL OUTER JOIN " +
                         " dbo.Piso ON dbo.Area.Piso_cod_piso = dbo.Piso.cod_piso AND dbo.Empresa.Rut_empresa = dbo.Piso.Sucursal_Empresa_Rut_empresa FULL OUTER JOIN " +
                         " dbo.Sucursal ON dbo.Area.Piso_Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal AND dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa AND dbo.Piso.Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal " +
                         " WHERE (dbo.Area.cod_area IS NOT NULL) ", con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string deleteArea(string cod_area)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Area " +
                                                "where cod_area = @areaSeleccionada ", con);
            command.Parameters.Add("@areaSeleccionada", SqlDbType.NVarChar).Value = cod_area;
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

        public string updateArea(string cod_area, string cod_sucursal, string rut_empresa,
            string cod_piso, string des_area, string id_beacons, string path_video, string path_audio)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Area " +
                                                "set Piso_Sucursal_cod_sucursal = @cod_sucursal," +
                                                "Piso_Sucursal_Empresa_Rut_Empresa = @rut_empresa, " +
                                                "Piso_cod_piso = @cod_piso, " +
                                                "des_area = @des_area, " +
                                                "id_beacons = @id_beacons, " +
                                                "path_video = @path_video, " +
                                                "path_audio = @path_audio " +
                                                "where cod_area = @cod_area ", con);

            command.Parameters.Add("@cod_area", SqlDbType.NVarChar).Value = cod_area;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@cod_piso", SqlDbType.NVarChar).Value = cod_piso;
            command.Parameters.Add("@des_area", SqlDbType.NVarChar).Value = des_area;
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

        public DataTable buscarArea(string cod_area)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Area.cod_area AS CodigoArea, dbo.Area.des_area AS DescArea, dbo.Empresa.nom_empresa AS NomEmpresa, dbo.Sucursal.nom_sucursal AS NomSucursal, dbo.Piso.des_piso AS DesPiso, dbo.Area.id_beacons AS idBeacons, " +
                         " dbo.Area.path_video AS pathvideo, dbo.Area.path_audio AS pathaudio " +
                         " FROM dbo.Area FULL OUTER  JOIN " +
                         " dbo.Empresa ON dbo.Area.Piso_Sucursal_Empresa_Rut_Empresa = dbo.Empresa.Rut_empresa FULL OUTER JOIN " +
                         " dbo.Piso ON dbo.Area.Piso_cod_piso = dbo.Piso.cod_piso AND dbo.Empresa.Rut_empresa = dbo.Piso.Sucursal_Empresa_Rut_empresa FULL OUTER JOIN " +
                         " dbo.Sucursal ON dbo.Area.Piso_Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal AND dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa AND dbo.Piso.Sucursal_cod_sucursal = dbo.Sucursal.cod_sucursal " +
                         " WHERE dbo.Area.cod_area = @cod_area ; ", con);
            command.Parameters.Add("@cod_area", SqlDbType.NVarChar).Value = cod_area;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }


    }

}
