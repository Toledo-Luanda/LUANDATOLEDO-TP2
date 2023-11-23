using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Ingresar;

namespace Ingresar
{
    public partial class PantallaDeInicio : Form
    {
        public PantallaDeInicio(string informacion)
        {
            InitializeComponent();
            labelUsuarioActual.Text = informacion;
        }

        private void ClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            CrearCliente clientes = new CrearCliente();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void PantallaDeInicio_Load(object sender, EventArgs e)
        {
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            CrearProductos clientes = new CrearProductos();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            CrearServicios clientes = new CrearServicios();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void lISTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Listados clientes = new Listados();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void NotaDeCreditoCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            GenerarDetalle clientes = new GenerarDetalle();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void NotaDeCreditoAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            GenerarDetalle clientes = new GenerarDetalle();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void FacturaAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            GenerarDetalle clientes = new GenerarDetalle();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void FacturaCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            GenerarDetalle clientes = new GenerarDetalle();

            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();
        }

        private void labelUsuarioActual_Click(object sender, EventArgs e)
        {

        }
    }
}
