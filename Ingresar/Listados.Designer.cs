namespace Ingresar
{
    partial class Listados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            groupBox1 = new GroupBox();
            radioButtonClientes = new RadioButton();
            radioButtonProductos = new RadioButton();
            radioButtonServicios = new RadioButton();
            radioButtonDetalleFCA = new RadioButton();
            listBoxConsultas = new ListBox();
            radioButtonDetalleFCC = new RadioButton();
            radioButtonDetalleNCA = new RadioButton();
            radioButtonDetalleNCC = new RadioButton();
            buttonConsultar = new Button();
            buttonLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(radioButtonDetalleNCC);
            groupBox1.Controls.Add(radioButtonDetalleNCA);
            groupBox1.Controls.Add(radioButtonDetalleFCC);
            groupBox1.Controls.Add(radioButtonDetalleFCA);
            groupBox1.Controls.Add(radioButtonServicios);
            groupBox1.Controls.Add(radioButtonProductos);
            groupBox1.Controls.Add(radioButtonClientes);
            groupBox1.Location = new Point(39, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 368);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // radioButtonClientes
            // 
            radioButtonClientes.AutoSize = true;
            radioButtonClientes.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonClientes.Location = new Point(18, 31);
            radioButtonClientes.Name = "radioButtonClientes";
            radioButtonClientes.Size = new Size(82, 25);
            radioButtonClientes.TabIndex = 3;
            radioButtonClientes.Text = "Clientes";
            radioButtonClientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonProductos
            // 
            radioButtonProductos.AutoSize = true;
            radioButtonProductos.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonProductos.Location = new Point(18, 81);
            radioButtonProductos.Name = "radioButtonProductos";
            radioButtonProductos.Size = new Size(96, 25);
            radioButtonProductos.TabIndex = 4;
            radioButtonProductos.Text = "Productos";
            radioButtonProductos.UseVisualStyleBackColor = true;
            // 
            // radioButtonServicios
            // 
            radioButtonServicios.AutoSize = true;
            radioButtonServicios.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonServicios.Location = new Point(18, 128);
            radioButtonServicios.Name = "radioButtonServicios";
            radioButtonServicios.Size = new Size(89, 25);
            radioButtonServicios.TabIndex = 5;
            radioButtonServicios.Text = "Servicios";
            radioButtonServicios.UseVisualStyleBackColor = true;
            // 
            // radioButtonDetalleFCA
            // 
            radioButtonDetalleFCA.AutoSize = true;
            radioButtonDetalleFCA.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonDetalleFCA.Location = new Point(18, 176);
            radioButtonDetalleFCA.Name = "radioButtonDetalleFCA";
            radioButtonDetalleFCA.Size = new Size(147, 25);
            radioButtonDetalleFCA.TabIndex = 6;
            radioButtonDetalleFCA.Text = "Detalle Factura A";
            radioButtonDetalleFCA.UseVisualStyleBackColor = true;
            // 
            // listBoxConsultas
            // 
            listBoxConsultas.BackColor = Color.LightSteelBlue;
            listBoxConsultas.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxConsultas.FormattingEnabled = true;
            listBoxConsultas.ItemHeight = 16;
            listBoxConsultas.Location = new Point(330, 15);
            listBoxConsultas.Name = "listBoxConsultas";
            listBoxConsultas.Size = new Size(528, 484);
            listBoxConsultas.TabIndex = 3;
            // 
            // radioButtonDetalleFCC
            // 
            radioButtonDetalleFCC.AutoSize = true;
            radioButtonDetalleFCC.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonDetalleFCC.Location = new Point(18, 224);
            radioButtonDetalleFCC.Name = "radioButtonDetalleFCC";
            radioButtonDetalleFCC.Size = new Size(146, 25);
            radioButtonDetalleFCC.TabIndex = 7;
            radioButtonDetalleFCC.Text = "Detalle Factura C";
            radioButtonDetalleFCC.UseVisualStyleBackColor = true;
            // 
            // radioButtonDetalleNCA
            // 
            radioButtonDetalleNCA.AutoSize = true;
            radioButtonDetalleNCA.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonDetalleNCA.Location = new Point(18, 270);
            radioButtonDetalleNCA.Name = "radioButtonDetalleNCA";
            radioButtonDetalleNCA.Size = new Size(198, 25);
            radioButtonDetalleNCA.TabIndex = 8;
            radioButtonDetalleNCA.Text = "Detalle Nota de Credito A";
            radioButtonDetalleNCA.UseVisualStyleBackColor = true;
            // 
            // radioButtonDetalleNCC
            // 
            radioButtonDetalleNCC.AutoSize = true;
            radioButtonDetalleNCC.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonDetalleNCC.Location = new Point(18, 320);
            radioButtonDetalleNCC.Name = "radioButtonDetalleNCC";
            radioButtonDetalleNCC.Size = new Size(197, 25);
            radioButtonDetalleNCC.TabIndex = 9;
            radioButtonDetalleNCC.Text = "Detalle Nota de Credito C";
            radioButtonDetalleNCC.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            buttonConsultar.BackColor = Color.FromArgb(192, 255, 192);
            buttonConsultar.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultar.Location = new Point(15, 452);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(131, 47);
            buttonConsultar.TabIndex = 10;
            buttonConsultar.Text = "CONSULTAR";
            buttonConsultar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(255, 192, 192);
            buttonLimpiar.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(179, 452);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(111, 47);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "LIMPIAR";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // Listados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(882, 517);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonConsultar);
            Controls.Add(listBoxConsultas);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Listados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTADOS";
            Load += Listados_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radioButtonDetalleFCA;
        private RadioButton radioButtonServicios;
        private RadioButton radioButtonProductos;
        private RadioButton radioButtonClientes;
        private RadioButton radioButtonDetalleNCC;
        private RadioButton radioButtonDetalleNCA;
        private RadioButton radioButtonDetalleFCC;
        private ListBox listBoxConsultas;
        private Button buttonConsultar;
        private Button buttonLimpiar;
    }
}