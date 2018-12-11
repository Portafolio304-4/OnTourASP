using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class Contrato
    {
        private int id_contrato;
        private string nombre;
        private DateTime fecha_emision;
        private int id_curso;
        private string documento;

        public Contrato()
        {

        }

        public Contrato(int id_contrato, string nombre, DateTime fecha_emision, int id_curso, string documento)
        {
            this.Id_contrato = id_contrato;
            this.Nombre = nombre;
            this.Fecha_emision = fecha_emision;
            this.Id_curso = id_curso;
            this.Documento = documento;


        }

        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
