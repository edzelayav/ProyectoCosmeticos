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
    public partial class FormProductos : Form
    {
        ProductosBL _productos;
        public FormProductos()
        {
            InitializeComponent();
            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void listaProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();  //esto es para que finalice la edicion en la funcion de guardar producto//
            var producto = (Producto)listaProductosBindingSource.Current; //enlace para boton de guardar producto//

            var resultado = _productos.GuardarProducto(producto);

            if (resultado == true)           //Si el resultadoe es verdadero
            {
                listaProductosBindingSource.ResetBindings(false);   //Lo resetea porque hubo un cambio de valores en la lista//
            }
            else
            {
                MessageBox.Show("Error al guardar el producto"); // Muestra un mensaje de error//
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTextBox.Text);
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)                                     //Si el resultado es verdadero resetea o refresca la lista//
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto");    // Muestra un mensaje de error//
            }

        }
    }
}
