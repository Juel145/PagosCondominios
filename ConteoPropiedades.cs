using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagosCondominios
{
    class ConteoPropiedades
    {
        string nombre;
        string apellido;
        int conteo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Conteo { get => conteo; set => conteo = value; }
    }
}
