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
    public partial class FormReporteVendedor : Form
    {
        public FormReporteVendedor()
        {
            InitializeComponent();

            var _vendedorBL = new VendedorBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _vendedorBL.ObtenerVendedor();

            var reporte = new ReporteVendedor();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
