using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConsultaFoliosDisponibles : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ConsultaFoliosDisponibles()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void ConsultaFoliosDisponibles_Load(object sender, EventArgs e)
        {
            textRutEmpresa.Text = _appSettings.Credenciales.RutEmisor;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            comboBoxCodigoTipoDTE.SelectedIndex = 3;
            radioCertificacion.Checked = true;
            radioProduccion.Checked = false;
        }

        private async void generarConsultaFolios_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(textRespuesta);

            try
            {
                SolicitudFoliosRequest request = new SolicitudFoliosRequest();
                request.RutEmpresa = textRutEmpresa.Text;
                request.TipoDTE = (int)EnumHelper.ObtenerValorSeleccionado<DTEType>(comboBoxCodigoTipoDTE);
                if (radioCertificacion.Checked) request.Ambiente = (int)Ambiente.AmbienteEnum.Certificacion;
                if (radioProduccion.Checked) request.Ambiente = (int)Ambiente.AmbienteEnum.Produccion;
                var response = await cliente.Folio.ConsultaFoliosDisponiblesAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
