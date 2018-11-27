using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.Logica.Model
{
    public class EstadoCuentaModel
    {
        private string conn_string = new Conexion().getConexion();
        private OracleConnection _connection;

        public int EstadoCuentaPago(string rut, int id_curso)
        {
            this._connection = new OracleConnection();
            this._connection.ConnectionString = this.conn_string;
            this._connection.Open();
            int total = 0;
            try
            {
                // Create a Command object to call Get_Emp_No function.
                OracleCommand cmd = new OracleCommand("CalcularEstadoCuenta", this._connection);

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
                cmd.Parameters.Add("@rut", OracleDbType.Varchar2).Value = rut;
                cmd.Parameters.Add("@curso", OracleDbType.Int32).Value = id_curso;

                // Call function.
                cmd.ExecuteNonQuery();

                
                if (resultParam.Value != DBNull.Value)
                {
                    Console.WriteLine(resultParam.Value.GetType().ToString());
                    // int ret = resultParam.Value;
                    total = 0;
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
