using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSOnTour.DTOs;

namespace WSOnTour.Logica.Model
{
    public class ApoderadoModel
    {
        private string conn_string = new Conexion().getConexion();
        private Apoderado apoderado;
        private OracleConnection _connection;

        public ApoderadoModel(Apoderado apoderado)
        {
            this.Apoderado = apoderado;
        }

        public Apoderado Apoderado { get => apoderado; set => apoderado = value; }

        public Apoderado ReadByUsername()
        { 

            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT * FROM APODERADO " +
                "WHERE rut=:user_name";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Apoderado apoderado = new Apoderado();
            command.Parameters.Add(new OracleParameter("user_name", OracleDbType.Varchar2)).Value = Apoderado.Rut;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string rut = reader.GetString(0);
                string nombre_completo = reader.GetString(1);
                string ap_paterno = reader.GetString(2);
                string ap_materno = reader.GetString(3);

                apoderado = new Apoderado(rut, nombre_completo, ap_paterno, ap_materno);
            }

            this._connection.Close();
            command.Dispose();

            return apoderado;
        }
        public List<Curso> GetCursos()
        { 
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            List<Curso> lista_curso = new List<Curso>();

            string sql = "SELECT c.id, c.nivel, c.letra, c.grado " +
                "FROM ALUMNO a " +
                "JOIN CURSO c " +
                "ON(a.id_curso = c.id) " +
                "WHERE a.rut_apoderado=:rut";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Apoderado apoderado = new Apoderado();
            command.Parameters.Add(new OracleParameter("rut", OracleDbType.Varchar2)).Value = Apoderado.Rut;
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

                lista_curso.Add(curso);

            }

            this._connection.Close();
            command.Dispose();

            return lista_curso;
        }

        public List<Curso> GetCursosByColegio(int id_colegio)
        {
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            List<Curso> lista_curso = new List<Curso>();

            string sql = "SELECT c.id, c.nivel, c.letra, c.grado " +
                "FROM ALUMNO a " +
                "JOIN CURSO c " +
                "ON(a.id_curso = c.id) " +
                "WHERE a.rut_apoderado=:rut " +
                "AND c.id_colegio=:id_colegio";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Apoderado apoderado = new Apoderado();
            command.Parameters.Add(new OracleParameter("rut", OracleDbType.Varchar2)).Value = Apoderado.Rut;
            command.Parameters.Add(new OracleParameter("rut", OracleDbType.Int32)).Value = id_colegio;
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

                lista_curso.Add(curso);

            }

            this._connection.Close();
            command.Dispose();

            return lista_curso;
        }


        public List<Alumno> GetAlumnosInCursos(int id)
        {
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            List<Alumno> lista_alumnos = new List<Alumno>();

            string sql = "SELECT * FROM ALUMNO " +
                "WHERE rut_apoderado=:rut " +
                "AND id_curso=:id_curso";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Apoderado apoderado = new Apoderado();
            command.Parameters.Add(new OracleParameter("rut", OracleDbType.Varchar2)).Value = Apoderado.Rut;
            command.Parameters.Add(new OracleParameter("id_curso", OracleDbType.Int32)).Value = id;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string rut = reader.GetString(0);
                string nombre_completo = reader.GetString(1);
                string ap_paterno = reader.GetString(2);
                string ap_materno = reader.GetString(3);
                int id_curso = reader.GetInt32(4);
                string rut_apoderado = reader.GetString(0);


                Alumno alumno = new Alumno(rut,nombre_completo,ap_paterno,ap_materno,id_curso,rut_apoderado);

                lista_alumnos.Add(alumno);

            }

            this._connection.Close();
            command.Dispose();

            return lista_alumnos;
        }
        public Alumno GetAlumnoByRut(string rut_alumno)
        {
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            Alumno alumno = new Alumno();

            string sql = "SELECT * FROM ALUMNO " +
                "WHERE rut_apoderado=:rut " +
                "AND rut=:rut_alumno";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Apoderado apoderado = new Apoderado();
            command.Parameters.Add(new OracleParameter("rut", OracleDbType.Varchar2)).Value = Apoderado.Rut;
            command.Parameters.Add(new OracleParameter("rut_alumno", OracleDbType.Varchar2)).Value = rut_alumno;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string rut = reader.GetString(0);
                string nombre_completo = reader.GetString(1);
                string ap_paterno = reader.GetString(2);
                string ap_materno = reader.GetString(3);
                int id_curso = reader.GetInt32(4);
                string rut_apoderado = reader.GetString(0);

                alumno = new Alumno(rut, nombre_completo, ap_paterno, ap_materno, id_curso, rut_apoderado);

      

            }

            this._connection.Close();
            command.Dispose();

            return alumno;
        }
    }
}
