namespace Ingresar
{
    partial class GenerarDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarDetalle));
            labelTitulo = new Label();
            labelIdFactura = new Label();
            labelFecha = new Label();
            labelClienteSeleccionado = new Label();
            comboBoxClienteSeleccionado = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            groupBoxInfoFinal = new GroupBox();
            groupBoxSubtotal = new GroupBox();
            textBoxSubtotal = new TextBox();
            groupBoxIVA = new GroupBox();
            textBoxIVA = new TextBox();
            groupBoxTotal = new GroupBox();
            textBoxTotal = new TextBox();
            buttonNuevoDetalle = new Button();
            buttonModificarDetalle = new Button();
            buttonBorrarDetalle = new Button();
            buttonAnterior = new Button();
            buttonSiguiente = new Button();
            buttonMostrar = new Button();
            buttonDescargar = new Button();
            groupBoxInfoFinal.SuspendLayout();
            groupBoxSubtotal.SuspendLayout();
            groupBoxIVA.SuspendLayout();
            groupBoxTotal.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(374, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(300, 36);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "TIPO DE DETALLE";
            labelTitulo.UseWaitCursor = true;
            // 
            // labelIdFactura
            // 
            labelIdFactura.AutoSize = true;
            labelIdFactura.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdFactura.Location = new Point(845, 69);
            labelIdFactura.Name = "labelIdFactura";
            labelIdFactura.Size = new Size(186, 22);
            labelIdFactura.TabIndex = 1;
            labelIdFactura.Text = "Detalle Numero: ";
            labelIdFactura.UseWaitCursor = true;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(577, 71);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(87, 22);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "Fecha: ";
            labelFecha.UseWaitCursor = true;
            // 
            // labelClienteSeleccionado
            // 
            labelClienteSeleccionado.AutoSize = true;
            labelClienteSeleccionado.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClienteSeleccionado.Location = new Point(162, 71);
            labelClienteSeleccionado.Name = "labelClienteSeleccionado";
            labelClienteSeleccionado.Size = new Size(109, 22);
            labelClienteSeleccionado.TabIndex = 3;
            labelClienteSeleccionado.Text = "Cliente: ";
            labelClienteSeleccionado.UseWaitCursor = true;
            // 
            // comboBoxClienteSeleccionado
            // 
            comboBoxClienteSeleccionado.BackColor = SystemColors.InactiveCaption;
            comboBoxClienteSeleccionado.FormattingEnabled = true;
            comboBoxClienteSeleccionado.Location = new Point(12, 96);
            comboBoxClienteSeleccionado.Name = "comboBoxClienteSeleccionado";
            comboBoxClienteSeleccionado.Size = new Size(405, 23);
            comboBoxClienteSeleccionado.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.InactiveCaption;
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.InactiveCaption;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.InactiveCaption;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.InactiveCaption;
            dateTimePicker1.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(452, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 24);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(878, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 23);
            textBox1.TabIndex = 6;
            // 
            // groupBoxInfoFinal
            // 
            groupBoxInfoFinal.Controls.Add(groupBoxTotal);
            groupBoxInfoFinal.Controls.Add(groupBoxIVA);
            groupBoxInfoFinal.Controls.Add(groupBoxSubtotal);
            groupBoxInfoFinal.Location = new Point(12, 455);
            groupBoxInfoFinal.Name = "groupBoxInfoFinal";
            groupBoxInfoFinal.Size = new Size(1019, 83);
            groupBoxInfoFinal.TabIndex = 7;
            groupBoxInfoFinal.TabStop = false;
            // 
            // groupBoxSubtotal
            // 
            groupBoxSubtotal.Controls.Add(textBoxSubtotal);
            groupBoxSubtotal.Location = new Point(104, 22);
            groupBoxSubtotal.Name = "groupBoxSubtotal";
            groupBoxSubtotal.Size = new Size(145, 49);
            groupBoxSubtotal.TabIndex = 0;
            groupBoxSubtotal.TabStop = false;
            groupBoxSubtotal.Text = "SUBTOTAL";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.BackColor = SystemColors.InactiveCaption;
            textBoxSubtotal.Location = new Point(6, 15);
            textBoxSubtotal.Multiline = true;
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(133, 28);
            textBoxSubtotal.TabIndex = 8;
            // 
            // groupBoxIVA
            // 
            groupBoxIVA.Controls.Add(textBoxIVA);
            groupBoxIVA.Location = new Point(431, 22);
            groupBoxIVA.Name = "groupBoxIVA";
            groupBoxIVA.Size = new Size(145, 49);
            groupBoxIVA.TabIndex = 9;
            groupBoxIVA.TabStop = false;
            groupBoxIVA.Text = "IVA 21% / SIN IVA";
            // 
            // textBoxIVA
            // 
            textBoxIVA.BackColor = SystemColors.InactiveCaption;
            textBoxIVA.Location = new Point(6, 15);
            textBoxIVA.Multiline = true;
            textBoxIVA.Name = "textBoxIVA";
            textBoxIVA.Size = new Size(133, 28);
            textBoxIVA.TabIndex = 8;
            // 
            // groupBoxTotal
            // 
            groupBoxTotal.Controls.Add(textBoxTotal);
            groupBoxTotal.Location = new Point(757, 22);
            groupBoxTotal.Name = "groupBoxTotal";
            groupBoxTotal.Size = new Size(145, 49);
            groupBoxTotal.TabIndex = 10;
            groupBoxTotal.TabStop = false;
            groupBoxTotal.Text = "TOTAL";
            // 
            // textBoxTotal
            // 
            textBoxTotal.BackColor = SystemColors.InactiveCaption;
            textBoxTotal.Location = new Point(6, 15);
            textBoxTotal.Multiline = true;
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(133, 28);
            textBoxTotal.TabIndex = 8;
            // 
            // buttonNuevoDetalle
            // 
            buttonNuevoDetalle.BackColor = Color.FromArgb(192, 255, 192);
            buttonNuevoDetalle.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevoDetalle.Location = new Point(143, 580);
            buttonNuevoDetalle.Name = "buttonNuevoDetalle";
            buttonNuevoDetalle.Size = new Size(99, 33);
            buttonNuevoDetalle.TabIndex = 11;
            buttonNuevoDetalle.Text = "NUEVO";
            buttonNuevoDetalle.UseVisualStyleBackColor = false;
            // 
            // buttonModificarDetalle
            // 
            buttonModificarDetalle.BackColor = Color.FromArgb(192, 255, 255);
            buttonModificarDetalle.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificarDetalle.Location = new Point(306, 580);
            buttonModificarDetalle.Name = "buttonModificarDetalle";
            buttonModificarDetalle.Size = new Size(120, 33);
            buttonModificarDetalle.TabIndex = 12;
            buttonModificarDetalle.Text = "MODIFICAR";
            buttonModificarDetalle.UseVisualStyleBackColor = false;
            // 
            // buttonBorrarDetalle
            // 
            buttonBorrarDetalle.BackColor = Color.FromArgb(255, 192, 192);
            buttonBorrarDetalle.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBorrarDetalle.Location = new Point(499, 580);
            buttonBorrarDetalle.Name = "buttonBorrarDetalle";
            buttonBorrarDetalle.Size = new Size(99, 33);
            buttonBorrarDetalle.TabIndex = 13;
            buttonBorrarDetalle.Text = "BORRAR";
            buttonBorrarDetalle.UseVisualStyleBackColor = false;
            // 
            // buttonAnterior
            // 
            buttonAnterior.BackColor = Color.Silver;
            buttonAnterior.BackgroundImageLayout = ImageLayout.Center;
            buttonAnterior.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnterior.ForeColor = SystemColors.ControlText;
            buttonAnterior.Location = new Point(30, 574);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(59, 45);
            buttonAnterior.TabIndex = 14;
            buttonAnterior.Text = "<<";
            buttonAnterior.UseVisualStyleBackColor = false;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Silver;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Center;
            buttonSiguiente.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguiente.ForeColor = SystemColors.ControlText;
            buttonSiguiente.Location = new Point(972, 574);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(59, 45);
            buttonSiguiente.TabIndex = 15;
            buttonSiguiente.Text = ">>";
            buttonSiguiente.UseVisualStyleBackColor = false;
            // 
            // buttonMostrar
            // 
            buttonMostrar.BackColor = Color.FromArgb(255, 224, 192);
            buttonMostrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMostrar.Location = new Point(649, 580);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(114, 33);
            buttonMostrar.TabIndex = 16;
            buttonMostrar.Text = "MOSTRAR";
            buttonMostrar.UseVisualStyleBackColor = false;
            // 
            // buttonDescargar
            // 
            buttonDescargar.BackColor = Color.FromArgb(192, 192, 255);
            buttonDescargar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDescargar.Location = new Point(806, 580);
            buttonDescargar.Name = "buttonDescargar";
            buttonDescargar.Size = new Size(123, 33);
            buttonDescargar.TabIndex = 17;
            buttonDescargar.Text = "DESCARGAR";
            buttonDescargar.UseVisualStyleBackColor = false;
            // 
            // GenerarDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1058, 637);
            Controls.Add(buttonDescargar);
            Controls.Add(buttonMostrar);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonAnterior);
            Controls.Add(buttonBorrarDetalle);
            Controls.Add(buttonModificarDetalle);
            Controls.Add(buttonNuevoDetalle);
            Controls.Add(groupBoxInfoFinal);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxClienteSeleccionado);
            Controls.Add(labelClienteSeleccionado);
            Controls.Add(labelFecha);
            Controls.Add(labelIdFactura);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GenerarDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Detalle";
            UseWaitCursor = true;
            Load += GenerarDetalle_Load;
            groupBoxInfoFinal.ResumeLayout(false);
            groupBoxSubtotal.ResumeLayout(false);
            groupBoxSubtotal.PerformLayout();
            groupBoxIVA.ResumeLayout(false);
            groupBoxIVA.PerformLayout();
            groupBoxTotal.ResumeLayout(false);
            groupBoxTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelIdFactura;
        private Label labelFecha;
        private Label labelClienteSeleccionado;
        private ComboBox comboBoxClienteSeleccionado;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private GroupBox groupBoxInfoFinal;
        private GroupBox groupBoxTotal;
        private TextBox textBoxTotal;
        private GroupBox groupBoxIVA;
        private TextBox textBoxIVA;
        private GroupBox groupBoxSubtotal;
        private TextBox textBoxSubtotal;
        private Button buttonNuevoDetalle;
        private Button buttonModificarDetalle;
        private Button buttonBorrarDetalle;
        private Button buttonAnterior;
        private Button buttonSiguiente;
        private Button buttonMostrar;
        private Button buttonDescargar;
    }
}