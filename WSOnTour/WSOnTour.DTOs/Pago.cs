using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class Pago
    {
        private int id;
        private int abono;
        private string rut_alumno;
        private int id_pago;
        private DateTime fecha;

        public Pago()
        {

        }

        public Pago(int id, int abono, string rut_alumno, int id_pago, DateTime fecha)
        {
            this.Id = id;
            this.Abono = abono;
            this.Rut_alumno = rut_alumno;
            this.Id_pago = id_pago;
            this.Fecha = fecha;
        }

        public int Id { get => id; set => id = value; }
        public int Abono { get => abono; set => abono = value; }
        public string Rut_alumno { get => rut_alumno; set => rut_alumno = value; }
        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
