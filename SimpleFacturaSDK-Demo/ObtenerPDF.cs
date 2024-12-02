using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            }
            catch (Exception ex)
            {

            }
        }

    }
}
