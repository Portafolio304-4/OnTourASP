using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DatosMantenedor
{
    //https://germanaroca.wordpress.com/2009/09/15/validar-rut-c-sharp/

    public class ValidarRut
    {
        private int _numero;
        private string _digitoVerificador;

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public string DigitoVerificador
        {
            get { return this._digitoVerificador; }
            set { this._digitoVerificador = value.ToUpper(); }
        }

        public ValidarRut()
        {

        }

        public bool EntregarDatos(string rut)
        {
            string pattern = @"[0-9][-]";
            Regex currencyRegex = new Regex(pattern);
            if (currencyRegex.IsMatch(rut))
            {
                string[] resultado = rut.Split('-');
                this._numero = Convert.ToInt32(resultado[0]);
                this._digitoVerificador = resultado[1].ToUpper();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ObtenerValidezRut()
        {
            if (this._digitoVerificador == CalcularDigitoVerificador(this._numero))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private string CalcularDigitoVerificador(int numero)
        {
            string cadenaNumero = numero.ToString();
            int calculador = 0;

            int[] factores = { 3, 2, 7, 6, 5, 4, 3, 2 };
            int indiceFactor = factores.Length - 1;

            for (int i = cadenaNumero.Length - 1; i >= 0; i--)
            {
                calculador = calculador + (factores[indiceFactor] * int.Parse(cadenaNumero.Substring(i, 1)));
                indiceFactor--;
            }

            string digitoVerificador;
            int resultado = 11 - (calculador % 11);

            if (resultado == 11)
            {
                digitoVerificador = "0";
            }
            else if (resultado == 10)
            {
                digitoVerificador = "K";
            }
            else
            {
                digitoVerificador = resultado.ToString();
            }

            return digitoVerificador;
        }
    }

}
