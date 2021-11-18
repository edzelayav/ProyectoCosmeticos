namespace Win.ProCosmeticos
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosmeticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosLimpiezaFacialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.cosmeticosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(610, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.Segurity;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.login;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.LogOut;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cosmeticosToolStripMenuItem
            // 
            this.cosmeticosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosLimpiezaFacialToolStripMenuItem,
            this.facturaToolStripMenuItem});
            this.cosmeticosToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.Cosmeticos;
            this.cosmeticosToolStripMenuItem.Name = "cosmeticosToolStripMenuItem";
            this.cosmeticosToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.cosmeticosToolStripMenuItem.Text = "Cosmeticos";
            // 
            // productosLimpiezaFacialToolStripMenuItem
            // 
            this.productosLimpiezaFacialToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.productos;
            this.productosLimpiezaFacialToolStripMenuItem.Name = "productosLimpiezaFacialToolStripMenuItem";
            this.productosLimpiezaFacialToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.productosLimpiezaFacialToolStripMenuItem.Text = "Productos ";
            this.productosLimpiezaFacialToolStripMenuItem.Click += new System.EventHandler(this.productosLimpiezaFacialToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.factura;
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idDeClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.Clientes;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // idDeClienteToolStripMenuItem
            // 
            this.idDeClienteToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.informacion;
            this.idDeClienteToolStripMenuItem.Name = "idDeClienteToolStripMenuItem";
            this.idDeClienteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.idDeClienteToolStripMenuItem.Text = "Informacion de Cliente";
            this.idDeClienteToolStripMenuItem.Click += new System.EventHandler(this.idDeClienteToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.Vendedor;
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // nombreDeVendedorToolStripMenuItem
            // 
            this.nombreDeVendedorToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.informacion1;
            this.nombreDeVendedorToolStripMenuItem.Name = "nombreDeVendedorToolStripMenuItem";
            this.nombreDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nombreDeVendedorToolStripMenuItem.Text = "Información de Vendedor";
            this.nombreDeVendedorToolStripMenuItem.Click += new System.EventHandler(this.nombreDeVendedorToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeProductosToolStripMenuItem,
            this.reporteClientesToolStripMenuItem,
            this.reporteDeFacturasToolStripMenuItem,
            this.reporteDeVendedorToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.reporte;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.reportecfv;
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.reportecfv1;
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            this.reporteDeFacturasToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.Reportefactura;
            this.reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            this.reporteDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeFacturasToolStripMenuItem.Text = "Reporte de Facturas";
            this.reporteDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasToolStripMenuItem_Click);
            // 
            // reporteDeVendedorToolStripMenuItem
            // 
            this.reporteDeVendedorToolStripMenuItem.Image = global::Win.ProCosmeticos.Properties.Resources.reportecfv2;
            this.reporteDeVendedorToolStripMenuItem.Name = "reporteDeVendedorToolStripMenuItem";
            this.reporteDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeVendedorToolStripMenuItem.Text = "Reporte de Vendedor";
            this.reporteDeVendedorToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVendedorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win.ProCosmeticos.Properties.Resources.textura_marmol_dorado_rosado_125540_836;
            this.ClientSize = new System.Drawing.Size(610, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosmeticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosLimpiezaFacialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVendedorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}