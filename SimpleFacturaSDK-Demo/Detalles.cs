using SDKSimpleFactura.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {

        }
        public void SetDetalles(List<DetalleDte> detalles)
        {
            dataGridViewDetalles.DataSource = detalles;

        }
    }
}
