using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagosCondominios
{
    class DatosGenerales
    {
        string nombre;
        string apellido;
        string numeroCasa;
        float cuotaMatenimiento;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public float CuotaMatenimiento { get => cuotaMatenimiento; set => cuotaMatenimiento = value; }
    }
}
