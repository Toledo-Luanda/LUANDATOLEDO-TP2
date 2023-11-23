using Biblioteca;
namespace Ingresar
{
    public partial class IngresoSistema : Form
    {
        public IngresoSistema()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = nombreUsuario.Text;
            string contrasena = contraseña.Text;

            if (VerificacionDeIngreso.Ingreso(usuario, contrasena) == "valido")
            {
                this.Hide();
                PantallaDeInicio formPrincipal = new PantallaDeInicio(usuario);
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show(VerificacionDeIngreso.Ingreso(usuario, contrasena));
            }
        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IngresoSistema_Load(object sender, EventArgs e)
        {
            bienvenido.Focus();
        }
    }
}