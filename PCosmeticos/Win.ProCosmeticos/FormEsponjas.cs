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
    public partial class FormEsponjas : Form
    {
       EsponjasBL _Esponjas;

        public FormEsponjas()
        {
            InitializeComponent();

            _Esponjas = new EsponjasBL();
            listaEsponjaBindingSource.DataSource = _Esponjas.ObtenerEsponja();
        }

        private void FormEsponjas_Load(object sender, EventArgs e)
        {

        }
    }
}
