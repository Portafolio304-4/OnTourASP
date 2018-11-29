using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOnTour.Logica
{
    public class Conexion
    {
        public string getConexion()
        {
            return "DATA SOURCE=DESKTOP-SP0C973:1521/xe;USER ID=ONTOUR;PASSWORD=123";
        }
    }
}
