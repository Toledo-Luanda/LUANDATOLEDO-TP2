namespace Ingresar
{
    partial class CrearProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProductos));
            groupBoxProductos = new GroupBox();
            textBoxIdProducto = new TextBox();
            labelDescripcionProducto = new Label();
            labelPrecioProducto = new Label();
            labelNombreProducto = new Label();
            textBoxDescripcionProducto = new TextBox();
            textBoxPrecioProducto = new TextBox();
            textBoxNombreProducto = new TextBox();
            labelIdProducto = new Label();
            buttonNuevoProducto = new Button();
            buttonModificarProducto = new Button();
            buttonBorrarProducto = new Button();
            buttonSiguiente = new Button();
            buttonAnterior = new Button();
            groupBoxProductos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxProductos
            // 
            groupBoxProductos.Controls.Add(textBoxIdProducto);
            groupBoxProductos.Controls.Add(labelDescripcionProducto);
            groupBoxProductos.Controls.Add(labelPrecioProducto);
            groupBoxProductos.Controls.Add(labelNombreProducto);
            groupBoxProductos.Controls.Add(textBoxDescripcionProducto);
            groupBoxProductos.Controls.Add(textBoxPrecioProducto);
            groupBoxProductos.Controls.Add(textBoxNombreProducto);
            groupBoxProductos.Controls.Add(labelIdProducto);
            groupBoxProductos.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxProductos.Location = new Point(131, 32);
            groupBoxProductos.Name = "groupBoxProductos";
            groupBoxProductos.Size = new Size(342, 403);
            groupBoxProductos.TabIndex = 1;
            groupBoxProductos.TabStop = false;
            groupBoxProductos.Text = "PRODUCTOS";
            // 
            // textBoxIdProducto
            // 
            textBoxIdProducto.BackColor = SystemColors.ActiveCaption;
            textBoxIdProducto.Location = new Point(228, 57);
            textBoxIdProducto.Name = "textBoxIdProducto";
            textBoxIdProducto.PlaceholderText = "1";
            textBoxIdProducto.Size = new Size(100, 31);
            textBoxIdProducto.TabIndex = 9;
            textBoxIdProducto.TextAlign = HorizontalAlignment.Center;
            textBoxIdProducto.UseSystemPasswordChar = true;
            // 
            // labelDescripcionProducto
            // 
            labelDescripcionProducto.AutoSize = true;
            labelDescripcionProducto.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescripcionProducto.Location = new Point(42, 265);
            labelDescripcionProducto.Name = "labelDescripcionProducto";
            labelDescripcionProducto.Size = new Size(177, 17);
            labelDescripcionProducto.TabIndex = 7;
            labelDescripcionProducto.Text = "Descripcion del producto :";
            // 
            // labelPrecioProducto
            // 
            labelPrecioProducto.AutoSize = true;
            labelPrecioProducto.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecioProducto.Location = new Point(42, 192);
            labelPrecioProducto.Name = "labelPrecioProducto";
            labelPrecioProducto.Size = new Size(57, 17);
            labelPrecioProducto.TabIndex = 6;
            labelPrecioProducto.Text = "Precio :";
            // 
            // labelNombreProducto
            // 
            labelNombreProducto.AutoSize = true;
            labelNombreProducto.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombreProducto.Location = new Point(42, 127);
            labelNombreProducto.Name = "labelNombreProducto";
            labelNombreProducto.Size = new Size(151, 17);
            labelNombreProducto.TabIndex = 5;
            labelNombreProducto.Text = "Nombre del producto :";
            // 
            // textBoxDescripcionProducto
            // 
            textBoxDescripcionProducto.BackColor = SystemColors.ButtonFace;
            textBoxDescripcionProducto.Location = new Point(42, 285);
            textBoxDescripcionProducto.Multiline = true;
            textBoxDescripcionProducto.Name = "textBoxDescripcionProducto";
            textBoxDescripcionProducto.PlaceholderText = "Descripcion";
            textBoxDescripcionProducto.Size = new Size(250, 96);
            textBoxDescripcionProducto.TabIndex = 3;
            // 
            // textBoxPrecioProducto
            // 
            textBoxPrecioProducto.BackColor = SystemColors.ButtonFace;
            textBoxPrecioProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPrecioProducto.Location = new Point(42, 212);
            textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            textBoxPrecioProducto.PlaceholderText = "Precio";
            textBoxPrecioProducto.Size = new Size(250, 29);
            textBoxPrecioProducto.TabIndex = 2;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.BackColor = SystemColors.ButtonFace;
            textBoxNombreProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNombreProducto.Location = new Point(42, 147);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.PlaceholderText = "Nombre ";
            textBoxNombreProducto.Size = new Size(250, 29);
            textBoxNombreProducto.TabIndex = 1;
            // 
            // labelIdProducto
            // 
            labelIdProducto.AutoSize = true;
            labelIdProducto.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelIdProducto.Location = new Point(20, 60);
            labelIdProducto.Name = "labelIdProducto";
            labelIdProducto.Size = new Size(202, 26);
            labelIdProducto.TabIndex = 0;
            labelIdProducto.Text = "CODIGO PRODUCTO: ";
            // 
            // buttonNuevoProducto
            // 
            buttonNuevoProducto.BackColor = Color.FromArgb(192, 255, 192);
            buttonNuevoProducto.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevoProducto.Location = new Point(86, 480);
            buttonNuevoProducto.Name = "buttonNuevoProducto";
            buttonNuevoProducto.Size = new Size(99, 33);
            buttonNuevoProducto.TabIndex = 2;
            buttonNuevoProducto.Text = "NUEVO";
            buttonNuevoProducto.UseVisualStyleBackColor = false;
            // 
            // buttonModificarProducto
            // 
            buttonModificarProducto.BackColor = Color.FromArgb(192, 255, 255);
            buttonModificarProducto.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificarProducto.Location = new Point(251, 480);
            buttonModificarProducto.Name = "buttonModificarProducto";
            buttonModificarProducto.Size = new Size(114, 33);
            buttonModificarProducto.TabIndex = 5;
            buttonModificarProducto.Text = "MODIFICAR";
            buttonModificarProducto.UseVisualStyleBackColor = false;
            // 
            // buttonBorrarProducto
            // 
            buttonBorrarProducto.BackColor = Color.FromArgb(255, 192, 192);
            buttonBorrarProducto.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBorrarProducto.Location = new Point(420, 480);
            buttonBorrarProducto.Name = "buttonBorrarProducto";
            buttonBorrarProducto.Size = new Size(99, 33);
            buttonBorrarProducto.TabIndex = 6;
            buttonBorrarProducto.Text = "BORRAR";
            buttonBorrarProducto.UseVisualStyleBackColor = false;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Silver;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Center;
            buttonSiguiente.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguiente.ForeColor = SystemColors.ControlText;
            buttonSiguiente.Location = new Point(518, 224);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(59, 42);
            buttonSiguiente.TabIndex = 7;
            buttonSiguiente.Text = ">>";
            buttonSiguiente.UseVisualStyleBackColor = false;
            // 
            // buttonAnterior
            // 
            buttonAnterior.BackColor = Color.Silver;
            buttonAnterior.BackgroundImageLayout = ImageLayout.Center;
            buttonAnterior.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnterior.ForeColor = SystemColors.ControlText;
            buttonAnterior.Location = new Point(12, 224);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(59, 42);
            buttonAnterior.TabIndex = 8;
            buttonAnterior.Text = "<<";
            buttonAnterior.UseVisualStyleBackColor = false;
            // 
            // CrearProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(603, 555);
            Controls.Add(buttonAnterior);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonBorrarProducto);
            Controls.Add(buttonModificarProducto);
            Controls.Add(buttonNuevoProducto);
            Controls.Add(groupBoxProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TABLA DE PRODUCTOS";
            Load += CrearProductos_Load;
            groupBoxProductos.ResumeLayout(false);
            groupBoxProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProductos;
        private TextBox textBoxIdProducto;
        private Label labelDescripcionProducto;
        private Label labelPrecioProducto;
        private Label labelNombreProducto;
        private TextBox textBoxDescripcionProducto;
        private TextBox textBoxPrecioProducto;
        private TextBox textBoxNombreProducto;
        private Label labelIdProducto;
        private Button buttonNuevoProducto;
        private Button buttonModificarProducto;
        private Button buttonBorrarProducto;
        private Button buttonSiguiente;
        private Button buttonAnterior;
    }
}