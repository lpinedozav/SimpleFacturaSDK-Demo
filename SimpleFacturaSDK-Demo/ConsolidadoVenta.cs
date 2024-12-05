using SDKSimpleFactura;
using SDKSimpleFactura.Models.Request;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConsolidadoVenta : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ConsolidadoVenta()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
        }

        private void ConsolidadoVenta_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;

            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private async void generarConsolidadoV_Click(object sender, EventArgs e)
        {
            try
            {
                AmbienteEnum ambienteSeleccionado;

                if (radioCertificacion.Checked)
                {
                    ambienteSeleccionado = AmbienteEnum.Certificacion;
                }
                else if (radioProduccion.Checked)
                {
                    ambienteSeleccionado = AmbienteEnum.Produccion;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un ambiente (Certificación o Producción).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var request = new ListaDteRequest();
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Desde = dateTimeDesde.Value;
                request.Hasta = dateTimeHasta.Value;
                request.Ambiente = ambienteSeleccionado;
                var response = await cliente.Facturacion.ConsolidadoVentasAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var list = response.Data;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
