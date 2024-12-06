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
    public partial class FacturacionMasiva : Form
    {
        public FacturacionMasiva()
        {
            InitializeComponent();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecciona un archivo";
                openFileDialog.Filter = "Archivos de texto (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar la ruta seleccionada en el TextBox
                    txtRutaArchivo.Text = openFileDialog.FileName;
                }
            }
        }

        private void FacturacionMasiva_Load(object sender, EventArgs e)
        {

        }
    }
}
