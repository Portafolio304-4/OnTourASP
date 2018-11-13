using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class Apoderado
    {
        private string rut;
        private string nombre_completo;
        private string ap_paterno;
        private string ap_materno;

        public Apoderado()
        {
         
        }

        public Apoderado(string rut, string nombre_completo, string ap_paterno, string ap_materno)
        {
            this.Rut = rut;
            this.Nombre_completo = nombre_completo;
            this.Ap_paterno = ap_paterno;
            this.Ap_materno = ap_materno;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Ap_paterno { get => ap_paterno; set => ap_paterno = value; }
        public string Ap_materno { get => ap_materno; set => ap_materno = value; }
    }
}
