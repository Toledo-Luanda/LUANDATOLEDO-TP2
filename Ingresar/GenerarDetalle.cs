using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingresar
{
    public partial class GenerarDetalle : Form
    {
        public GenerarDetalle()
        {
            InitializeComponent();
        }

        private void GenerarDetalle_Load(object sender, EventArgs e)
        {

        }

        // Método para cambiar el texto del Label Titulo
        private void CambiarLabel(string texto)
        {
            labelTitulo.Text = texto;
        }
    }
}
