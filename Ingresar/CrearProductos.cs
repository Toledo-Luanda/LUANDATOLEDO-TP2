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
    public partial class CrearProductos : Form
    {
        public CrearProductos()
        {
            InitializeComponent();
        }

        private void CrearProductos_Load(object sender, EventArgs e)
        {
            textBoxIdProducto.GotFocus += (s, ev) => { this.ActiveControl = null; };
            textBoxNombreProducto.GotFocus += (s, ev) => { this.ActiveControl = null; };
            textBoxPrecioProducto.GotFocus += (s, ev) => { this.ActiveControl = null; };
            textBoxDescripcionProducto.GotFocus += (s, ev) => { this.ActiveControl = null; };
        }
    }
}
