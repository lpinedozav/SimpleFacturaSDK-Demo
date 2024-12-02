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
        private void obtener_pdf_Click(object sender, EventArgs e)
        {
            ObtenerPDF formulario = new ObtenerPDF();
            formulario.Show();
        }

        private void ObtenerTimbre_Click(object sender, EventArgs e)
        {
            ObtenerTimbre formulario = new ObtenerTimbre();
            formulario.Show();

        }


        private void Configuracion_Click(object sender, EventArgs e)
        {
            Configuracion formulario = new Configuracion();
            formulario.Show();
        }

        private void obtener_xml_Click(object sender, EventArgs e)
        {
            ObtenerXML formulario = new ObtenerXML();
            formulario.Show();
        }

        private void obtener_dte_Click(object sender, EventArgs e)
        {
            ObtenerDTE formulario = new ObtenerDTE();
            formulario.Show();
        }

        private void obtener_sobre_xml_Click(object sender, EventArgs e)
        {
            ObtenerSobreXML formulario = new ObtenerSobreXML();
            formulario.Show();
        }
    }
}
