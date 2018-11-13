using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class Alumno
    {
        private string rut;
        private string nombre_completo;
        private string ap_paterno;
        private string ap_materno;
        private int id_curso;
        private string rut_apoderado;


        public Alumno()
        {
            
        }

        public Alumno(string rut, string nombre_completo, string ap_paterno, string ap_materno, int id_curso, string rut_apoderado)
        {
            this.Rut = rut;
            this.Nombre_completo = nombre_completo;
            this.Ap_paterno = ap_paterno;
            this.Ap_materno = ap_materno;
            this.Id_curso = id_curso;
            this.Rut_apoderado = rut_apoderado;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Ap_paterno { get => ap_paterno; set => ap_paterno = value; }
        public string Ap_materno { get => ap_materno; set => ap_materno = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Rut_apoderado { get => rut_apoderado; set => rut_apoderado = value; }
    }
}
