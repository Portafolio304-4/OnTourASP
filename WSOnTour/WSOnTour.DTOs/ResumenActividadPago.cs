using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class ResumenActividadPago
    {
        private DateTime fecha;
        private string curso;
        private string descripcion;
        private int monto;


        public ResumenActividadPago()
        {

        }

        public ResumenActividadPago(DateTime fecha, string curso, string descripcion, int monto)
        {
            this.Fecha = fecha;
            this.Curso = curso;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
