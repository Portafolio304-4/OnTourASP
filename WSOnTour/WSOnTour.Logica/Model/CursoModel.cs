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
    public class CursoModel
    {
        private string conn_string = new Conexion().getConexion();
        private Curso curso;
        private OracleConnection _connection;

        public CursoModel(Curso curso)
        {
            this.Curso = curso;
        }

        public Curso Curso { get => curso; set => curso = value; }

        public List<Curso> Read()
        {
            List<Curso> lista_cursos = new List<Curso>();

            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT id, nivel, letra, grado FROM CURSO WHERE id_colegio=:id";

            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = this._connection;
            command.Parameters.Add(new OracleParameter("id_colegio", OracleDbType.Int32)).Value = Curso.Id_colegio;
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nivel = reader.GetString(1);
                string letra = reader.GetString(2);
                int grado = reader.GetInt32(3);


                Curso curso = new Curso();
                curso.Id = id;
                curso.Nivel = nivel;
                curso.Letra = letra;
                curso.Grado = grado;
   
                lista_cursos.Add(curso);
            }

            this._connection.Close();
            command.Dispose();

            return lista_cursos;
        }

        public bool VerifyApoderadoInCurso(string rut)
        {
            bool found = false;
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT * FROM ALUMNO " +
                "WHERE rut_apoderado=:rut " +
                "AND id_curso=:id";

            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = this._connection;
            command.Parameters.Add(new OracleParameter("rut", OracleDbType.Varchar2)).Value = rut;
            command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = this.Curso.Id;
            OracleDataReader reader = command.ExecuteReader();
            if (reader.HasRows) {
                found = true;
            }
            this._connection.Close();
            command.Dispose();

            return found;

        }

        public int CountAlumnosInCurso()
        {
            int total = 0;
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            try
            {
                // Create a Command object to call Get_Emp_No function.
                OracleCommand cmd = new OracleCommand("AlumnosInCurso", this._connection);

                // CommandType is StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // ** Note: With Oracle, The return parameter must be added first.
                // Create result Parameter (Varchar2(50))
                OracleParameter resultParam = new OracleParameter("@Result", OracleDbType.Int32);

                // ReturnValue
                resultParam.Direction = ParameterDirection.ReturnValue;

                // Add to parameters
                cmd.Parameters.Add(resultParam);

                // Add parameter @p_Emp_Id and set value = 100.
                cmd.Parameters.Add("@curso", OracleDbType.Int32).Value = this.Curso.Id;

                // Call function.
                cmd.ExecuteNonQuery();


                if (resultParam.Value != DBNull.Value)
                {
                    total = int.Parse(resultParam.Value.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                this._connection.Close();
                this._connection.Dispose();
            }
            return total;

        }

    }
}
