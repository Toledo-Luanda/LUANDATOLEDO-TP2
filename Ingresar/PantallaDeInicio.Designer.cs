namespace Ingresar
{
    partial class PantallaDeInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeInicio));
            menuPrincipal = new MenuStrip();
            tABLASToolStripMenuItem = new ToolStripMenuItem();
            ClientesToolStripMenuItem = new ToolStripMenuItem();
            ProductosToolStripMenuItem = new ToolStripMenuItem();
            ServiciosToolStripMenuItem = new ToolStripMenuItem();
            gENERARDETALLEToolStripMenuItem = new ToolStripMenuItem();
            nOTASDECREDITOToolStripMenuItem = new ToolStripMenuItem();
            NotaDeCreditoCToolStripMenuItem = new ToolStripMenuItem();
            NotaDeCreditoAToolStripMenuItem = new ToolStripMenuItem();
            fACTURASToolStripMenuItem = new ToolStripMenuItem();
            FacturaAToolStripMenuItem = new ToolStripMenuItem();
            FacturaCToolStripMenuItem = new ToolStripMenuItem();
            lISTADOSToolStripMenuItem = new ToolStripMenuItem();
            fechaYHoraActual = new GroupBox();
            hora = new Label();
            fecha = new Label();
            groupBox1 = new GroupBox();
            labelUsuarioActual = new Label();
            menuPrincipal.SuspendLayout();
            fechaYHoraActual.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = Color.SteelBlue;
            menuPrincipal.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { tABLASToolStripMenuItem, gENERARDETALLEToolStripMenuItem, lISTADOSToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Margin = new Padding(10);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(250, 10, 10, 10);
            menuPrincipal.Size = new Size(1189, 44);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuPrincipal";
            // 
            // tABLASToolStripMenuItem
            // 
            tABLASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClientesToolStripMenuItem, ProductosToolStripMenuItem, ServiciosToolStripMenuItem });
            tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            tABLASToolStripMenuItem.Padding = new Padding(100, 0, 4, 0);
            tABLASToolStripMenuItem.Size = new Size(170, 24);
            tABLASToolStripMenuItem.Text = "TABLAS";
            // 
            // ClientesToolStripMenuItem
            // 
            ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            ClientesToolStripMenuItem.Size = new Size(163, 24);
            ClientesToolStripMenuItem.Text = "CLIENTES";
            ClientesToolStripMenuItem.Click += ClientesToolStripMenuItem_Click_1;
            // 
            // ProductosToolStripMenuItem
            // 
            ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            ProductosToolStripMenuItem.Size = new Size(163, 24);
            ProductosToolStripMenuItem.Text = "PRODUCTOS";
            ProductosToolStripMenuItem.Click += ProductosToolStripMenuItem_Click;
            // 
            // ServiciosToolStripMenuItem
            // 
            ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem";
            ServiciosToolStripMenuItem.Size = new Size(163, 24);
            ServiciosToolStripMenuItem.Text = "SERVICIOS";
            ServiciosToolStripMenuItem.Click += ServiciosToolStripMenuItem_Click;
            // 
            // gENERARDETALLEToolStripMenuItem
            // 
            gENERARDETALLEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nOTASDECREDITOToolStripMenuItem, fACTURASToolStripMenuItem });
            gENERARDETALLEToolStripMenuItem.Name = "gENERARDETALLEToolStripMenuItem";
            gENERARDETALLEToolStripMenuItem.Padding = new Padding(100, 0, 4, 0);
            gENERARDETALLEToolStripMenuItem.Size = new Size(250, 24);
            gENERARDETALLEToolStripMenuItem.Text = "GENERAR DETALLE";
            // 
            // nOTASDECREDITOToolStripMenuItem
            // 
            nOTASDECREDITOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NotaDeCreditoCToolStripMenuItem, NotaDeCreditoAToolStripMenuItem });
            nOTASDECREDITOToolStripMenuItem.Name = "nOTASDECREDITOToolStripMenuItem";
            nOTASDECREDITOToolStripMenuItem.Size = new Size(214, 24);
            nOTASDECREDITOToolStripMenuItem.Text = "NOTAS DE CREDITO";
            // 
            // NotaDeCreditoCToolStripMenuItem
            // 
            NotaDeCreditoCToolStripMenuItem.Name = "NotaDeCreditoCToolStripMenuItem";
            NotaDeCreditoCToolStripMenuItem.Size = new Size(219, 24);
            NotaDeCreditoCToolStripMenuItem.Text = "NOTA DE CREDITO C";
            NotaDeCreditoCToolStripMenuItem.Click += NotaDeCreditoCToolStripMenuItem_Click;
            // 
            // NotaDeCreditoAToolStripMenuItem
            // 
            NotaDeCreditoAToolStripMenuItem.Name = "NotaDeCreditoAToolStripMenuItem";
            NotaDeCreditoAToolStripMenuItem.Size = new Size(219, 24);
            NotaDeCreditoAToolStripMenuItem.Text = "NOTA DE CREDITO A";
            NotaDeCreditoAToolStripMenuItem.Click += NotaDeCreditoAToolStripMenuItem_Click;
            // 
            // fACTURASToolStripMenuItem
            // 
            fACTURASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FacturaAToolStripMenuItem, FacturaCToolStripMenuItem });
            fACTURASToolStripMenuItem.Name = "fACTURASToolStripMenuItem";
            fACTURASToolStripMenuItem.Size = new Size(214, 24);
            fACTURASToolStripMenuItem.Text = "FACTURAS";
            // 
            // FacturaAToolStripMenuItem
            // 
            FacturaAToolStripMenuItem.Name = "FacturaAToolStripMenuItem";
            FacturaAToolStripMenuItem.Size = new Size(156, 24);
            FacturaAToolStripMenuItem.Text = "FACTURA A";
            FacturaAToolStripMenuItem.Click += FacturaAToolStripMenuItem_Click;
            // 
            // FacturaCToolStripMenuItem
            // 
            FacturaCToolStripMenuItem.Name = "FacturaCToolStripMenuItem";
            FacturaCToolStripMenuItem.Size = new Size(156, 24);
            FacturaCToolStripMenuItem.Text = "FACTURA C";
            FacturaCToolStripMenuItem.Click += FacturaCToolStripMenuItem_Click;
            // 
            // lISTADOSToolStripMenuItem
            // 
            lISTADOSToolStripMenuItem.Name = "lISTADOSToolStripMenuItem";
            lISTADOSToolStripMenuItem.Padding = new Padding(100, 0, 4, 0);
            lISTADOSToolStripMenuItem.Size = new Size(184, 24);
            lISTADOSToolStripMenuItem.Text = "LISTADOS";
            lISTADOSToolStripMenuItem.Click += lISTADOSToolStripMenuItem_Click;
            // 
            // fechaYHoraActual
            // 
            fechaYHoraActual.Controls.Add(hora);
            fechaYHoraActual.Controls.Add(fecha);
            fechaYHoraActual.Location = new Point(962, 624);
            fechaYHoraActual.Name = "fechaYHoraActual";
            fechaYHoraActual.Size = new Size(200, 51);
            fechaYHoraActual.TabIndex = 1;
            fechaYHoraActual.TabStop = false;
            // 
            // hora
            // 
            hora.AutoSize = true;
            hora.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hora.Location = new Point(109, 19);
            hora.Name = "hora";
            hora.Size = new Size(53, 19);
            hora.TabIndex = 3;
            hora.Text = "HORA";
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fecha.Location = new Point(20, 19);
            fecha.Name = "fecha";
            fecha.Size = new Size(58, 19);
            fecha.TabIndex = 2;
            fecha.Text = "FECHA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelUsuarioActual);
            groupBox1.Location = new Point(29, 624);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 51);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // labelUsuarioActual
            // 
            labelUsuarioActual.AutoSize = true;
            labelUsuarioActual.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuarioActual.Location = new Point(155, 19);
            labelUsuarioActual.Name = "labelUsuarioActual";
            labelUsuarioActual.Size = new Size(246, 19);
            labelUsuarioActual.TabIndex = 3;
            labelUsuarioActual.Text = "NOMBRE DEL USUARIO ACTUAL";
            labelUsuarioActual.Click += labelUsuarioActual_Click;
            // 
            // PantallaDeInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1189, 687);
            Controls.Add(groupBox1);
            Controls.Add(fechaYHoraActual);
            Controls.Add(menuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuPrincipal;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PantallaDeInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador detalles de facturas";
            Load += PantallaDeInicio_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            fechaYHoraActual.ResumeLayout(false);
            fechaYHoraActual.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem tABLASToolStripMenuItem;
        private ToolStripMenuItem ClientesToolStripMenuItem;
        private ToolStripMenuItem ProductosToolStripMenuItem;
        private ToolStripMenuItem ServiciosToolStripMenuItem;
        private ToolStripMenuItem gENERARDETALLEToolStripMenuItem;
        private ToolStripMenuItem nOTASDECREDITOToolStripMenuItem;
        private ToolStripMenuItem NotaDeCreditoCToolStripMenuItem;
        private ToolStripMenuItem NotaDeCreditoAToolStripMenuItem;
        private ToolStripMenuItem fACTURASToolStripMenuItem;
        private ToolStripMenuItem FacturaAToolStripMenuItem;
        private ToolStripMenuItem FacturaCToolStripMenuItem;
        private ToolStripMenuItem lISTADOSToolStripMenuItem;
        private GroupBox fechaYHoraActual;
        private Label hora;
        private Label fecha;
        private GroupBox groupBox1;
        private Label labelUsuarioActual;
    }
}