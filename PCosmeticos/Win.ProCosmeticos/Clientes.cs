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
    public partial class Clientes : Form
    {
        ClientesBL _clientes;

        public Clientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerCliente();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaClientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente) listaClientesBindingSource.Current;
            // MessageBox.Show(cliente);

            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBottones(true);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClientesBindingSource.MoveLast();
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
                var resultado = MessageBox.Show("Desea eliminar este Cliente?", "Eliminar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }


        }

        private void Eliminar(int id)
        {
            var resultado = _clientes.EliminarCliente(id);

            if (resultado == true)                                     //Si el resultado es verdadero resetea o refresca la lista//
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al eliminar el Cliente");    // Muestra un mensaje de error//
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBottones(true);
            Eliminar(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
