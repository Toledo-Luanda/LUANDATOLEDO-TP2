namespace Ingresar
{
    partial class IngresoSistema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoSistema));
            bienvenido = new Label();
            nombreUsuario = new TextBox();
            contraseña = new TextBox();
            Ingresar = new Button();
            labelUsuario = new Label();
            labelContrasena = new Label();
            SuspendLayout();
            // 
            // bienvenido
            // 
            bienvenido.AutoSize = true;
            bienvenido.BackColor = Color.Transparent;
            bienvenido.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            bienvenido.Location = new Point(56, 9);
            bienvenido.Name = "bienvenido";
            bienvenido.Size = new Size(325, 79);
            bienvenido.TabIndex = 0;
            bienvenido.Text = "Bienvenido";
            // 
            // nombreUsuario
            // 
            nombreUsuario.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nombreUsuario.Location = new Point(87, 152);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.PlaceholderText = "Usuario";
            nombreUsuario.Size = new Size(254, 33);
            nombreUsuario.TabIndex = 1;
            nombreUsuario.TextChanged += nombreUsuario_TextChanged;
            // 
            // contraseña
            // 
            contraseña.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            contraseña.Location = new Point(87, 236);
            contraseña.Name = "contraseña";
            contraseña.PlaceholderText = "Contraseña";
            contraseña.Size = new Size(254, 33);
            contraseña.TabIndex = 2;
            // 
            // Ingresar
            // 
            Ingresar.BackColor = Color.LightGreen;
            Ingresar.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ingresar.ForeColor = SystemColors.ActiveCaptionText;
            Ingresar.Location = new Point(145, 322);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(140, 41);
            Ingresar.TabIndex = 3;
            Ingresar.Text = "INGRESAR";
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += Ingresar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Ink Free", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUsuario.Location = new Point(87, 130);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(149, 19);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "Ingrese su usuario:";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Font = new Font("Ink Free", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelContrasena.Location = new Point(87, 214);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(177, 19);
            labelContrasena.TabIndex = 5;
            labelContrasena.Text = "Ingrese su contraseña:";
            // 
            // IngresoSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 375);
            Controls.Add(labelContrasena);
            Controls.Add(labelUsuario);
            Controls.Add(Ingresar);
            Controls.Add(contraseña);
            Controls.Add(nombreUsuario);
            Controls.Add(bienvenido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IngresoSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador detalles de facturas";
            Load += IngresoSistema_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bienvenido;
        private TextBox nombreUsuario;
        private TextBox contraseña;
        private Button Ingresar;
        private Label labelUsuario;
        private Label labelContrasena;
    }
}