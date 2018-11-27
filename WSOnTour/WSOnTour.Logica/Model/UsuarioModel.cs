using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSOnTour.DTOs;

namespace WSOnTour.Logica.Model
{
    public class UsuarioModel
    {
        private string conn_string = new Conexion().getConexion();
        private Usuario usuario;
        private OracleConnection _connection;

        public UsuarioModel(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public Usuario Authenticate()
        {
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();
            string sql = "SELECT * FROM USUARIO WHERE user_name=:user_name";
            // definir objeto que ejecutara el comando
            OracleCommand command = new OracleCommand(sql, this._connection);
            // definir objeto de lectura para el retorno de la query
            command.Parameters.Add(new OracleParameter("user_name", OracleDbType.Varchar2)).Value = this.Usuario.User_name;
            OracleDataReader reader = command.ExecuteReader();
            // recorrer reader
            Usuario usuario_a_comparar = new Usuario();
            while (reader.Read())
            {
                usuario_a_comparar.Id = reader.GetInt32(0);
                usuario_a_comparar.User_name = reader.GetString(1);
                usuario_a_comparar.Password = reader.GetString(2);
                usuario_a_comparar.Id_tipo_usuario = reader.GetInt32(3);
                usuario_a_comparar.Email = reader.GetString(5);


            }
            this._connection.Close();
            command.Dispose();
            if (usuario_a_comparar.Id != 0)
            {
                // hash password
                bool correct_password = Seguridad.UnSaltPassword(usuario_a_comparar.Password, this.Usuario.Password);

                if (!correct_password)
                {
                    this.Usuario.Id = 0;
                }
                else
                {
                    this.Usuario = usuario_a_comparar;
                }
            }
            
           
            return this.Usuario;

        }

        public bool Create()
        {
            bool created = false;
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "INSERT INTO USUARIO " +
                "(user_name,password,id_tipo_usuario,email)" +
                " VALUES" +
                "(:user_name,:password,:id_tipo_usuario,:email)";

            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = this._connection;

            command.Parameters.Add(new OracleParameter("user_name", OracleDbType.Varchar2)).Value = this.Usuario.User_name;

            // hash password 
            this.Usuario.Password = Seguridad.SaltPassword(this.Usuario.Password);
            command.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = this.Usuario.Password;
            command.Parameters.Add(new OracleParameter("id_tipo_usuario", OracleDbType.Int32)).Value = this.Usuario.Id_tipo_usuario;
            command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2)).Value = this.Usuario.Email;

            try
            {
                int rowsUpdated = command.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {
                    created = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            this._connection.Close();
            command.Dispose();

            return created;
        }

        public bool ReadById()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete() {
            return true;
        }





    }
}
