using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class ActividadPago
    {
        private int id;
        private string descripcion;
        private int monto;
        private int id_curso;
        private DateTime fecha;
        
        public ActividadPago()
        {
        }

        public ActividadPago(int id, string descripcion, int monto, int Id_curso, DateTime fecha)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Monto = monto;
            this.Id_curso = Id_curso;
            this.Fecha = fecha;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
