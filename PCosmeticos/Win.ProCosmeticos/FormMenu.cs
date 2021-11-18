using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ProCosmeticos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();


        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario: " + Utilidades.NombreUsuario;

        }

        private void productosLimpiezaFacialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void maquillajeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void esponjasToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();


        }

        private void idDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idClintes = new Clientes();
            idClintes.MdiParent = this;
            idClintes.Show();
        }

        private void nombreDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nombreClientes = new Clientes();
            nombreClientes.MdiParent = this;
            nombreClientes.Show();
        }


        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }
        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteClientes = new FormReporteClientes();
            formReporteClientes.MdiParent = this;
            formReporteClientes.Show();
        }

        private void nombreDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVendedor = new FormVendedor();
            formVendedor.MdiParent = this;
            formVendedor.Show();
        }

        private void reporteDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteVendedor = new FormReporteVendedor();
            formReporteVendedor.MdiParent = this;
            formReporteVendedor.Show();
        }
    }
}


    
