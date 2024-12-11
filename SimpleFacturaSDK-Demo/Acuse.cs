using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class Acuse : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public Acuse()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            EnumHelper.LlenarComboBoxConEnum<ResponseType>(comboBoxRespuesta);
            EnumHelper.LlenarComboBoxConEnum<RejectionType>(comboBoxTipoRechazo);

        }

        private void Acuse_Load(object sender, EventArgs e)
        {
            //credenciales
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textRutContribuyente.Text = _appSettings.Credenciales.RutContribuyente;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            numericFolio.Value = 4117;
        }

        private async void generarAcuse_Click(object sender, EventArgs e)
        {

            Loading.ShowLoading(generarAcuse);
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
                var request = new AcuseReciboExternoRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(),
                    DteReferenciadoExterno = new SDKSimpleFactura.Models.Facturacion.DteReferenciadoExterno()
                };
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.RutContribuyente = textRutContribuyente.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;

                request.DteReferenciadoExterno.Folio = (int)numericFolio.Value;
                request.DteReferenciadoExterno.CodigoTipoDte = (int)EnumHelper.ObtenerValorSeleccionado<DTEType>(comboBoxCodigoTipoDTE);
                request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;
                request.Respuesta = EnumHelper.ObtenerValorSeleccionado<ResponseType>(comboBoxRespuesta);
                request.TipoRechazo = EnumHelper.ObtenerValorSeleccionado<RejectionType>(comboBoxTipoRechazo);
                request.Comentario = TextComentario.Text;
                var response = await cliente.Proveedores.AcuseReciboAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(response.Message, response.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarAcuse);
            }

        }
    }
}
