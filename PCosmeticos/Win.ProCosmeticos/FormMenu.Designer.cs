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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
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
            this.cosmeticosToolStripMenuItem.Name = "cosmeticosToolStripMenuItem";
            this.cosmeticosToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.cosmeticosToolStripMenuItem.Text = "Cosmeticos";
            // 
            // productosLimpiezaFacialToolStripMenuItem
            // 
            this.productosLimpiezaFacialToolStripMenuItem.Name = "productosLimpiezaFacialToolStripMenuItem";
            this.productosLimpiezaFacialToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.productosLimpiezaFacialToolStripMenuItem.Text = "Productos ";
            this.productosLimpiezaFacialToolStripMenuItem.Click += new System.EventHandler(this.productosLimpiezaFacialToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idDeClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // idDeClienteToolStripMenuItem
            // 
            this.idDeClienteToolStripMenuItem.Name = "idDeClienteToolStripMenuItem";
            this.idDeClienteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.idDeClienteToolStripMenuItem.Text = "Informacion de Cliente";
            this.idDeClienteToolStripMenuItem.Click += new System.EventHandler(this.idDeClienteToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // nombreDeVendedorToolStripMenuItem
            // 
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
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            this.reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            this.reporteDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeFacturasToolStripMenuItem.Text = "Reporte de Facturas";
            this.reporteDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasToolStripMenuItem_Click);
            // 
            // reporteDeVendedorToolStripMenuItem
            // 
            this.reporteDeVendedorToolStripMenuItem.Name = "reporteDeVendedorToolStripMenuItem";
            this.reporteDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeVendedorToolStripMenuItem.Text = "Reporte de Vendedor";
            this.reporteDeVendedorToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVendedorToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win.ProCosmeticos.Properties.Resources.textura_marmol_dorado_rosado_125540_836;
            this.ClientSize = new System.Drawing.Size(610, 361);
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
    }
}