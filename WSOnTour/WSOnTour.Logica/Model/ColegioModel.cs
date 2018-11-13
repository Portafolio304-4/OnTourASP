using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSOnTour.DTOs;

namespace WSOnTour.Logica.Model
{
    public class ColegioModel
    {
        private string conn_string = new Conexion().getConexion();
        private Colegio colegio;
        private OracleConnection _connection;

        public ColegioModel(Colegio colegio)
        {
            this.Colegio = colegio;
        }

        public Colegio Colegio { get => colegio; set => colegio = value; }

        public List<Colegio> Read()
        {
            List<Colegio> lista_colegios = new List<Colegio>();

            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT id, nombre FROM COLEGIO";

            OracleCommand command = new OracleCommand(sql, this._connection);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);

                Colegio colegio = new Colegio();
                colegio.Id = id;
                colegio.Nombre = nombre;
                lista_colegios.Add(colegio);
            }

            this._connection.Close();
            command.Dispose();

            return lista_colegios;;
        }
    }
}
