namespace Ingresar
{
    partial class CrearCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCliente));
            groupBoxClientes = new GroupBox();
            textBoxIdCliente = new TextBox();
            labelDomicilioComercial = new Label();
            labelCondicionIVA = new Label();
            labelCuit = new Label();
            labelRazonSocial = new Label();
            textBoxDomicilioComercial = new TextBox();
            textBoxCondicionIVA = new TextBox();
            textBoxCuit = new TextBox();
            textBoxRazonSocial = new TextBox();
            labelIdCliente = new Label();
            buttonNuevoCliente = new Button();
            buttonBorrar = new Button();
            buttonModificar = new Button();
            buttonSiguiente = new Button();
            buttonAnterior = new Button();
            buttonGuardar = new Button();
            buttonCerrar = new Button();
            groupBoxClientes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxClientes
            // 
            groupBoxClientes.Controls.Add(textBoxIdCliente);
            groupBoxClientes.Controls.Add(labelDomicilioComercial);
            groupBoxClientes.Controls.Add(labelCondicionIVA);
            groupBoxClientes.Controls.Add(labelCuit);
            groupBoxClientes.Controls.Add(labelRazonSocial);
            groupBoxClientes.Controls.Add(textBoxDomicilioComercial);
            groupBoxClientes.Controls.Add(textBoxCondicionIVA);
            groupBoxClientes.Controls.Add(textBoxCuit);
            groupBoxClientes.Controls.Add(textBoxRazonSocial);
            groupBoxClientes.Controls.Add(labelIdCliente);
            groupBoxClientes.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxClientes.Location = new Point(150, 29);
            groupBoxClientes.Name = "groupBoxClientes";
            groupBoxClientes.Size = new Size(334, 412);
            groupBoxClientes.TabIndex = 0;
            groupBoxClientes.TabStop = false;
            groupBoxClientes.Text = "CLIENTES";
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.BackColor = SystemColors.ActiveCaption;
            textBoxIdCliente.Location = new Point(212, 57);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.PlaceholderText = "1";
            textBoxIdCliente.Size = new Size(100, 31);
            textBoxIdCliente.TabIndex = 9;
            textBoxIdCliente.TextAlign = HorizontalAlignment.Center;
            textBoxIdCliente.UseSystemPasswordChar = true;
            // 
            // labelDomicilioComercial
            // 
            labelDomicilioComercial.AutoSize = true;
            labelDomicilioComercial.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDomicilioComercial.Location = new Point(42, 336);
            labelDomicilioComercial.Name = "labelDomicilioComercial";
            labelDomicilioComercial.Size = new Size(146, 17);
            labelDomicilioComercial.TabIndex = 8;
            labelDomicilioComercial.Text = "Domicilio Comercial :";
            // 
            // labelCondicionIVA
            // 
            labelCondicionIVA.AutoSize = true;
            labelCondicionIVA.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCondicionIVA.Location = new Point(42, 265);
            labelCondicionIVA.Name = "labelCondicionIVA";
            labelCondicionIVA.Size = new Size(164, 17);
            labelCondicionIVA.TabIndex = 7;
            labelCondicionIVA.Text = "Condicion frente al IVA :";
            // 
            // labelCuit
            // 
            labelCuit.AutoSize = true;
            labelCuit.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCuit.Location = new Point(42, 192);
            labelCuit.Name = "labelCuit";
            labelCuit.Size = new Size(42, 17);
            labelCuit.TabIndex = 6;
            labelCuit.Text = "Cuit :";
            // 
            // labelRazonSocial
            // 
            labelRazonSocial.AutoSize = true;
            labelRazonSocial.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelRazonSocial.Location = new Point(42, 127);
            labelRazonSocial.Name = "labelRazonSocial";
            labelRazonSocial.Size = new Size(98, 17);
            labelRazonSocial.TabIndex = 5;
            labelRazonSocial.Text = "Razon Social :";
            // 
            // textBoxDomicilioComercial
            // 
            textBoxDomicilioComercial.BackColor = SystemColors.ButtonFace;
            textBoxDomicilioComercial.Location = new Point(42, 356);
            textBoxDomicilioComercial.Name = "textBoxDomicilioComercial";
            textBoxDomicilioComercial.PlaceholderText = "Domicilio comercial";
            textBoxDomicilioComercial.Size = new Size(250, 31);
            textBoxDomicilioComercial.TabIndex = 4;
            // 
            // textBoxCondicionIVA
            // 
            textBoxCondicionIVA.BackColor = SystemColors.ButtonFace;
            textBoxCondicionIVA.Location = new Point(42, 285);
            textBoxCondicionIVA.Name = "textBoxCondicionIVA";
            textBoxCondicionIVA.PlaceholderText = "Condicion frente al IVA";
            textBoxCondicionIVA.Size = new Size(250, 31);
            textBoxCondicionIVA.TabIndex = 3;
            // 
            // textBoxCuit
            // 
            textBoxCuit.BackColor = SystemColors.ButtonFace;
            textBoxCuit.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCuit.Location = new Point(42, 212);
            textBoxCuit.Name = "textBoxCuit";
            textBoxCuit.PlaceholderText = "Cuit";
            textBoxCuit.Size = new Size(250, 29);
            textBoxCuit.TabIndex = 2;
            // 
            // textBoxRazonSocial
            // 
            textBoxRazonSocial.BackColor = SystemColors.ButtonFace;
            textBoxRazonSocial.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRazonSocial.Location = new Point(42, 147);
            textBoxRazonSocial.Name = "textBoxRazonSocial";
            textBoxRazonSocial.PlaceholderText = "Razon Social";
            textBoxRazonSocial.Size = new Size(250, 29);
            textBoxRazonSocial.TabIndex = 1;
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelIdCliente.Location = new Point(32, 60);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(174, 26);
            labelIdCliente.TabIndex = 0;
            labelIdCliente.Text = "CODIGO CLIENTE: ";
            // 
            // buttonNuevoCliente
            // 
            buttonNuevoCliente.BackColor = Color.FromArgb(192, 255, 192);
            buttonNuevoCliente.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevoCliente.Location = new Point(111, 471);
            buttonNuevoCliente.Name = "buttonNuevoCliente";
            buttonNuevoCliente.Size = new Size(99, 33);
            buttonNuevoCliente.TabIndex = 1;
            buttonNuevoCliente.Text = "NUEVO";
            buttonNuevoCliente.UseVisualStyleBackColor = false;
            buttonNuevoCliente.Click += buttonNuevoCliente_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.FromArgb(255, 192, 192);
            buttonBorrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBorrar.Location = new Point(414, 471);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(99, 33);
            buttonBorrar.TabIndex = 3;
            buttonBorrar.Text = "BORRAR";
            buttonBorrar.UseVisualStyleBackColor = false;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.FromArgb(192, 255, 255);
            buttonModificar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificar.Location = new Point(258, 471);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(114, 33);
            buttonModificar.TabIndex = 4;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Silver;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Center;
            buttonSiguiente.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguiente.ForeColor = SystemColors.ControlText;
            buttonSiguiente.Location = new Point(544, 221);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(59, 42);
            buttonSiguiente.TabIndex = 5;
            buttonSiguiente.Text = ">>";
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // buttonAnterior
            // 
            buttonAnterior.BackColor = Color.Silver;
            buttonAnterior.BackgroundImageLayout = ImageLayout.Center;
            buttonAnterior.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnterior.ForeColor = SystemColors.ControlText;
            buttonAnterior.Location = new Point(23, 228);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(59, 42);
            buttonAnterior.TabIndex = 6;
            buttonAnterior.Text = "<<";
            buttonAnterior.UseVisualStyleBackColor = false;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(192, 255, 192);
            buttonGuardar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(192, 432);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(114, 33);
            buttonGuardar.TabIndex = 7;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click_1;
            // 
            // buttonCerrar
            // 
            buttonCerrar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCerrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCerrar.Location = new Point(328, 432);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(114, 33);
            buttonCerrar.TabIndex = 8;
            buttonCerrar.Text = "CERRAR";
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // CrearCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(631, 525);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonAnterior);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonModificar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonNuevoCliente);
            Controls.Add(groupBoxClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tablas Clientes";
            Load += CrearCliente_Load;
            groupBoxClientes.ResumeLayout(false);
            groupBoxClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxClientes;
        private Label labelIdCliente;
        private TextBox textBoxDomicilioComercial;
        private TextBox textBoxCondicionIVA;
        private TextBox textBoxCuit;
        private TextBox textBoxRazonSocial;
        private Button buttonNuevoCliente;
        private Button buttonBorrar;
        private Button buttonModificar;
        private Label labelCuit;
        private Label labelRazonSocial;
        private TextBox textBoxIdCliente;
        private Label labelDomicilioComercial;
        private Label labelCondicionIVA;
        private Button buttonSiguiente;
        private Button buttonAnterior;
        private Button buttonGuardar;
        private Button buttonCerrar;
    }
}