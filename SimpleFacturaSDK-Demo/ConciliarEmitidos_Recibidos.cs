using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConciliarEmitidos_Recibidos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ConciliarEmitidos_Recibidos()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
        }

        private void ConciliarEmitidos_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textMes.Value = 5;
            textAnio.Value = 2024;
        }

        private async void generarEmitidos_Click(object sender, EventArgs e)
        {
            // Show the loading indicator on the button (or another control if you prefer)
            Loading.ShowLoading(generarEmitidos);

            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;
                var mes = (int)textMes.Value;
                var anio = (int)textAnio.Value;

                // Perform the asynchronous API call
                var response = await cliente.Facturacion.ConsolidadoEmitidosAsync(request, mes, anio);

                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textRespuesta.Text = $"Estado: {response.Status}\r\n" +
                                         $"Mensaje: {response.Message}\r\n" +
                                         $"Datos: {response.Data ?? "Ninguno"}\r\n" +
                                         $"Errores: {(response.Errors != null ? string.Join(", ", response.Errors) : "Ninguno")}\r\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Hide the loading indicator once the request is done (success or failure)
                Loading.HideLoading(generarEmitidos);
            }
        }


    }
}
