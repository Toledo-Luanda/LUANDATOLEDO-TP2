using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Biblioteca;

namespace Ingresar
{
    public partial class CrearCliente : Form
    {
        // Variables para almacenar los datos ingresados
        private string condicionFrenteAlIva;
        private int cuit;
        private string razonSocial;
        private string domicilioComercial;
        private bool seleccionCrear;
        private int idCliente;
        private int ultimoId;
        private bool placeholders = true;

        public CrearCliente()
        {
            InitializeComponent();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            textBoxRazonSocial.Enabled = false;
            textBoxCuit.Enabled = false;
            textBoxCondicionIVA.Enabled = false;
            textBoxDomicilioComercial.Enabled = false;
            textBoxIdCliente.Enabled = false;
            buttonGuardar.Visible = false;
            buttonCerrar.Visible = false;

            if (placeholders)
            {
                ultimoId = ConsultasClientes.ObtenerUltimoIDCliente();
                Cliente ultimoCliente;
                ultimoCliente = ConsultasClientes.LeerClientePorId(ultimoId);
                textBoxCondicionIVA.PlaceholderText = ultimoCliente.condicionFrenteAlIva.ToString();
                textBoxCuit.PlaceholderText = ultimoCliente.cuit.ToString();
                textBoxRazonSocial.PlaceholderText = ultimoCliente.razonSocial.ToString();
                textBoxDomicilioComercial.PlaceholderText = ultimoCliente.domicilioComercial.ToString();
                textBoxIdCliente.PlaceholderText = idCliente.ToString();
            }
        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            textBoxRazonSocial.Enabled = true;
            textBoxCuit.Enabled = true;
            textBoxCondicionIVA.Enabled = true;
            textBoxDomicilioComercial.Enabled = true;
            textBoxIdCliente.Enabled = true;
            textBoxRazonSocial.Focus();

            // Ocultar los botones 
            buttonModificar.Visible = false;
            buttonBorrar.Visible = false;
            buttonSiguiente.Visible = false;
            buttonAnterior.Visible = false;
            buttonGuardar.Visible = true;
            buttonCerrar.Visible = true;
            buttonNuevoCliente.Visible = false;
            seleccionCrear = true;
            placeholders = false;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

            textBoxRazonSocial.Enabled = true;
            textBoxCuit.Enabled = true;
            textBoxCondicionIVA.Enabled = true;
            textBoxDomicilioComercial.Enabled = true;
            textBoxRazonSocial.Focus();

            // Ocultar los botones 
            buttonModificar.Visible = false;
            buttonBorrar.Visible = false;
            buttonSiguiente.Visible = false;
            buttonAnterior.Visible = false;
            buttonGuardar.Visible = true;
            buttonCerrar.Visible = true;
            buttonNuevoCliente.Visible = false;
            seleccionCrear = false;
            placeholders = false;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            CrearCliente clientes = new CrearCliente();
            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();

            this.Close();

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string mensaje = ConsultasClientes.BorrarCliente(idCliente);
            MessageBox.Show(mensaje);
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            // Se asignan los valores ingresados en los campos de texto a las variables correspondientes
            condicionFrenteAlIva = textBoxCondicionIVA.Text;
            int.TryParse(textBoxCuit.Text, out cuit);
            razonSocial = textBoxRazonSocial.Text;
            domicilioComercial = textBoxDomicilioComercial.Text;

            string mensaje;
            if (seleccionCrear)
            {
                if (!(condicionFrenteAlIva == null || cuit == null || razonSocial == null || domicilioComercial == null)) { 
                    // Llamar al método CrearClienteNuevo con los datos almacenados en las variables
                    mensaje = ConsultasClientes.CrearClienteNuevo(condicionFrenteAlIva, cuit, razonSocial, domicilioComercial);
                }
                else
                {
                    mensaje = "Complete todos los campos";
                }
            }
            else
            {
                if (!(condicionFrenteAlIva == null || cuit == null || razonSocial == null || domicilioComercial == null))
                {
                    int.TryParse(textBoxIdCliente.Text, out idCliente);
                    mensaje = ConsultasClientes.ModificarCliente(idCliente, condicionFrenteAlIva, cuit, razonSocial, domicilioComercial);
                }
                else
                {
                    mensaje = "Complete todos los campos";
                }
            }

            // Mostrar el mensaje de retorno (puedes mostrarlo en un MessageBox o en otro control de tu interfaz)
            MessageBox.Show(mensaje);

            // Crear una instancia del nuevo formulario
            CrearCliente clientes = new CrearCliente();
            // Mostrar el formulario secundario como un diálogo modal
            clientes.ShowDialog();

            this.Close();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            while (ultimoId > 0)
            {
                Cliente ultimoCliente = ConsultasClientes.LeerClientePorId(ultimoId);

                if (ultimoCliente != null)
                {
                    // Se encontró un cliente con el ID especificado, actualiza los campos
                    textBoxCondicionIVA.PlaceholderText = ultimoCliente.condicionFrenteAlIva.ToString();
                    textBoxCuit.PlaceholderText = ultimoCliente.cuit.ToString();
                    textBoxRazonSocial.PlaceholderText = ultimoCliente.razonSocial.ToString();
                    textBoxDomicilioComercial.PlaceholderText = ultimoCliente.domicilioComercial.ToString();
                    textBoxIdCliente.PlaceholderText = ultimoId.ToString();
                    break; // Sale del bucle ya que se encontró un cliente válido
                }
                else
                {
                    // No se encontró un cliente, decrementa el ID
                    ultimoId--;
                }
            }

            if (ultimoId <= 1)
            {
                Cliente primerCliente = ConsultasClientes.LeerClientePorId(1);
                if (primerCliente != null)
                {
                    textBoxCondicionIVA.PlaceholderText = primerCliente.condicionFrenteAlIva.ToString();
                    textBoxCuit.PlaceholderText = primerCliente.cuit.ToString();
                    textBoxRazonSocial.PlaceholderText = primerCliente.razonSocial.ToString();
                    textBoxDomicilioComercial.PlaceholderText = primerCliente.domicilioComercial.ToString();
                    textBoxIdCliente.PlaceholderText = "1";
                }
                else
                {
                    // No se encontró ningún cliente en la tabla
                    MessageBox.Show("No se encontraron registros de clientes.");
                }
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            int ultimoIdActual = ConsultasClientes.ObtenerUltimoIDCliente(); // Obtener el último ID de la tabla

            while (ultimoId <= ultimoIdActual)
            {
                Cliente siguienteCliente = ConsultasClientes.LeerClientePorId(ultimoId);

                if (siguienteCliente != null)
                {
                    // Se encontró un cliente con el ID especificado, actualiza los campos
                    textBoxCondicionIVA.PlaceholderText = siguienteCliente.condicionFrenteAlIva.ToString();
                    textBoxCuit.PlaceholderText = siguienteCliente.cuit.ToString();
                    textBoxRazonSocial.PlaceholderText = siguienteCliente.razonSocial.ToString();
                    textBoxDomicilioComercial.PlaceholderText = siguienteCliente.domicilioComercial.ToString();
                    textBoxIdCliente.PlaceholderText = ultimoId.ToString();
                    break; // Sale del bucle ya que se encontró un cliente válido
                }
                else
                {
                    // No se encontró un cliente, incrementa el ID
                    ultimoId++;
                }
            }

            if (ultimoId > ultimoIdActual)
            {
                // Si el ID supera el último ID de la tabla, muestra el último ID
                Cliente ultimoCliente = ConsultasClientes.LeerClientePorId(ultimoId);
                if (ultimoCliente != null)
                {
                    textBoxCondicionIVA.PlaceholderText = ultimoCliente.condicionFrenteAlIva.ToString();
                    textBoxCuit.PlaceholderText = ultimoCliente.cuit.ToString();
                    textBoxRazonSocial.PlaceholderText = ultimoCliente.razonSocial.ToString();
                    textBoxDomicilioComercial.PlaceholderText = ultimoCliente.domicilioComercial.ToString();
                    textBoxIdCliente.PlaceholderText = ultimoId.ToString();
                }
                else
                {
                    // No se encontró ningún cliente en la tabla
                    MessageBox.Show("No se encontraron registros de clientes.");
                }
            }
        }
    }
}
