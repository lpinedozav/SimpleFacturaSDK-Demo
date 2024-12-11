using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
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
            string projectDirectory = Path.Combine(baseDirectory, @"..\..\"); // Subir al nivel raíz del proyecto
            string filePath = Path.Combine(projectDirectory, "Files", "ejemplo_carga_masiva_nacional.csv");
            txtRutaArchivo.Text = filePath;
        }

        private async void generarMasiva_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(textRespuesta);

            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;
                request.NombreSucursal = textNombreSucursal.Text;
                var path = txtRutaArchivo.Text;
                var response = await cliente.Facturacion.FacturacionMasivaAsync(request, path);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(response.Message, response.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textRespuesta.Text = $"Estado: {response.Status}\r\n" +
                         $"Mensaje: {response.Message}\r\n" +
                         $"Datos: {response.Data}\r\n" +
                         $"Errores: {(response.Errors != null ? string.Join(", ", response.Errors) : "Ninguno")}\r\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(textRespuesta);
            }
        }
    }
}
