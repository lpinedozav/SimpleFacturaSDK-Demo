using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerXML : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ObtenerXML()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oXML);
        }

        private void ObtenerXML_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            tipodte_oXML.SelectedIndex = 3;
            textRutE.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            ChangeUI();
        }

        private async void generarXml_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarXml);
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
                Response<byte[]> response;
                if (radioButton_emitidoXml.Checked)
                {
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(),
                        DteReferenciadoExterno = new DteReferenciadoExterno()
                    };

                    request.Credenciales.RutEmisor = textRutE.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)EnumHelper.ObtenerValorSeleccionado<DTEType>(tipodte_oXML);
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;
                    response = await cliente.Facturacion.ObtenerXmlDteAsync(request);
                }
                else
                {
                    var request = new SDKSimpleFactura.Models.Request.ListaDteRequest()
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                    };
                    request.Credenciales.RutEmisor = textRutE.Text;
                    request.Credenciales.RutContribuyente = textRutContribuyente.Text;
                    request.CodigoTipoDte = EnumHelper.ObtenerValorSeleccionado<DTEType>(tipodte_oXML);
                    request.Ambiente = ambienteSeleccionado;
                    request.Folio = (int)folio_oPDF.Value;
                    response = await cliente.Proveedores.ObtenerXmlAsync(request);
                }
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                        string directoryPath = Path.Combine(projectDirectory, "Files");
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        string filePath = Path.Combine(directoryPath, $"XML_{DateTime.Now:yyyyMMdd_HHmmss}.xml");
                        File.WriteAllBytes(filePath, response.Data);

                        // Abrir el archivo XML en el navegador predeterminado
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });

                        MessageBox.Show($"El XML se ha guardado correctamente en: {filePath}\nSe ha abierto en el navegador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar o abrir el XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarXml);
            }
        }

        private void radioButton_emitidoXml_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void radio_Bton_recibidoXml_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }
        private void ChangeUI()
        {
            if (radioButton_emitidoXml.Checked)
            {
                textRutContribuyente.Enabled = false;
                textNombreSucursal.Enabled = true;
                folio_oPDF.Value = 4117;

                // Cambiar el texto de la documentación para "emitido XML"
                textDocumentacion.Text = "permite generar y descargar archivo XML, correspondiente a DTE emitido en portal SimpleFactura.";
            }
            else if (radio_Bton_recibidoXml.Checked)
            {
                textNombreSucursal.Enabled = false;
                textRutContribuyente.Enabled = true;
                textRutContribuyente.Text = "76269769-6";
                folio_oPDF.Value = 4405;

                // Cambiar el texto de la documentación para "recibido XML"
                textDocumentacion.Text = "Permite obtener el XML(base64) de un DTE recibido. Es importante señalar que sólo se entregará el XML si este se encuentra en la casilla intercambio@chilesystems.com";
            }
        }

        private void linkLabelXml_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Definir las URLs para emitido y recibido
            string urlEmitidoXml = "https://documentacion.simplefactura.cl/#4527ab77-ae8a-4427-aeab-aed8db42026c";
            string urlRecibidoXml = "https://documentacion.simplefactura.cl/#e70aed3b-a062-4aaf-9fac-011021f31987"; // Cambia a la URL correspondiente

            // Determinar cuál URL usar en función del RadioButton seleccionado
            string url;
            if (radioButton_emitidoXml.Checked)
            {
                url = urlEmitidoXml;
            }
            else if (radio_Bton_recibidoXml.Checked)
            {
                url = urlRecibidoXml;
            }
            else
            {
                MessageBox.Show("Selecciona una opción antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar abrir la URL en el navegador predeterminado
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
