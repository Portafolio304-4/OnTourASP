using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;
using WSOnTour.DTOs;
using WSOnTour.Logica.Model;

namespace WSOnTour
{
    /// <summary>
    /// Descripción breve de wsUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public Usuario Authenticate(string user_name, string password)
        {
            Usuario usuario = new Usuario();
            usuario.User_name = user_name;
            usuario.Password = password;
            UsuarioModel query = new UsuarioModel(usuario);
            usuario = query.Authenticate();

            return usuario;
        }

        [WebMethod]
        public bool Create(string user_name, string password, int id_tipo_usuario, string email)
        {
            bool created = false;
            Usuario usuario = new Usuario();
            usuario.User_name = user_name;
            usuario.Password = password;
            usuario.Id_tipo_usuario = id_tipo_usuario;
            usuario.Email = email;
            UsuarioModel query = new UsuarioModel(usuario);
            created = query.Create();

            return created;
        }

    }
}
