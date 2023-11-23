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
    public partial class CrearServicios : Form
    {
        public CrearServicios()
        {
            InitializeComponent();
        }

        private void CrearServicios_Load(object sender, EventArgs e)
        {
            textBoxIdServicios.GotFocus += (s, ev) => { this.ActiveControl = null; };
            textBoxNombreServicio.GotFocus += (s, ev) => { this.ActiveControl = null; };
            textBoxPrecioServicio.GotFocus += (s, ev) => { this.ActiveControl = null; };
            textBoxDescripcionServicio.GotFocus += (s, ev) => { this.ActiveControl = null; };
        }

        private void buttonModificarServicio_Click(object sender, EventArgs e)
        {

        }
    }
}
