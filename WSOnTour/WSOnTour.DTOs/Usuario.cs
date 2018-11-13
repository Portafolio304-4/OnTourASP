using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class Usuario
    {
        private int id;
        private string user_name;
        private string password;
        private int id_tipo_usuario;
        private string email;

        public Usuario()
        {
            
        }

        public Usuario(int id, string user_name, string password, int id_tipo_usuario, string email)
        {
            this.Id = id;
            this.User_name = user_name;
            this.Password = password;
            this.Id_tipo_usuario = id_tipo_usuario;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public int Id_tipo_usuario { get => id_tipo_usuario; set => id_tipo_usuario = value; }
        public string Email { get => email; set => email = value; }
    }
}
