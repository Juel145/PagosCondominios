using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagosCondominios
{
    public partial class Form1 : Form
    {
        List<DatosGenerales> datosGenerales = new List<DatosGenerales>();
        List<DatosPropiedades> datosPropiedades = new List<DatosPropiedades>();
        List<DatosPropietario> datosPropietarios = new List<DatosPropietario>();
        public Form1()
        {
            InitializeComponent();
        }
        void LeerPropietarios()
        {
            FileStream stream = new FileStream("datosPropietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                DatosPropietario datosPropietarioTemp= new DatosPropietario();
                
                datosPropietarioTemp.Nombre = reader.ReadLine();
                datosPropietarioTemp.Apellido = reader.ReadLine();
                datosPropietarioTemp.Dpi = Convert.ToInt32(reader.ReadLine());
                datosPropietarios.Add(datosPropietarioTemp);

            }
            reader.Close();

        }
        void LeerPropiedades()
        {
            FileStream stream = new FileStream("datosPropiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                DatosPropiedades datosPropiedadesTemp = new DatosPropiedades();
                datosPropiedadesTemp.NumeroCasa = reader.ReadLine();
                datosPropiedadesTemp.Dpi = Convert.ToInt32(reader.ReadLine());
                datosPropiedadesTemp.CuotaMantenimiento = float.Parse(reader.ReadLine());

                datosPropiedades.Add(datosPropiedadesTemp);

            }
            reader.Close();
            

        }
        void Mostrar()
        {
            dataGridViewGeneral.DataSource = null;
            dataGridViewGeneral.DataSource = datosGenerales;
            dataGridViewGeneral.Refresh();
        }
        private void buttonOrdenarCuota_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerPropiedades();
            LeerPropietarios();
            for (int x = 0; x < datosPropietarios.Count; x++)
            {
               for (int y = 0; y < datosPropiedades.Count; y++)
                {
                 if (datosPropietarios[x].Dpi== datosPropiedades[y].Dpi)
                    {
                        DatosGenerales datosGeneralesTemp = new DatosGenerales();
                        datosGeneralesTemp.Nombre = datosPropietarios[x].Nombre;
                        datosGeneralesTemp.Apellido = datosPropietarios[x].Apellido;
                        datosGeneralesTemp.NumeroCasa = datosPropiedades[y].NumeroCasa;
                        datosGeneralesTemp.CuotaMatenimiento = datosPropiedades[y].CuotaMantenimiento;
                        datosGenerales.Add(datosGeneralesTemp);
                    }
                                                        
                 }
            }
            Mostrar();
        }
    }
}
