using SimpleFacturaSDK_Demo.Models;
using System;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            


        }

        private void obtener_pdf_Click(object sender, EventArgs e)
        {
            ObtenerPDF formulario = new ObtenerPDF();
            formulario.Show();
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            Configuracion formulario = new Configuracion();
            formulario.Show();
        }
    }
}
