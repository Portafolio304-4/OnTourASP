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
    public class CRUDUsuario
    {
        public string insertUsuario(string rut_usuario, string rut_empresa, string cod_sucursal, string cod_perfil,
            string cod_tipoDiscapacidad, string ape_paterno, string ape_materno, string nombres, string num_celular, string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("insert into Usuario (rut_usuario,Sucursal_Empresa_Rut_Empresa,Sucursal_cod_sucursal,Perfil_cod_perfil, " +
                "Tipo_discapacidad_cod_tipoDiscapacidad,ape_paterno,ape_materno,nombres,num_celular,email) values (" +
                "@rut_usuario,@rut_empresa,@cod_sucursal,@cod_perfil,@cod_tipoDiscapacidad,@ape_paterno,@ape_materno,@nombres, " +
                "@num_celular,@email);", con);
            command.Parameters.Add("@rut_usuario", SqlDbType.NVarChar).Value = rut_usuario;
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@cod_perfil", SqlDbType.NVarChar).Value = cod_perfil;
            command.Parameters.Add("@cod_tipoDiscapacidad", SqlDbType.NVarChar).Value = cod_tipoDiscapacidad;
            command.Parameters.Add("@ape_paterno", SqlDbType.NVarChar).Value = ape_paterno;
            command.Parameters.Add("@ape_materno", SqlDbType.NVarChar).Value = ape_materno;
            command.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = nombres;
            command.Parameters.Add("@num_celular", SqlDbType.NVarChar).Value = num_celular;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
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

        public DataTable ListarTodoUsuarios()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT Usuario.rut_usuario AS RutUsuario, Empresa.nom_empresa AS NombreEmpresa, Sucursal.nom_sucursal AS Sucursal, dbo.Perfil.des_perfil AS Perfil, " +
                         "Tipo_Discapacidad.des_tipoDiscapacidad AS Discapacidad, Usuario.ape_paterno, Usuario.ape_materno, Usuario.nombres, Usuario.num_celular, Usuario.email " +
                           "FROM Empresa FULL OUTER JOIN " +
                         "Sucursal ON Empresa.Rut_empresa = Sucursal.Empresa_Rut_Empresa FULL OUTER JOIN " +
                         "Usuario ON Empresa.Rut_empresa = Usuario.Sucursal_Empresa_Rut_Empresa AND Sucursal.cod_sucursal = Usuario.Sucursal_cod_sucursal FULL OUTER JOIN " +
                         "Perfil ON Usuario.Perfil_cod_perfil = Perfil.cod_perfil FULL OUTER JOIN " +
                         "Tipo_Discapacidad ON dbo.Usuario.Tipo_discapacidad_cod_tipoDiscapacidad = Tipo_Discapacidad.cod_tipoDiscapacidad " +
                         "where Usuario.rut_usuario IS NOT NULL ;"
                , con);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;

        }

        public string deleteUsuario(string rutUsuario)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Delete From Usuario " +
                                                "where rut_usuario = @rut_usuario ", con);
            command.Parameters.Add("@rut_usuario", SqlDbType.NVarChar).Value = rutUsuario;
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

        public string updateUsuario(string rut_usuario, string rut_empresa, string cod_sucursal, string cod_perfil,
            string cod_tipoDiscapacidad, string ape_paterno, string ape_materno, string nombres, string num_celular, string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("Update Usuario " +
                                                "set Sucursal_Empresa_Rut_Empresa = @rut_empresa," +
                                                "Sucursal_cod_sucursal = @cod_sucursal, " +
                                                "Perfil_cod_perfil = @cod_perfil, " +
                                                "Tipo_discapacidad_cod_tipoDiscapacidad = @cod_tipoDiscapacidad, " +
                                                "ape_paterno = @ape_paterno, " +
                                                "ape_materno = @ape_materno, " +
                                                "nombres = @nombres, " +
                                                "num_celular = @num_celular, " +
                                                "email = @email " +
                                                "where rut_usuario = @rut_usuario", con);
            command.Parameters.Add("@rut_empresa", SqlDbType.NVarChar).Value = rut_empresa;
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar).Value = cod_sucursal;
            command.Parameters.Add("@cod_perfil", SqlDbType.NVarChar).Value = cod_perfil;
            command.Parameters.Add("@cod_tipoDiscapacidad", SqlDbType.NVarChar).Value = cod_tipoDiscapacidad;
            command.Parameters.Add("@ape_paterno", SqlDbType.NVarChar).Value = ape_paterno;
            command.Parameters.Add("@ape_materno", SqlDbType.NVarChar).Value = ape_materno;
            command.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = nombres;
            command.Parameters.Add("@num_celular", SqlDbType.NVarChar).Value = num_celular;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@rut_usuario", SqlDbType.NVarChar).Value = rut_usuario;

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

        public DataTable buscarUsuario(string rut)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT Usuario.rut_usuario AS RutUsuario, Empresa.nom_empresa AS NombreEmpresa, Sucursal.nom_sucursal AS Sucursal, dbo.Perfil.des_perfil AS Perfil, " +
                       "Tipo_Discapacidad.des_tipoDiscapacidad AS Discapacidad, Usuario.ape_paterno, Usuario.ape_materno, Usuario.nombres, Usuario.num_celular, Usuario.email " +
                         "FROM Empresa FULL OUTER JOIN " +
                       "Sucursal ON Empresa.Rut_empresa = Sucursal.Empresa_Rut_Empresa FULL OUTER JOIN " +
                       "Usuario ON Empresa.Rut_empresa = Usuario.Sucursal_Empresa_Rut_Empresa AND Sucursal.cod_sucursal = Usuario.Sucursal_cod_sucursal FULL OUTER JOIN " +
                       "Perfil ON Usuario.Perfil_cod_perfil = Perfil.cod_perfil FULL OUTER JOIN " +
                       "Tipo_Discapacidad ON dbo.Usuario.Tipo_discapacidad_cod_tipoDiscapacidad = Tipo_Discapacidad.cod_tipoDiscapacidad " +
                       "where Usuario.rut_usuario = @rut_usuario;"
              , con);
            command.Parameters.Add("@rut_usuario", SqlDbType.NVarChar).Value = rut;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public Usuario obtenerUsuario(string nombre, string clave)
        {
            Usuario auxUsuario = new Usuario();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion());
            con.Open();
            SqlCommand command = new SqlCommand("SELECT        dbo.Usuario.rut_usuario AS RutUsuario, dbo.Empresa.nom_empresa AS NombreEmpresa, dbo.Sucursal.nom_sucursal AS Sucursal, dbo.Perfil.des_perfil AS Perfil, " +
                                                "dbo.Tipo_Discapacidad.des_tipoDiscapacidad AS Discapacidad, dbo.Usuario.ape_paterno AS ApePa, dbo.Usuario.ape_materno AS ApeMa, dbo.Usuario.nombres AS Nombres, dbo.Usuario.num_celular AS Celular, "+
                                                "dbo.Usuario.email AS Email, dbo.Pass.clave AS Clave "+
                                                "FROM            dbo.Empresa INNER JOIN " +
                                                "dbo.Sucursal ON dbo.Empresa.Rut_empresa = dbo.Sucursal.Empresa_Rut_Empresa INNER JOIN "+
                                                "dbo.Usuario ON dbo.Empresa.Rut_empresa = dbo.Usuario.Sucursal_Empresa_Rut_Empresa AND dbo.Sucursal.cod_sucursal = dbo.Usuario.Sucursal_cod_sucursal INNER JOIN "+
                                                "dbo.Perfil ON dbo.Usuario.Perfil_cod_perfil = dbo.Perfil.cod_perfil INNER JOIN "+
                                                "dbo.Pass ON dbo.Usuario.rut_usuario = dbo.Pass.Usuario_Rut_Usuario INNER JOIN "+
                                                "dbo.Tipo_Discapacidad ON dbo.Usuario.Tipo_discapacidad_cod_tipoDiscapacidad = dbo.Tipo_Discapacidad.cod_tipoDiscapacidad "+
                                                "WHERE dbo.Pass.clave = @clave AND dbo.Usuario.nombres = @nombre"
              , con);
            command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            command.Parameters.Add("@clave", SqlDbType.NVarChar).Value = clave;
            
            DataTable dt = new DataTable();
            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                con.Close();
                auxUsuario.RutUsuario = (String)dt.Rows[0]["RutUsuario"];
                auxUsuario.Empresa = (String)dt.Rows[0]["NombreEmpresa"];
                auxUsuario.Sucursal = (String)dt.Rows[0]["Sucursal"];
                auxUsuario.Perfil = (String)dt.Rows[0]["Perfil"];
                auxUsuario.TipoDiscapacidad = (String)dt.Rows[0]["Discapacidad"];
                auxUsuario.ApellidoPaterno = (String)dt.Rows[0]["ApePa"];
                auxUsuario.ApellidoMaterno = (String)dt.Rows[0]["ApeMA"];
                auxUsuario.Nombre = (String)dt.Rows[0]["Nombres"];
                auxUsuario.Num_celular = (String)dt.Rows[0]["Celular"];
                auxUsuario.Correo = (String)dt.Rows[0]["Email"];
                auxUsuario.Clave = (String)dt.Rows[0]["Clave"];
            }
            catch (SqlException odbcEx)
            {
                auxUsuario.RutUsuario = odbcEx.Number.ToString();
            }
            catch (Exception e)
            {
                auxUsuario.RutUsuario = e.Message;
            }            

            return auxUsuario;
        }

    }

}
