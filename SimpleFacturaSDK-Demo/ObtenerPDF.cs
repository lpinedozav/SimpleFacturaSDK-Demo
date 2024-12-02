using SDKSimpleFactura.Models.Facturacion;
using System;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerPDF : Form
    {
        public ObtenerPDF()
        {
            InitializeComponent();
        }
        private void ObtenerPDF_Load(object sender, EventArgs e)
        {
            var cliente = SimpleClientSingleton.Instance;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new SolicitudDte();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
