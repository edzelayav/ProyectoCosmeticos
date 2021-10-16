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
    }
}
