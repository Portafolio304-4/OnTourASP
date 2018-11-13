using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSOnTour.DTOs;

namespace WSOnTour.Logica.Model
{
    public class ActividadPagoModel
    {
        private string conn_string = new Conexion().getConexion();
        private ActividadPago actividad_pago;
        private OracleConnection _connection;

        public ActividadPagoModel(ActividadPago actividad_pago)
        {
            this.Actividad_pago = actividad_pago;
        }

        public ActividadPago Actividad_pago { get => this.actividad_pago; set => this.actividad_pago = value; }


        public bool CreatePaid()
        {

            bool created = false;
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "INSERT INTO ACTIVIDAD_PAGO " +
                "(descripcion,monto,id_curso,fecha) " +
                "VALUES (:descripcion,:monto,:id_curso,:fecha)";

            OracleCommand command = new OracleCommand(sql, this._connection);
            Pago pago = new Pago();
            command.Parameters.Add(new OracleParameter("descripcion", OracleDbType.Varchar2)).Value = this.Actividad_pago.Descripcion;
            command.Parameters.Add(new OracleParameter("monto", OracleDbType.Int32)).Value = this.Actividad_pago.Monto;
            command.Parameters.Add(new OracleParameter("id_curso", OracleDbType.Int32)).Value = this.Actividad_pago.Id_curso;
            command.Parameters.Add(new OracleParameter("fecha", OracleDbType.Date)).Value = this.Actividad_pago.Fecha;

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

        public List<ResumenActividadPago> GetAllByCurso()
        {
            List<ResumenActividadPago> lista_pagos = new List<ResumenActividadPago>();
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();

            string sql = "SELECT " +
                "ac.fecha, " +
                "c.nivel || ' ' || c.grado || c.letra, " +
                "ac.descripcion, " +
                "ac.monto " +
                "FROM " +
                "CURSO c " +
                "JOIN ACTIVIDAD_PAGO AC " +
                "ON(c.id = ac.id_curso) " +
                "WHERE c.id=:id_curso";


            OracleCommand command = new OracleCommand(sql, this._connection);
            ResumenActividadPago pago = new ResumenActividadPago();
            command.Parameters.Add(new OracleParameter("id_curso", OracleDbType.Int32)).Value = actividad_pago.Id_curso;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime fecha = reader.GetDateTime(0);
                string curso = reader.GetString(1);
                string descripcion = reader.GetString(2);
                int monto = reader.GetInt32(3);

                pago = new ResumenActividadPago(fecha, curso, descripcion, monto);

                lista_pagos.Add(pago);
            }

            this._connection.Close();
            command.Dispose();

            return lista_pagos;
        }
    }
}
