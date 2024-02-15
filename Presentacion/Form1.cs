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
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioAgregarArticulo alta = new FormularioAgregarArticulo();
            alta.ShowDialog();
        }
    }
}
