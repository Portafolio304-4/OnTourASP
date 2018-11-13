using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSOnTour.DTOs;

namespace WSOnTour.Logica.Model
{
    public class PagoModel
    {
        private string conn_string = new Conexion().getConexion();
        private Pago pago;
        private OracleConnection _connection;

        public PagoModel(Pago pago)
        {
            this.Pago = pago;
        }

        public Pago Pago { get => pago; set => pago = value; }

        
        public List<Pago> GetAllByAlumno()
        {
            List<Pago> lista_pagos = new List<Pago>();
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT * FROM Pago " +
                "WHERE rut_alumno=:rut_alumno";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Pago pago = new Pago();
            command.Parameters.Add(new OracleParameter("rut_alumno", OracleDbType.Varchar2)).Value = Pago.Rut_alumno;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int abono = reader.GetInt32(1);
                string rut_alumno = reader.GetString(2);
                int id_pago = reader.GetInt32(3);
                DateTime fecha = reader.GetDateTime(4);

                pago = new Pago(id, abono, rut_alumno, id_pago, fecha);

                lista_pagos.Add(pago);
            }

            this._connection.Close();
            command.Dispose();

            return lista_pagos;
        }

        
        public List<Pago> GetAllByCurso(int id_curso)
        {
            List<Pago> lista_pagos = new List<Pago>();
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT * FROM " +
                "Pago p " +
                "JOIN ALUMNO a " +
                "ON(p.rut_alumno = a.rut) " +
                "WHERE a.id_curso=:id_curso";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Pago pago = new Pago();
            command.Parameters.Add(new OracleParameter("id_curso", OracleDbType.Int32)).Value = id_curso;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int abono = reader.GetInt32(1);
                string rut_alumno = reader.GetString(2);
                int id_pago = reader.GetInt32(3);
                DateTime fecha = reader.GetDateTime(4);

                pago = new Pago(id, abono, rut_alumno, id_pago, fecha);

                lista_pagos.Add(pago);
            }

            this._connection.Close();
            command.Dispose();

            return lista_pagos;
        }

        public List<ResumenPago> GetAllByApoderado(string rut_apoderado)
        {
            List<ResumenPago> lista_pagos = new List<ResumenPago>();
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT " +
                "p.fecha, " +
                "p.abono, " +
                "a.nombre_completo || ' ' || a.ap_paterno || ' ' || a.ap_materno, a.rut, " +
                "c.nivel || ' ' || c.grado || c.letra, " +
                "tp.nombre " +
                "FROM " +
                "ALUMNO a " +
                "JOIN CURSO c " +
                "ON(a.id_curso = c.id) " +
                "JOIN PAGO p " +
                "ON(p.rut_alumno = a.rut) " +
                "JOIN TIPO_PAGO TP " +
                "ON (p.id_tipo_pago = tp.id)" +
                "WHERE a.rut_apoderado=:rut_apoderado";


            OracleCommand command = new OracleCommand(sql, this._connection);
            ResumenPago pago = new ResumenPago();
            command.Parameters.Add(new OracleParameter("rut_apoderado", OracleDbType.Varchar2)).Value = rut_apoderado;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime fecha = reader.GetDateTime(0);
                int abono = reader.GetInt32(1);
                string nombre_alumno = reader.GetString(2);
                string rut_alumno = reader.GetString(3);
                string curso = reader.GetString(4);
                string tipo = reader.GetString(5);

                pago = new ResumenPago(fecha, abono, nombre_alumno, rut_alumno, curso, tipo);

                lista_pagos.Add(pago);
            }

            this._connection.Close();
            command.Dispose();

            return lista_pagos;
        }


        public bool CreatePaid()
        {

            bool created = false;
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "INSERT INTO PAGO " +
                "(abono,rut_alumno,id_tipo_pago,fecha) " +
                "VALUES (:abono,:rut_alumno,:id_tipo_pago,:fecha)";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Pago pago = new Pago();
            command.Parameters.Add(new OracleParameter("abono", OracleDbType.Int32)).Value = this.Pago.Abono;
            command.Parameters.Add(new OracleParameter("rut_alumno", OracleDbType.Varchar2)).Value = this.Pago.Rut_alumno;
            command.Parameters.Add(new OracleParameter("id_tipo_pago", OracleDbType.Int32)).Value = this.Pago.Id_pago;
            command.Parameters.Add(new OracleParameter("fecha", OracleDbType.Date)).Value = this.Pago.Fecha;

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
    }
}
