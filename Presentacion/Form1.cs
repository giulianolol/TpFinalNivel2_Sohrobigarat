using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CargarDatos;
using Dominio;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        List<Articulo> listaArticulos = new List<Articulo>();
        public Form1()
        {
            InitializeComponent();
            cargarArticulos();
        } 
        public void cargarArticulos()
        {
            CargarDatosClass cargarDatos = new CargarDatosClass();
            listaArticulos = cargarDatos.cargarGrid();
            dgvArticulos.DataSource = cargarDatos.cargarGrid();

            //ocultarColumnas();
            //pcbLibro.Load(listalibros[0].UrlPortada);
            //pbxFotoAutor.Load(listalibros[0].UrlFotoAutor);
        }

    }
}
