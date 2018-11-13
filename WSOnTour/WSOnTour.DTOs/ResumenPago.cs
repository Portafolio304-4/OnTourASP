using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class ResumenPago
    {
        private DateTime fecha;
        private int abono;
        private string nombre_alumno;
        private string rut_alumno;
        private string curso;
        private string tipo;

        public ResumenPago()
        {
           
        }

        public ResumenPago(DateTime fecha, int abono, string nombre_alumno, string rut_alumno, string curso, string tipo)
        {
            this.fecha = fecha;
            this.abono = abono;
            this.nombre_alumno = nombre_alumno;
            this.rut_alumno = rut_alumno;
            this.curso = curso;
            this.tipo = tipo;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Abono { get => abono; set => abono = value; }
        public string Nombre_alumno { get => nombre_alumno; set => nombre_alumno = value; }
        public string Rut_alumno { get => rut_alumno; set => rut_alumno = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
