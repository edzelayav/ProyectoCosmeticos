using BL.Cosmeticos;
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
    public partial class FormVendedor : Form
    {
        VendedorBL _vendedor;
        public FormVendedor()
        {
            InitializeComponent();
     
            _vendedor = new VendedorBL();
            listaVendedorBindingSource.DataSource = _vendedor.ObtenerVendedor();
           
        

    }

        private void listaVendedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaVendedorBindingSource.EndEdit();
            var vendedor = (Vendedor)listaVendedorBindingSource.Current;
            // MessageBox.Show(cliente);

            var resultado = _vendedor.GuardarVendedor(vendedor);

            if (resultado.Exitoso == true)
            {
                listaVendedorBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBottones(true);
                MessageBox.Show("Vendedor guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _vendedor.AgregarVendedor();
            listaVendedorBindingSource.MoveLast();
            DeshabilitarHabilitarBottones(false);
        }

        private void DeshabilitarHabilitarBottones(bool valor)  // Función para deshabilitar botones en el menú//
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")           //Función para que no tire error cuando este vacio//
            {
                var resultado = MessageBox.Show("Desea eliminar este Vendedor?", "Eliminar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }

        }

        private void Eliminar(int id)
        {
            var resultado = _vendedor.EliminarVendedor(id);

            if (resultado == true)                                     //Si el resultado es verdadero resetea o refresca la lista//
            {
                listaVendedorBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al eliminar el Vendedor");    // Muestra un mensaje de error//
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBottones(true);
            Eliminar(0);
        }
    }
}
