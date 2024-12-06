using SDKSimpleFactura;
using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class FacturacionMasiva : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public FacturacionMasiva()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
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
            cliente = SimpleClientSingleton.Instance;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "Files", "ejemplo_carga_masiva_nacional.csv");
            txtRutaArchivo.Text = relativePath;
        }

        private void generarMasiva_Click(object sender, EventArgs e)
        {

        }
    }
}
