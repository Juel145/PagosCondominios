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
        List<ConteoPropiedades> conteoPropiedades = new List<ConteoPropiedades>();
        List<CuotaAltaBaja> cuotaAltaBajas = new List<CuotaAltaBaja>();
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
        void MostrarAltasBajas()
        {
            dataGridViewCuotasAltaBajas.DataSource = null;
            dataGridViewCuotasAltaBajas.DataSource = cuotaAltaBajas;
            dataGridViewCuotasAltaBajas.Refresh();
        }

        private void buttonOrdenarCuota_Click(object sender, EventArgs e)
        {
            datosGenerales = datosGenerales.OrderByDescending(p => p.CuotaMatenimiento).ToList();
            Mostrar();

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
                        if (conteoPropiedades.Exists(p => p.Nombre == datosPropietarios[x].Nombre) == false)
                        {
                            ConteoPropiedades conteoPropiedadesTemp = new ConteoPropiedades();
                            conteoPropiedadesTemp.Nombre = datosPropietarios[x].Nombre;
                            conteoPropiedadesTemp.Apellido = datosPropietarios[x].Apellido;
                            conteoPropiedadesTemp.Conteo = 1;
                            conteoPropiedadesTemp.Suma = datosPropiedades[y].CuotaMantenimiento;
                            conteoPropiedades.Add(conteoPropiedadesTemp);
                        }
                        else
                        {
                            conteoPropiedades[x].Conteo = conteoPropiedades[x].Conteo + 1;
                            conteoPropiedades[x].Suma = conteoPropiedades[x].Suma + datosPropiedades[y].CuotaMantenimiento;
                        }
                        datosGenerales.Add(datosGeneralesTemp);
                        
                    }
                                                        
                 }
            }
            
            Mostrar();
        }

        private void buttonMasPropiedade_Click(object sender, EventArgs e)
        {
            conteoPropiedades = conteoPropiedades.OrderByDescending(p => p.Conteo).ToList();
            labelNombre.Text = conteoPropiedades[0].Nombre;
            labelApellido.Text = conteoPropiedades[0].Apellido;
            labelNumeroPropiedades.Text = conteoPropiedades[0].Conteo.ToString();
      
        }

        private void buttonMasAltas_Click(object sender, EventArgs e)
        {
            cuotaAltaBajas.Clear();
            datosGenerales = datosGenerales.OrderByDescending(p => p.CuotaMatenimiento).ToList();
            for (int x = 0; x<3;x++)
            {
                CuotaAltaBaja cuotaAltaBajaTemp = new CuotaAltaBaja();
                cuotaAltaBajaTemp.Nombre = datosGenerales[x].Nombre;
                cuotaAltaBajaTemp.Apellido = datosGenerales[x].Apellido;
                cuotaAltaBajaTemp.NumeroCasa = datosGenerales[x].NumeroCasa;
                cuotaAltaBajaTemp.CuotaMatenimiento = datosGenerales[x].CuotaMatenimiento;
                cuotaAltaBajas.Add(cuotaAltaBajaTemp);
            }
            MostrarAltasBajas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conteoPropiedades = conteoPropiedades.OrderByDescending(p => p.Suma).ToList();
            labelNombreTotal.Text = conteoPropiedades[0].Nombre;
            labelApellidoTotal.Text = conteoPropiedades[0].Apellido;
            labelCuotaTotal.Text = conteoPropiedades[0].Suma.ToString();
        }

        private void buttonMasBajas_Click(object sender, EventArgs e)
        {
            cuotaAltaBajas.Clear();
            datosGenerales = datosGenerales.OrderBy(p => p.CuotaMatenimiento).ToList();
            for (int x = 0; x < 3; x++)
            {
                CuotaAltaBaja cuotaAltaBajaTemp = new CuotaAltaBaja();
                cuotaAltaBajaTemp.Nombre = datosGenerales[x].Nombre;
                cuotaAltaBajaTemp.Apellido = datosGenerales[x].Apellido;
                cuotaAltaBajaTemp.NumeroCasa = datosGenerales[x].NumeroCasa;
                cuotaAltaBajaTemp.CuotaMatenimiento = datosGenerales[x].CuotaMatenimiento;
                cuotaAltaBajas.Add(cuotaAltaBajaTemp);
            }
            MostrarAltasBajas();
        }
    }
}
