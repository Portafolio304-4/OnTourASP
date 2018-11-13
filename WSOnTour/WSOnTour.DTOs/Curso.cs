using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.DTOs
{
    public class Curso
    {
        private int id;
        private string nivel;
        private string letra;
        private int grado;
        private int id_colegio;

        public Curso()
        {
            
        }

        public Curso(int id, string nivel, string letra, int grado, int id_colegio)
        {
            this.Id = id;
            this.Nivel = nivel;
            this.Letra = letra;
            this.Grado = grado;
            this.Id_colegio = id_colegio;
        }

        public int Id { get => id; set => id = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Letra { get => letra; set => letra = value; }
        public int Grado { get => grado; set => grado = value; }
        public int Id_colegio { get => id_colegio; set => id_colegio = value; }
    }
}
