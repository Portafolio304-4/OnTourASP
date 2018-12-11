using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSOnTour.DTOs;
using Oracle.ManagedDataAccess.Client;



namespace WSOnTour.Logica.Model
{
    public class ContratoModel
    {
        private string conn_string = new Conexion().getConexion();
        private Contrato contrato;
        private OracleConnection _connection;

        public ContratoModel(Contrato contrato)
        {
            this.Contrato = contrato;
        }

        public Contrato Contrato { get => contrato; set => contrato = value; }


        public Contrato TraerContrato(int id_curso)
        {
            Contrato contrato = new Contrato();
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT * FROM CONTRATO WHERE id_curso =:id_curso";


            OracleCommand command = new OracleCommand(sql, this._connection);

            command.Parameters.Add(new OracleParameter("id_curso", OracleDbType.Int32)).Value = id_curso;
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                DateTime fecha_emision = reader.GetDateTime(2);
                int id_curso_1 = reader.GetInt32(3);
                string documento = "qwerty"; //reader.GetString(4);

                contrato = new Contrato(id, nombre, fecha_emision, id_curso_1, documento);
            }


            return contrato;
        }

        public List<Contrato> GetContratos(int id_curso)
        {
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            List<Contrato> lista_contrato = new List<Contrato>();

            string sql = "SELECT * FROM CONTRATO WHERE id_curso =:id_curso";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Contrato contrato = new Contrato();

            command.Parameters.Add(new OracleParameter("id_curso", OracleDbType.Int32)).Value = id_curso;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                DateTime fecha_emision = reader.GetDateTime(2);
                int id_curso_1 = reader.GetInt32(3);
                string documento = "asd"; //reader.GetString(4);


                contrato = new Contrato(id, nombre, fecha_emision, id_curso_1, documento);

                lista_contrato.Add(contrato);

            }

            this._connection.Close();
            command.Dispose();

            return lista_contrato;
        }



    }
}
