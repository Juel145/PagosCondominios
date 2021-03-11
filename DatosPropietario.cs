using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagosCondominios
{
    class DatosPropietario
    {
       
        string nombre;
        string apellido;
        int dpi;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dpi { get => dpi; set => dpi = value; }
    }
}
