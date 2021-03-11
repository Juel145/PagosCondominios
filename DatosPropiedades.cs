using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagosCondominios
{
    class DatosPropiedades
    {
        string numeroCasa;
        int dpi;
        float cuotaMantenimiento;

        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public int Dpi { get => dpi; set => dpi = value; }
        public float CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
