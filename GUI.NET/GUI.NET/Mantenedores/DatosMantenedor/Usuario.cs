using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMantenedor
{
    public class Usuario
    {
        string nombre;
        string rutUsuario;
        string apellidoPaterno;
        string apellidoMaterno;
        string num_celular;
        string correo;
        string empresa;
        string tipoDiscapacidad;
        string perfil;
        string sucursal;
        string clave;
        public Usuario() { }
        public string Nombre { get => nombre; set => nombre = value; }
        public string RutUsuario { get => rutUsuario; set => rutUsuario = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Num_celular { get => num_celular; set => num_celular = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string TipoDiscapacidad { get => tipoDiscapacidad; set => tipoDiscapacidad = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public string Sucursal { get => sucursal; set => sucursal = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
