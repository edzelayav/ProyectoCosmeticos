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

    public partial class FormMaquillaje : Form
    {
        MaquillajeBL _Maquillaje;

        public FormMaquillaje()
        {
            InitializeComponent();
          _Maquillaje = new MaquillajeBL();
            listaMaquillajeBindingSource.DataSource = _Maquillaje.ObtenerMaquillaje();
        }

        private void FormMaquillaje_Load(object sender, EventArgs e)
        {
            

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void listaMaquillajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaMaquillajeBindingSource.EndEdit();
            var maquillaje = (Maquillaje) listaMaquillajeBindingSource.Current;  //enlace para boton de guardar producto maquillaje//

            var resultado = _Maquillaje.GuardarMaquillaje(maquillaje);

            if (resultado == true)
            {
                listaMaquillajeBindingSource.ResetBindings(false);  //Lo resetea porque hubo un cambio de valores en la lista//
            }
            else
            {
                MessageBox.Show("Error al guardar el producto Maquillaje"); // Muestra un mensaje de error//
            }
        

    }
}
}

