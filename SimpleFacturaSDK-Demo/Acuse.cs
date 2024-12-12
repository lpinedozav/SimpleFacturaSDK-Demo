using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Diagnostics;
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

            string descripcion =
                "Permite dar acuse de recibo a documentos recibidos de proveedores.";

            textDocumentacion.Text = descripcion;
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

        private void linkLabelAcuse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://documentacion.simplefactura.cl/#b6f2fb90-10e1-4bf0-a9cb-615ae9b4343d";

            // Abrir la URL en el navegador predeterminado
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir la URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
